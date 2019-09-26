#pragma once

#define DLLIMPORT       extern "C" __declspec(dllimport)


#define TALK_MODE_LISTEN        0x01 // �ͻ��˼��� -> �豸��������
#define TALK_MODE_SPEAK         0x02 // �ͻ��˺��� -> �ͻ���������
#define TALK_MODE_FULL          (TALK_MODE_LISTEN | TALK_MODE_SPEAK)
#define MAX_DEVICE_INFO_SUM		65535
#define CD_GUID_LEN				30

/* ������豸��Ϣ */
typedef struct
{
	/// �豸��ʱ����ID��
	unsigned int		client_id;
	/// �豸ȫ��Ψһ��ʶ��
	unsigned char		guid[CD_GUID_LEN];
	/// �豸�Ƿ�����
	unsigned char		online;
	/// �豸�Ƿ񽻻���Ϣ��ϣ����ڿ���״̬
	unsigned char		ready;
	int					last_online_time;
}client_info_lite;

/* ������豸��Ϣ�б� */
typedef struct
{
	/// �豸��Ϣ�ṹ���б�
	client_info_lite	client_info[MAX_DEVICE_INFO_SUM];
	/// �豸���߸���
	unsigned int		client_online;
	/// �ܵ������豸������������δ���߸���
	unsigned int		client_all;
}client_info_all;

typedef void(CALLBACK *p_msg_callback)(int      msg_id,
									   char     *msg_info,  
                                       int      arg1,
                                       int      arg2,
                                       void     *data1,  
                                       int      data1_len,  
                                       void     *data2, 
                                       int      data2_len);


/**
  * ***********************************************************************
  * @brief  �ͻ��˺ͷ�����ͨ��ע��ص�����
  *         
  * @param  msg_callback: �ص������ӿ�ָ��
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_ALL_regeist_msg_callback(p_msg_callback msg_callback);

/**
  * ***********************************************************************
  * @brief	�򿪵��Դ���
  *
  * @retval void:  ����Ϊ��
  *
  * @attention     ��
  * ***********************************************************************
  */
DLLIMPORT
void SDK_NSK_ALL_open_console(void);

/**
  * ***********************************************************************
  * @brief	�رյ��Դ���
  *
  * @retval void:  ����Ϊ��
  *
  * @attention     ��
  * ***********************************************************************
  */
DLLIMPORT
void SDK_NSK_ALL_close_console(void);

/*******************************************************************************
**               ____  _____ ______     _______ ____  
**              / ___|| ____|  _ \ \   / / ____|  _ \
**              \___ \|  _| | |_) \ \ / /|  _| | |_) |
**               ___) | |___|  _ < \ V / | |___|  _ < 
**              |____/|_____|_| \_\ \_/  |_____|_| \_\
**  
*******************************************************************************/

/**
  * ***********************************************************************
  * @brief  ��ʼ��������SDK
  *         
  * @param  sdk_port:               ���ؼ����˿ڣ�Ĭ��Ϊ48624
  * @param  sdk_xml_cfg_full_path:  SDK�����ļ��洢·��
  * @param  default_save_file_dir:  SDK�洢�ļ���·��
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_SERVER_init(int sdk_port, const char *sdk_xml_cfg_full_path, const char *default_save_file_dir);

/**
  * ***********************************************************************
  * @brief  ����ʼ��������SDK
  *         
  * @retval int: ��������б�
  *
  * @confirm    : 
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_SERVER_deinit(void);

/**
  * ***********************************************************************
  * @brief	��ȡ���ӵ����������豸�Ƿ�������״̬
  *			
  * @param  device_guid:        �豸GUID
  *
  * @retval int: @arg -1 : �豸������
  *              @arg  0 : �豸������
  *              @arg  1 : �豸����
  * @confirm	: 
  * @attention	: ��������ж��豸�Ƿ��������ӹ��������������-1������0����
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_SERVER_get_devcie_online(char *device_guid);


/*******************************************************************************
**                    ____ _     ___ _____ _   _ _____
**                   / ___| |   |_ _| ____| \ | |_   _|
**                  | |   | |    | ||  _| |  \| | | |
**                  | |___| |___ | || |___| |\  | | |
**                   \____|_____|___|_____|_| \_| |_|
**
*******************************************************************************/

/**
  * ***********************************************************************
  * @brief  ��ʼ���ͻ���SDK
  *         
  * @param  server_addr:            Ŀ��������ַ�����ַ, "127.0.0.1"
  * @param  server_port:            Ŀ��������˿�
  * @param  client_guid:            ���ͻ��˶˿�
  * @param  sdk_xml_cfg_full_path:  SDK�����ļ��洢·��
  * @param  default_save_dir:       SDK�洢�ļ���·��
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_init(char       *server_addr, 
						int         server_port, 
						char       *client_guid, 
						const char *sdk_xml_cfg_full_path, 
						const char *default_save_dir);

/**
  * ***********************************************************************
  * @brief  ����ʼ���ͻ���SDK
  *         
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_deinit(void);

/**
  * ***********************************************************************
  * @brief  �����Ƿ�ʹ��Ӳ��������Ӳ����Ⱦ, ���´���Ƶ��Ч
  *         
  * @param  decoder_accel:        Ӳ������, 0�ر� 1����
  * @param  render_accel:         Ӳ����Ⱦ, 0�ر� 1����
  *         
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_set_hardware_accel(int decoder_accel,
									int render_accel);

/**
  * ***********************************************************************
  * @brief  ���豸ʵʱ��Ƶͨ��
  *         
  * @param  device_guid:        �豸GUID
  * @param  video_channel:      �豸��Ƶͨ������0��ʼ��31
  * @param  video_channel_sub:  �豸��Ƶͨ���������ͣ�1:��������2:������
  * @param  client_record_path: �ڿͻ��˵�¼���ַ����Ե�ַ��������¼������ 0x00/NULL
  * @param  server_record_path: �ڷ�������¼���ַ����Ե�ַ��������¼������ 0x00/NULL
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT 
int SDK_NSK_CLIENT_open_rt_video(char *device_guid, 
                                 int  video_channel, 
                                 int  video_channel_sub, 
                                 HWND handle,
                                 char *client_record_path,
                                 char *server_record_path);

/**
  * ***********************************************************************
  * @brief  �ر��豸ʵʱ��Ƶͨ��
  *         
  * @param  device_guid:        �豸GUID
  *	@param  hwnd:				���ھ��
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_close_rt_video(HWND hwnd);

/**
  * ***********************************************************************
  * @brief  ���豸¼��ط���Ƶͨ��
  *         
  * @param  device_guid:        �豸GUID
  * @param  video_channel:      �豸��Ƶͨ������0��ʼ��31
  * @param  start_ts:           �豸��Ƶͨ��ʼʱ���
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_start_pb_video(const char *device_guid, int chnn, int start_ts, HWND handle);

/**
  * ***********************************************************************
  * @brief  �ر��豸¼��ط���Ƶͨ��
  *         
  * @param  device_guid:        �豸GUID
  *	@param  handle:				���ھ��
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_stop_pb_video(HWND handle);

/**
  * ***********************************************************************
  * @brief  ����ָ���ļ����豸��
  *         
  * @param  dev_guid:       �豸GUID
  * @param  save_server:    �Ƿ��ļ�Ҳ�ڷ���������
  * @param  file_path:      λ���豸Դ�ļ�·������Ե�ַ
  * @param  store_path:     �ڿͻ��˵ĵĴ洢·������Ե�ַ
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_push_file(const char *dev_guid, 
                             int        save_server, 
                             const char *file_path, 
                             const char *store_path);

/**
  * ***********************************************************************
  * @brief  ���豸��ȡָ���ļ�
  *         
  * @param  dev_guid:       �豸GUID
  * @param  save_server:    �Ƿ��ļ�Ҳ�ڷ���������
  * @param  dev_path:       �豸�ļ�·��
  * @param  save_path:      �����ļ����·��
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_get_file(const char *dev_guid, 
                            int         save_server, 
                            const char *dev_path, 
                            const char *save_path);

/**
  * ***********************************************************************
  * @brief  ������ǰ�ͻ��˵�ָ���豸�Խ�
  *         
  * @param  dev_guid:           �豸GUID
  * @param  chnn:               �Խ����ͨ����
  * @param  talk_mode:          �Խ�ģʽ
  * @param  client_record_path: �ڿͻ��˵�¼���ַ����Ե�ַ��������¼������ 0x00/NULL
  * @param  server_record_path: �ڷ�������¼���ַ����Ե�ַ��������¼������ 0x00/NULL
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_start_talk(const char *dev_guid, 
                              int        chnn, 
                              int        talk_mode, 
                              char       *client_record_path,
                              char       *server_record_path);

/**
  * ***********************************************************************
  * @brief  �رյ�ǰ�ͻ��˵�ָ���豸�Խ�
  *         
  * @param  dev_guid: �豸GUID
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_close_talk(const char *dev_guid);

/**
  * ***********************************************************************
  * @brief  �رյ�ǰ�ͻ��˵����жԽ�
  *         
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_close_all_talk(void);

/**
  * ***********************************************************************
  * @brief  Զ�������豸
  *         
  * @param  dev_guid:   �豸GUID
  *
  * @retval int: ��������б�
  *
  * @confirm    : 
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_reboot_device(const char *dev_guid);

/**
  * ***********************************************************************
  * @brief  Զ���޸�osd
  *         
  * @param  dev_guid:   �豸GUID
  *
  * @retval int: ��������б�
  *
  * @confirm    : 
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_dev_modify_osd(const char* dev_guid, int chnn, const char* base64_osd);

/**
  * ***********************************************************************
  * @brief  ��ȡ��ǰ�ͻ��������������״̬
  *
  * @retval int: 0, �ͻ��˲�����  1,�ͻ�������
  *              
  * @confirm    : 
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_is_online();

/**
  * ***********************************************************************
  * @brief  ��ȡ�������豸����
  *         
  * @param  guid:     �豸GUID
  * @param  cfg_file: �����ļ�����
  * @param  cfg_name: �����ļ�������������
  * @param  cfg_val:  �����ļ���������ֵ����Ϊ��ȡ����ֵ������ 0x00/NULL
  *
  * @retval int: ��������б�
  *
  * @confirm    : 
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_gset_config(char *guid,
                               char *cfg_file,
                               char *cfg_name,
                               char *cfg_val);