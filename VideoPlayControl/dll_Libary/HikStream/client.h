/*****************************************************
Copyright 2007-2008 Hikvision Digital Technology Co., Ltd.   
FileName: client.h
Description:  	 
Author: guanguochen       
Date: 2008.5.11     
*****************************************************/
#ifndef __CLIENT_H__
#define __CLIENT_H__

#ifdef CLIENT_EXPORTS
#define CLIENT_API __declspec(dllexport)
#else
#define CLIENT_API __declspec(dllimport)
#endif

#ifdef __cplusplus
extern "C" {
#endif

#include "clntsink.h"
typedef int (__stdcall *pDataRec)(int sid, int iusrdata, int idatatype, char* pdata, int ilen);
typedef int (__stdcall *pMsgBack)(int sid, int opt, int param1, int param2);
typedef int HSESSION;

CLIENT_API int __stdcall InitStreamClientLib(void);
CLIENT_API int __stdcall FiniStreamClientLib(void);
CLIENT_API HSESSION __stdcall HIKS_CreatePlayer(IHikClientAdviseSink* pSink, void* pWndSiteHandle, pDataRec pRecFunc, pMsgBack pMsgFunc = 0,int TransMethod = 0);
CLIENT_API int __stdcall HIKS_OpenURL(HSESSION hSession,const char* pszURL,int iusrdata);
CLIENT_API int __stdcall HIKS_Play(HSESSION hSession);
CLIENT_API int __stdcall HIKS_RandomPlay(HSESSION hSession,unsigned long timepos);
CLIENT_API int __stdcall HIKS_Pause(HSESSION hSession);
CLIENT_API int __stdcall HIKS_Resume(HSESSION hSession);
CLIENT_API int __stdcall HIKS_Stop(HSESSION hSession);
CLIENT_API int __stdcall HIKS_GetCurTime(HSESSION hSession,unsigned long *utime);
CLIENT_API int __stdcall HIKS_ChangeRate(HSESSION hSession,int scale);
CLIENT_API int __stdcall HIKS_Destroy(HSESSION hSession);
CLIENT_API int __stdcall HIKS_GetVideoParams(HSESSION hSession, int *ibri, int *icon, int *isat, int *ihue);
CLIENT_API int __stdcall HIKS_SetVideoParams(HSESSION hSession, int ibri, int icon, int isat, int ihue);
CLIENT_API int __stdcall HIKS_PTZControl(HSESSION hSession, unsigned int ucommand, int iparam1, int iparam2, int iparam3, int iparam4);
CLIENT_API int __stdcall HIKS_SetVolume(HSESSION hSession,unsigned short volume);
CLIENT_API int __stdcall HIKS_OpenSound(HSESSION hSession,bool bExclusive=false);
CLIENT_API int __stdcall HIKS_CloseSound(HSESSION hSession);
CLIENT_API int __stdcall HIKS_ThrowBFrameNum(HSESSION hSession,unsigned int nNum);
CLIENT_API int __stdcall HIKS_GrabPic(HSESSION hSession,const char* szPicFileName, unsigned short byPicType);

#ifdef __cplusplus
}
#endif

#endif

/**************************/
/*��̨���������뼰��������*/
/************************************************************************************************
2	��	��ͨ�ƹ��Դ			(Param1: 1-��ʼ/0-ֹͣ, Param2: ��Ч, Param3: ��Ч, Param4: ��Ч)
3	��	��ͨ��ˢ����			(Param1: 1-��ʼ/0-ֹͣ, Param2: ��Ч, Param3: ��Ч, Param4: ��Ч)
4	��	��ͨ���ȿ���			(Param1: 1-��ʼ/0-ֹͣ, Param2: ��Ч, Param3: ��Ч, Param4: ��Ч)
5	��	��ͨ����������			(Param1: 1-��ʼ/0-ֹͣ, Param2: ��Ч, Param3: ��Ч, Param4: ��Ч)
6	��	��ͨ�����豸����		(Param1: 1-��ʼ/0-ֹͣ, Param2: ��Ч, Param3: ��Ч, Param4: ��Ч)

11	��	������(���ʱ��)		(Param1: 1-��ʼ/0-ֹͣ, Param2: �ٶ� [0-10,0��ʾĬ���ٶ�,1-10��ʾ�ٶȼ���], Param3: ��Ч, Param4: ��Ч)
12	��	�����С(���ʱ�С)		(Param1: 1-��ʼ/0-ֹͣ, Param2: �ٶ� [0-10,0��ʾĬ���ٶ�,1-10��ʾ�ٶȼ���], Param3: ��Ч, Param4: ��Ч)
13	��	����ǰ��				(Param1: 1-��ʼ/0-ֹͣ, Param2: �ٶ� [0-10,0��ʾĬ���ٶ�,1-10��ʾ�ٶȼ���], Param3: ��Ч, Param4: ��Ч)
14	��	������				(Param1: 1-��ʼ/0-ֹͣ, Param2: �ٶ� [0-10,0��ʾĬ���ٶ�,1-10��ʾ�ٶȼ���], Param3: ��Ч, Param4: ��Ч)
15	��	��Ȧ����				(Param1: 1-��ʼ/0-ֹͣ, Param2: �ٶ� [0-10,0��ʾĬ���ٶ�,1-10��ʾ�ٶȼ���], Param3: ��Ч, Param4: ��Ч)
16	��	��Ȧ��С				(Param1: 1-��ʼ/0-ֹͣ, Param2: �ٶ� [0-10,0��ʾĬ���ٶ�,1-10��ʾ�ٶȼ���], Param3: ��Ч, Param4: ��Ч)

21	��	��̨����				(Param1: 1-��ʼ/0-ֹͣ, Param2: �ٶ� [0-10,0��ʾĬ���ٶ�,1-10��ʾ�ٶȼ���], Param3: ��Ч, Param4: ��Ч)
22	��	��̨�¸�				(Param1: 1-��ʼ/0-ֹͣ, Param2: �ٶ� [0-10,0��ʾĬ���ٶ�,1-10��ʾ�ٶȼ���], Param3: ��Ч, Param4: ��Ч)
23	��	��̨��ת				(Param1: 1-��ʼ/0-ֹͣ, Param2: �ٶ� [0-10,0��ʾĬ���ٶ�,1-10��ʾ�ٶȼ���], Param3: ��Ч, Param4: ��Ч)
24	��	��̨��ת				(Param1: 1-��ʼ/0-ֹͣ, Param2: �ٶ� [0-10,0��ʾĬ���ٶ�,1-10��ʾ�ٶȼ���], Param3: ��Ч, Param4: ��Ч)
25	��	��̨��������ת			(Param1: 1-��ʼ/0-ֹͣ, Param2: �ٶ� [0-10,0��ʾĬ���ٶ�,1-10��ʾ�ٶȼ���], Param3: ��Ч, Param4: ��Ч)
26	��	��̨��������ת			(Param1: 1-��ʼ/0-ֹͣ, Param2: �ٶ� [0-10,0��ʾĬ���ٶ�,1-10��ʾ�ٶȼ���], Param3: ��Ч, Param4: ��Ч)
27	��	��̨�¸�����ת			(Param1: 1-��ʼ/0-ֹͣ, Param2: �ٶ� [0-10,0��ʾĬ���ٶ�,1-10��ʾ�ٶȼ���], Param3: ��Ч, Param4: ��Ч)
28	��	��̨�¸�����ת			(Param1: 1-��ʼ/0-ֹͣ, Param2: �ٶ� [0-10,0��ʾĬ���ٶ�,1-10��ʾ�ٶȼ���], Param3: ��Ч, Param4: ��Ч)
29	��	��̨�����Զ�ɨ��		(Param1: 1-��ʼ/0-ֹͣ, Param2: �ٶ� [0-10,0��ʾĬ���ٶ�,1-10��ʾ�ٶȼ���], Param3: ��Ч, Param4: ��Ч)

40	��	*����Ԥ�õ�				(Param1: Ԥ�õ����[>=0], Param2: ��Ч, Param3: ��Ч, Param4: ��Ч)
41	��	*���Ԥ�õ�				(Param1: Ԥ�õ����[>=0], Param2: ��Ч, Param3: ��Ч, Param4: ��Ч)
42	��	*ת��Ԥ�õ�				(Param1: Ԥ�õ����[>=0], Param2: ��Ч, Param3: ��Ч, Param4: ��Ч)

51  -   *��ʼ����Ѳ��·��		(Param1: ��Ч, Param2: ��Ч, Param3: ��Ч, Param4: ��Ч)
52  -	*��������Ѳ��·��		(Param1: ��Ч, Param2: ��Ч, Param3: ��Ч, Param4: ��Ч)
53	��	*��Ԥ�õ����Ѳ������	(Param1: Ѳ��·�ߺ�[>=0], Param2: Ѳ�������[>=0], Param3: Ԥ�õ����[>=0], Param4: ��Ч)
54	��	*��ʼѲ��				(Param1: Ѳ��·�ߺ�[>=0], Param2: ��Ч, Param3: ��Ч, Param4: ��Ч)
55	��	*ֹͣѲ��				(Param1: Ѳ��·�ߺ�[>=0], Param2: ��Ч, Param3: ��Ч, Param4: ��Ч)
56	-	*��Ԥ�õ��Ѳ������ɾ��	(Param1: Ѳ��·�ߺ�[>=0], Param2: Ѳ�������[>=0], Param3: ��Ч, Param4: ��Ч)
57	-	*����Ѳ����ͣ��ʱ��		(Param1: Ѳ��·�ߺ�[>=0], Param2: Ѳ�������[>=0], Param3: ͣ��ʱ��[��,>=0], Param4: ��Ч)
58  -   *����Ѳ���ٶ�			(Param1: Ѳ��·�ߺ�[>=0], Param2: Ѳ�������[>=0], Param3: Ѳ���ٶ�[1-10], Param4: ��Ч)

61	��	*��ʼ��¼�켣			(Param1: ��Ч, Param2: ��Ч, Param3: ��Ч, Param4: ��Ч)
62	��	*ֹͣ��¼�켣			(Param1: ��Ч, Param2: ��Ч, Param3: ��Ч, Param4: ��Ч)
63	��	*��ʼ�켣				(Param1: ��Ч, Param2: ��Ч, Param3: ��Ч, Param4: ��Ч)

71  -   ����Ŵ���С			(Param1: ������ʼ���x����, Param2: ����������y����, Param3: ����������x����, Param4: ����������y����)

99	��	*ϵͳ��λ				(Param1: ��Ч, Param2: ��Ч, Param3: ��Ч, Param4: ��Ч)

********************************************************************************************************/