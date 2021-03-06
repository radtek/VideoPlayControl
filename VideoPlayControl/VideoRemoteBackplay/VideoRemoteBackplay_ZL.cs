﻿using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;
using VideoPlayControl.VideoRemoteBackplay.BasicClass;
using VideoPlayControl.VideoRemoteBackplay.Enum;

namespace VideoPlayControl.VideoRemoteBackplay
{
    public class VideoRemoteBackplay_ZL : IVIdeoRemoteBackplay
    {
        public VideoInfo CurrentVideoInfo
        {
            get;
            set;
        }
        public CameraInfo CurrentCameraInfo { get; set; }
        public PictureBox PicPlayMain { get; set; }

        /// <summary>
        /// 播放句柄
        /// </summary>
        public IntPtr IntPtrPlayMain
        {
            get
            {
                if (PicPlayMain != null && PicPlayMain.IsHandleCreated)
                {
                    return PubMethod.GetPicPlayMainHandle(PicPlayMain);
                }
                return IntPtr.Zero;
            }
        }

        private VideoRemoteBackplayStatus backplayStatus = VideoRemoteBackplayStatus.StandBy;
        /// <summary>
        /// 远程回放状态
        /// </summary>
        public VideoRemoteBackplayStatus BackplayStatus
        {
            get { return backplayStatus; }
            set
            {
                if (backplayStatus != value)
                {
                    backplayStatus = value;
                }
            }
        }
        public event VideoRemoteBackplayStatusChangedDelegate VideoRemoteBackplayStatusChangedEvent;

        /// <summary>
        /// 远程回放状态改变事件
        /// </summary>
        /// <param name="VideoRemoteBackplayStatusChangedValue"></param>
        private void VideoRemoteBackplayStatusChanged(object VideoRemoteBackplayStatusChangedValue)
        {
            if (VideoRemoteBackplayStatusChangedEvent != null)
            {
                VideoRemoteBackplayStatusChangedEvent(this, VideoRemoteBackplayStatusChangedValue);
            }
        }

        public VideoRemoteFileInfo[] FindRemoteFile(VideoRemotePlaySearchPara para)
        {
            return FindRemoteFile(CurrentVideoInfo, para);
        }


        public VideoRemoteFileInfo[] FindRemoteFile(VideoInfo vInfo, VideoRemotePlaySearchPara para)
        {
            return FindRemoteFile1(vInfo, para);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vInfo"></param>
        /// <param name="para"></param>
        /// <returns></returns>

        public static VideoRemoteFileInfo[] FindRemoteFile1(VideoInfo vInfo, VideoRemotePlaySearchPara para)
        {
            return null;
        }

        /// <summary>
        /// 远程回放
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public bool RemoteBackplayByTime(VideoRemotePlayByTimePara para)
        {
            return false;
        }
        private int m_nDeviceID = 0;
        private int lPlayHandle = 0;
        SDK_ZLNetSDK.fZLDownLoadPosCallBack downLoadPosCallBack;
        SDK_ZLNetSDK.fZLDataCallBack dataCallback;
        public bool StartRemoteBackplayByTime(VideoRemotePlayByTimePara para)
        {


            if (lPlayHandle > 0 )
            {
                SDK_ZLNetSDK.ZLNET_StopPlayBack(lPlayHandle);
                lPlayHandle = 0;
                PicPlayMain.Refresh();
            }

            VideoInfo vInfo = para.CameraInfo.VideoInfo;
            CameraInfo cInfo = para.CameraInfo;
            if (CurrentVideoInfo != null
                && CurrentVideoInfo.VideoServerIP == para.CameraInfo.VideoInfo.VideoServerIP
                && CurrentVideoInfo.DVSConnectPort == para.CameraInfo.VideoInfo.DVSConnectPort
                && m_nDeviceID > 0)
            {
                //表示与前一次预览是同一台视频 并且登陆成功 不在重复进行登陆操作
                CurrentVideoInfo = vInfo;
                CurrentCameraInfo = cInfo;
                DebugRelevant.DebugLog(this, "相同设备，并且登陆成功，不重复登陆");
            }
            else
            {
                if (m_nDeviceID > 0)
                {
                    SDK_ZLNetSDK.ZLNET_Logout(m_nDeviceID);
                    DebugRelevant.DebugLog(this, "ZLNET_Logout");
                    m_nDeviceID = 0;
                }
                CurrentVideoInfo = vInfo;
                CurrentCameraInfo = cInfo;
                //登陆设备
                int err = 0;
                SDK_ZLNetSDK.ZLNET_DEVICEINFO zlDevice = new SDK_ZLNetSDK.ZLNET_DEVICEINFO();
                m_nDeviceID = SDK_ZLNetSDK.ZLNET_LoginEx(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, 0, (IntPtr)0, ref zlDevice, ref err);
                if (m_nDeviceID == 0)
                {
                    DebugRelevant.DebugLog(this, "ZLNET_LoginEx Excepion,error:" + err);
                    return false;
                }

                DebugRelevant.DebugLog(this, "ZLNET_LoginEx Sueecss");
            }

            //调用按照时间回放接口
            //ZLNET_PlayBackByTimeV3
            SDK_ZLNetSDK.ZLNET_PLAY_BY_TIME_PARAM sdkpara = new SDK_ZLNetSDK.ZLNET_PLAY_BY_TIME_PARAM
            {
                nChannel = CurrentCameraInfo.Channel - 1,
                tmStart= SDK_ZLNetSDK.ConvertToNetTime(para.StartPlayTime),
                tmEnd= SDK_ZLNetSDK.ConvertToNetTime(para.EndPlayTime),
                hWnd=IntPtrPlayMain,
                nStreamType =2,
                nMediaFlag= 0,
            };
            downLoadPosCallBack = new SDK_ZLNetSDK.fZLDownLoadPosCallBack(DownLoadPosCallBack);
            dataCallback = new SDK_ZLNetSDK.fZLDataCallBack(DataCallback);
            IntPtr iPosUser = Marshal.StringToHGlobalAnsi("iPosUser");
            IntPtr iData = Marshal.StringToHGlobalAnsi("iData");
            lPlayHandle = SDK_ZLNetSDK.ZLNET_PlayBackByTimeV3(m_nDeviceID, ref sdkpara, downLoadPosCallBack, iPosUser, dataCallback, iData);
            if (lPlayHandle == 0)
            {
                SDK_ZLNetSDK.ZLNET_Logout(m_nDeviceID);
                m_nDeviceID = 0;
                UInt32 erroe = SDK_ZLNetSDK.ZLNET_GetLastError();
                DebugRelevant.DebugLog(this, "ZLNET_PlayBackByTimeV3 Exception,error:" + erroe);
                return false; 
            }

            DebugRelevant.DebugLog(this, "ZLNET_PlayBackByTimeV3 Success");

            BackplayStatus = VideoRemoteBackplayStatus.RemoteBackplayByTimeStarted;
            //回放控制
            return false;
        }


        public void DownLoadPosCallBack(int lPlayHandle, UInt32 dwTotalSize, UInt32 dwDownLoadSize, IntPtr dwUser)
        {

        }
        public int DataCallback(int lPlayHandle, UInt32 dwDataType, IntPtr pBuffer, UInt32 dwBufSize, IntPtr dwUser)
        {
            return 1;
        }

        public bool StopRemoteBackplayByTime()
        {
            //停止回放
            SDK_ZLNetSDK.ZLNET_StopPlayBack(lPlayHandle);
            DebugRelevant.DebugLog(this, "ZLNET_StopPlayBack");
            lPlayHandle = 0;
            //登出设备
            SDK_ZLNetSDK.ZLNET_Logout(m_nDeviceID);
            DebugRelevant.DebugLog(this, "ZLNET_Logout");
            m_nDeviceID = 0;
            PicPlayMain.Refresh();
            BackplayStatus = VideoRemoteBackplayStatus.StandBy;
            return false;
        }
    }
}
