/************************************************************\
*					Զ��¼��ط�ʾ��							*
*						2014-12-09							*
*															*
*		���� : Demoֻ��SDKʹ����ʾ���ã�����ʽ��Ʒ��ֱ��		*
*		ʹ�ô�Demo��ɵ��κ���ʧ���ҷ�SDK�������⣬SDK			*
*		��Ŀ�鲻�е��κ�����									*
\************************************************************/
#include <windows.h>
#include <hmsdk/hm_sdk.h>
#include <iostream>
#include <vector>

#ifdef _DEBUG
#pragma comment(lib, "hmsdkd.lib")
#else
#pragma comment(lib, "hmsdk.lib")
#endif

void on_video_data(user_data data, bool over, P_FRAME_DATA frame, hm_result res)
{
	std::cout << frame->frame_info.frame_type << std::endl;
	std::cout << "Receive video data, you should decode and display on the screen." << std::endl;
}

void main()
{
	//	��ʼ��SDK������
	hm_result res = hm_sdk_init();

	//	��¼�豸
	user_id uid = 0;
	res = hm_pu_login("192.168.20.239", 8100, "HMXXX00063948", "guest", "", CT_PC, &uid);
	if(res) return;

	//	��ѯ¼���ļ�
	find_file_handle handle = 0;
	FIND_FILE_PARAM param = {};
	param.channel = 0;
	param.record_type = HME_VR_ALARMTYPE;
	param.search_mode = HME_SM_BEG_AND_END_TIME;
	memcpy((void*)param.start_time, "2017-04-10 00:00:00", strlen("2017-04-10 00:00:00"));
	memcpy((void*)param.end_time,	"2017-04-20 00:00:00", strlen("2017-04-20 00:00:00"));
	res = hm_pu_find_file(uid, &param, &handle);
	if(res) return;

	//	�����ļ�
	std::vector<FIND_FILE_DATA> file_list;
	FIND_FILE_DATA fd = {};
	while((res = hm_pu_find_next_file(handle, &fd)) == HMEC_OK)
	{
		file_list.push_back(fd);
	}
	hm_pu_close_find_file(handle);

	//	ѡ���ļ���ʼ����
	int idx = 0;
	std::cout << "File Count : " << file_list.size() << std::endl;
	std::cout << "Input Index to Play : ";
	std::cin >> idx;

	playback_handle phandle = 0;
	PLAYBACK_RES pres = {};
	PLAYBACK_PARAM pparam = {};
	memcpy((void*)pparam.file_name, (void*)file_list[idx].file_name, strlen(file_list[idx].file_name));
	pparam.cb_data = on_video_data;
	pparam.play_mode = HME_PBM_NAME_TIME;
	res = hm_pu_open_playback(uid, &pparam, &pres, &phandle);	//	�������Ŷ�Ӧ����hm_pu_close_playback
	if(res) return;

	res = hm_pu_start_playback(phandle);	//	�������Ŷ�Ӧ����hm_pu_stop_playback
	if(res) return;

	//	���̹߳���
	SuspendThread(GetCurrentThread());

	//	�ͷ�SDK������
	hm_sdk_uninit();
}
