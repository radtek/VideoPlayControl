/************************************************************\
*			����ۺ���ʾ�����Թۿ��������豸Ϊ����			*
*						2013-12-20							*
*															*
*		���� : Demoֻ��SDKʹ����ʾ���ã�����ʽ��Ʒ��ֱ��		*
*		ʹ�ô�Demo��ɵ��κ���ʧ���ҷ�SDK�������⣬SDK			*
*		��Ŀ�鲻�е��κ�����									*
\************************************************************/
#include <windows.h>
#include <iostream>
#include <atlconv.h>
#include "hmsdk/hm_sdk.h"
#include "str_transform.hpp"
#include "rtv.hpp"

#ifdef _DEBUG
#pragma comment(lib, "hmsdkd.lib")
#else
#pragma comment(lib, "hmsdk.lib")
#endif

//	Funcs
tree_handle LoginServer(cpchar addr, uint16 port, pchar usr, pchar pwd);
node_handle SelectDevice(tree_handle dmgr);
void PrintRoot(tree_handle t);
void PrintTree(node_handle d, int32 ca, int32 tc);
void OpenRemoteVideo(node_handle node);
void OpenLocalVideo(cpchar ip, uint16 port, cpchar sn, cpchar usr, cpchar pwd);

//	Params
static uint32 g_id = 0;
//////////////////////////////////////////////////////////////////////////

//	��¼ƽ̨��ǰһ���������֮���ٽ�����һ������
tree_handle LoginServer(cpchar addr, uint16 port, pchar usr, pchar pwd)
{
	std::cout << "\n���ڵ�½ƽ̨...\n";

	hm_result res;
	server_id svr = 0;
	P_USER_INFO pui = 0;

	USES_CONVERSION;
	LOGIN_SERVER_INFO lsi = {};
	lsi.ip = addr;
	
	lsi.port = port;
	lsi.user = UnicodeToUTF8(A2W(usr));
	pchar str = UnicodeToUTF8(A2W(usr));
	std::cout << str;
	std::cout << str;
	std::cout << "\n";
	std::cout << str;
	std::cout << str;
	//lsi.user = "商丘市视频联网报警中�";
	//lsi.password = "2299579";
	lsi.password = pwd;
	lsi.plat_type = "pc";
	lsi.hard_ver = "Pentium4";
	lsi.soft_ver = "v1.1.0.1789";
	int length = sizeof(lsi.ip);
	length = sizeof(lsi.port);
	length = sizeof(lsi.user);
	length = sizeof(lsi.password);
	length = sizeof(lsi.plat_type);
	length = sizeof(lsi.hard_ver);
	length = sizeof(lsi.soft_ver);
	length = sizeof(lsi.keep_time);
	length = sizeof(lsi);
	res = hm_server_connect(&lsi, &svr, 0, 0);
	if(res != HMEC_OK) return 0;

	res = hm_server_get_device_list(svr);
	if(res != HMEC_OK) return 0;

	res = hm_server_get_user_info(svr, &pui);
	if(res != HMEC_OK) return 0;

	if(pui->use_transfer_service)
	{
		res = hm_server_get_transfer_info(svr);
		//if(res != HMEC_OK) return 0;
	}

	tree_handle htree = 0;
	res = hm_server_get_tree(svr, &htree);
	if(res != HMEC_OK) return 0;

	return htree;
}

//	��ӡ�豸��
void PrintRoot(tree_handle t)
{
	if(!t) return;
	hm_result res;
	node_handle root;
	res = hm_server_get_root(t, &root);
	if(res != HMEC_OK) return;

	int32 id;
	hm_server_get_node_id(root, &id);
	std::cout << "\n";
	std::cout << id << "(Root)";
	int32 tab_count = 1;
	PrintTree(root, 0, tab_count);
}

//	�ݹ��ӡ������
void PrintTree(node_handle d, int32 ca, int32 tc)
{
	node_handle dev;
	hm_server_get_child_at(d, ca, &dev);
	if(!dev) return;

	int32 id;
	NODE_TYPE_INFO type;
	cpchar name = NULL;
	hm_server_get_node_id(dev, &id);
	hm_server_get_node_type(dev, &type);
	hm_server_get_node_name(dev, &name);

	switch(type)
	{
	case HME_NT_DEVICE :
	case HME_NT_CHANNEL :
		{
			std::cout << "\n";
			for(int32 i = 0; i < tc; i++)
			{
				std::cout << "        ";
			}
			std::cout << "|";
			std::cout << "\n";
			for(int32 i = 0; i < tc; i++)
			{
				std::cout << "        ";
			}
			std::cout << id << "-" << Utf8ToGbk(name).c_str();
			if(type == HME_NT_DEVICE)
			{
				std::cout << "(Device)";
			}
			else if(type == HME_NT_CHANNEL)
			{
				std::cout << "(Channel)";
			}
			node_handle n;
			hm_server_get_parent(dev, &n);
			PrintTree(n, ++ca, tc);
			return;
		}
		break;
	case HME_NT_GROUP :
	case HME_NT_DVS :
		{
			std::cout << "\n";
			for(int32 i = 0; i < tc; i++)
			{
				std::cout << "        ";
			}
			std::cout << "|";
			std::cout << "\n";
			for(int32 i = 0; i < tc; i++)
			{
				std::cout << "        ";
			}
			std::cout << id << "-" << Utf8ToGbk(name).c_str();
			if(type == HME_NT_GROUP)
			{
				std::cout << "(Group)";
			}
			else if(type == HME_NT_DVS)
			{
				std::cout << "(DVS)";
			}
			PrintTree(dev, 0, ++tc);
		}
		break;
	default :
		break;
	}

	node_handle n;
	hm_server_get_parent(dev, &n);
	PrintTree(n, ++ca, --tc);
}

node_handle SelectDevice(tree_handle dmgr)
{
	std::cout << "\nThe Tree Looks Like :\n";
	PrintRoot(dmgr);
	std::cout << "\n\n";

	int32 id;
_TAG_ :
	std::cout << "Input Node ID to Get Details : ";
	std::cin >> id;
	fflush(stdin);
	while(id < 0)
	{
		std::cout << "ID Invalid!\n";
		std::cout << "Input Node ID to Get Details : ";
		std::cin >> id;
		fflush(stdin);
	}

	node_handle dev_choose;
	hm_server_find_device_by_id(dmgr, id, &dev_choose);
	if(!dev_choose) hm_server_find_group_by_id(dmgr, id, &dev_choose);
	id = -1;
	if(!dev_choose)
	{
		std::cout << "ID Invalid!\n";
		goto _TAG_;
	}

	NODE_TYPE_INFO type;
	hm_server_get_node_type(dev_choose, &type);

	switch(type)
	{
	case HME_NT_GROUP :
		{
			std::cout << std::endl;
			cpchar name;
			hm_server_get_node_name(dev_choose, &name);
			std::cout << "�������� : " << (name ? UTF8ToANSI(name) : "") << std::endl;
			std::cout << std::endl;
		}
		break;
	case HME_NT_DEVICE :
	case HME_NT_DVS :
		{
			bool b_online;
			cpchar name, sn, url;
			hm_server_get_node_name(dev_choose, &name);
			hm_server_get_device_sn(dev_choose, &sn);
			hm_server_get_device_url(dev_choose, &url);
			hm_server_is_online(dev_choose, &b_online);

			std::cout << std::endl;
			std::cout << "�豸���� : "	<< (name ? UTF8ToANSI(name) : "")	<< std::endl;
			std::cout << "�豸SN : "		<< (sn ? sn : "")					<< std::endl;
			std::cout << "�豸IP : "		<< (url ? url : "")					<< std::endl;
			if(b_online)
				std::cout << "�豸����״̬ : ����" << std::endl;
			else
				std::cout << "�豸����״̬ : ����" << std::endl;
			std::cout << std::endl;
		}
		break;
	case HME_NT_CHANNEL :
		{
			std::cout << std::endl;
			cpchar name;
			hm_server_get_node_name(dev_choose, &name);
			std::cout << "ͨ������ : " << (name ? UTF8ToANSI(name) : "") << std::endl;
			std::cout << std::endl;
		}
		break;
	default :
		break;
	}

	if(type != HME_NT_GROUP)
	{
		std::cout << "Should SDK connect this device?(y/n)";
		fflush(stdin);
		char x;
		std::cin >> x;
		if(x == 'y' || x == 'Y')
		{
			return dev_choose;
		}
		fflush(stdin);
	}

	goto _TAG_;
}

void OpenRemoteVideo(node_handle node)
{
	rtv_play_t* prtv = new rtv_play_t(g_id++);
	if(!prtv) return;
	prtv->OpenVideo(node);
}

void OpenLocalVideo(cpchar ip, uint16 port, cpchar sn, cpchar usr, cpchar pwd)
{
	rtv_play_t* prtv = new rtv_play_t(g_id++);
	if(!prtv) return;
	prtv->OpenVideo(ip, port, sn, usr, pwd);
}

void main()
{
	//	��ʼ��SDK������
	hm_result x = hm_sdk_init();
	std::cout << x ;
	std::cout <<  "\n";
	tree_handle htree = 0;
	node_handle hnode[20] = {};

_TAG_ :
	int32 choice = 0;
	std::cout << " ʵʱ��ƵDemo����\n";
	std::cout << "------------------\n";
	std::cout << "  1-�����豸\n  2-�������豸\n\n��ѡ�� : ";
	std::cin >> choice;
	switch(choice)
	{
	case 1 :
		{
			char ip[20] = {}, sn[20] = {}, usr[20] = {}, pwd[20] = {};
			uint16 port = 0;

			std::cout << "\n˵����\n1���������û���������ã�Userһ��Ϊ\"guest\"��Passwordһ��Ϊ�գ���������һ���ַ�����\n2�����ո���ɽ��и߱����л�\n\n";

			std::cout << "IP : ";		std::cin >> ip;
			std::cout << "Port : ";		std::cin >> port;
			std::cout << "SN : ";		std::cin >> sn;
			std::cout << "User : ";		std::cin >> usr;
			std::cout << "Password : ";	std::cin >> pwd;
			if(strlen(sn) == 1)			memset(sn, 0, 20);
			if(strlen(pwd) == 1)		memset(pwd, 0, 20);

			for(int32 i = 0; i < 1; i++)
			{
				OpenLocalVideo(ip, port, sn, usr, pwd);
			}
		}
		break;
	case 2 :
		{
			char svr[128] = {};
			uint16 port = 0;
			char user[128] = {};
			char pwd[128] = {};

			std::cout << std::endl;
			std::cout << "Server Addr : ";	std::cin >> svr;
			std::cout << "Server Port : ";	std::cin >> port;
			std::cout << "User Name : ";	std::cin >> user;
			std::cout << "Password : ";		std::cin >> pwd;

			//	��¼ƽ̨���û������������޸ģ�
			htree = LoginServer(svr, port, user, pwd);

			//	ѡ�������豸
			hnode[0] = SelectDevice(htree);

			//	����Ƶ
			for(int32 i = 0; i < 1; i++)
			{
				OpenRemoteVideo(hnode[0]);
			}
		}
		break;
	default :
		goto _TAG_;
		break;
	}

	//	���̹߳���
	SuspendThread(GetCurrentThread());

	//	�ͷ�SDK������
	hm_sdk_uninit();
}
