﻿using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl;
using VideoPlayControl.VideoTalk;

namespace VideoPlayControl_UseDemo
{
    public partial class Frm_VideoPlayGroupControls_PTZAndTalk : Form
    {
        public Frm_VideoPlayGroupControls_PTZAndTalk()
        {
            InitializeComponent();
        }

        private void Frm_VideoPlayGroupControls_PTZAndTalk_Load(object sender, EventArgs e)
        {
            VideoPlayControl.ProgParameter.strEzviz__AppID = "5b97c1d157474f96b8d4c75b936a0057";
            VideoPlayControl.ProgParameter.strEzviz_AppSecret = "4318d0cc4c43ca156052ba688bc9006a";
            SDKState.Ezviz_SDKInit();
            //SDKState.XMSDK_Init();
            //videoPlayGroupControls_PTZAndTalk1.bolAutoPlayVideo = true;
            //videoPlayGroupControls_PTZAndTalk1.videoPlaySet.VideoRecordEnable = true;
            //videoPlayGroupControls_PTZAndTalk1.videoPlaySet.VideoMonitorEnable = true;
            //videoPlayGroupControls_Basic1.videoPlaySet.VideoRecordFilePath = "C:\\SHIKE_Video\\4603\\20170925094530";
            //videoPlayGroupControls_Basic1.bolDisplaySDKEvent = true;
            //videoPlayGroupControls_Basic1.bolDisPlaySDKState = true;
            //videoPlayGroupControls_Basic1.videoPlaySet.PreSetPosi = 13;
            //SDKState.CloundSee_SDKInit();
            //SDKState.Ezviz_SDKInit();
            //SDKState.SKVideoSDKInit();
            //SDKState.HuaMai_Init();
            SDKState.XMSDK_Init();
            //SDKState.HikDVRSDK_Init();
            //SDKState.BlueSkySDK_Init();
            SDKState.SKVideoSDKInit("50023370", "192.168.2.19", 47624,47724, 47824, 47924);

            //HuaMaiVideo_TestData();
            //SDKState.SKNVideoSDK_Init("192.168.2.19", 48624, "xhc1", "", "C:\\SHIKE_Video");
            //SDKState.DHVideoSDK_Init();
            //SDKState.SKVideoSDKInit("hdc", "121.41.87.203");
            Dictionary<string, VideoInfo> dicVideoInfos = new Dictionary<string, VideoInfo>();
            //VideoInfo v = TestDataSource.TestDataSource.GetSKDVSData1();
            //dicVideoInfos[v.DVSNumber] = v;
            VideoInfo v = TestDataSource.XMDataSource.GetData3();
            dicVideoInfos[v.DVSNumber] = v;
            videoPlayGroupControls_PTZAndTalk1.bolPreViewPwdVerify = false;
            videoPlayGroupControls_PTZAndTalk1.PreViewPwdVerifyEvent += PreViewPwdVerify;
            videoPlayGroupControls_PTZAndTalk1.videoPlaySet.VideoRecordEnable = true;
            videoPlayGroupControls_PTZAndTalk1.videoPlaySet.VideoRecordFilePath = Application.StartupPath + "\\TestVideo\\";
            videoPlayGroupControls_PTZAndTalk1.videoPlaySet.VideoRecordFilePath_Server = "\\0712\\" + DateTime.Now.ToString("yyyyMMddHHmmss");
            //videoPlayGroupControls_PTZAndTalk1.SetPTZVisible(false);

            videoPlayGroupControls_PTZAndTalk1.Init_VideoInfoSet(dicVideoInfos);
            videoPlayGroupControls_PTZAndTalk1.StartTalkingEvent += VideoPlayGroupControls_PTZAndTalk1_StartTalkingEvent;
            videoPlayGroupControls_PTZAndTalk1.VideoPlay("", 1);
            videoPlayGroupControls_PTZAndTalk1.VideoPlayCallbackEvent += VideoPlayGroupControls_PTZAndTalk1_VideoPlayCallbackEvent;
            videoPlayGroupControls_PTZAndTalk1.CurrentTalkSetting.TalkRecordEnable = true;
            videoPlayGroupControls_PTZAndTalk1.CurrentTalkSetting.TalkRecordPath_Server = "Audio/0712/" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private bool VideoPlayGroupControls_PTZAndTalk1_StartTalkingEvent(object sender, object StartTalkBeginValue)
        {
            bool bolResult = false;
            IVideoTalk iv = (IVideoTalk)sender;
            //MessageBox.Show(iv.CurrentTalkChannel.VideoTalkChannelName + "开始对讲");
            //MessageBox.Show(iv.CurrentTalkChannel.VideoTalkChannelName + "发送命令");
            return bolResult;
        }

        private bool VideoPlayGroupControls_PTZAndTalk1_VideoPlayCallbackEvent(object sender, VideoPlayControl.VideoBasicClass.VideoPlayCallbackValue evValue)
        {
            bool bolResult = false;
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:sss") + evValue.evType.ToString());
            if (evValue.evType == Enum_VideoPlayEventType.VideoPlay)
            {
                Console.WriteLine("发送录像命令");
            }
            return bolResult;
        }

        #region 测试数据
        public void SetTestData_ZWVideoAndSKTalk()
        {
            Dictionary<string, VideoInfo> dicVideoInfos = new Dictionary<string, VideoInfo>();
            VideoInfo videoInfo = new VideoInfo();
            CameraInfo camerasInfo = new CameraInfo();
            videoInfo.VideoType = Enum_VideoType.CloundSee;
            videoInfo.DVSNumber = "000101";
            videoInfo.DVSName = "ZW视频";
            videoInfo.DVSAddress = "X5014851";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "JHESSY";
            videoInfo.PreviewPwd = "";
            videoInfo.DVSType = "SK8501ZW";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 8;
            camerasInfo = new CameraInfo();
            for (int i = 1; i < videoInfo.DVSChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;


            videoInfo = new VideoInfo();
            videoInfo.VideoType = Enum_VideoType.SKVideo;
            videoInfo.DVSNumber = "000102";
            videoInfo.DVSName = "SK519V";
            videoInfo.DVSType = "SK519V";
            //videoInfo.DVSAddress = "61-B5513D572279-4E54";
            //videoInfo.DVSAddress = "61-3E477829FE12-4EF4";
            videoInfo.DVSAddress = "71-00F51F012D0C-2830";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "12345";
            videoInfo.PreviewPwd = "";
            //videoInfo.IntercomEnable = true;
            //videoInfo.OnlyIntercom = false;
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 16;
            camerasInfo = new CameraInfo();
            for (int i = 0; i < videoInfo.DVSChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;

            videoInfo = new VideoInfo();
            videoInfo.VideoType = Enum_VideoType.SKVideo;
            videoInfo.DVSNumber = "000103";
            videoInfo.DVSName = "SK8604";
            videoInfo.DVSType = "SK8604";
            videoInfo.DVSAddress = "61-573539920B39-3036";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "12345";
            videoInfo.PreviewPwd = "";
            //videoInfo.IntercomEnable = true;
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 16;
            camerasInfo = new CameraInfo();
            for (int i = 0; i < videoInfo.DVSChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;

            videoPlayGroupControls_PTZAndTalk1.bolPreViewPwdVerify = false;
            videoPlayGroupControls_PTZAndTalk1.PreViewPwdVerifyEvent += PreViewPwdVerify;
            videoPlayGroupControls_PTZAndTalk1.Init_VideoInfoSet(dicVideoInfos);
        }

        public void HuaMaiVideo_TestData()
        {
            Dictionary<string, VideoInfo> dicVideoInfos = new Dictionary<string, VideoInfo>();
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.HuaMaiVideo;
            v.DVSAddress = "E322213C04245";
            v.DVSChannelNum = 4;
            v.DVSConnectPort = 81;
            v.DVSName = "华迈云测试";
            v.DVSNumber = "000501";
            v.DVSType = "SK8605HM";
            v.HostID = "0005";
            v.UserName = "admin";
            v.Password = "sk123456";
            v.NetworkState = 0;
            for (int i = 0; i < 4; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSAddress = "E322213C04245";
                c.DVSType = "SK8605HM";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            dicVideoInfos[v.DVSNumber] = v;
            videoPlayGroupControls_PTZAndTalk1.bolPreViewPwdVerify = false;
            videoPlayGroupControls_PTZAndTalk1.PreViewPwdVerifyEvent += PreViewPwdVerify;
            videoPlayGroupControls_PTZAndTalk1.Init_VideoInfoSet(dicVideoInfos);
        }
        
        #endregion

        public bool PreViewPwdVerify(object sender, string strVideoID)
        {
            VideoPlayGroupControls_PTZAndTalk v = (VideoPlayGroupControls_PTZAndTalk)sender;
            if (v.dicCurrentVideoInfos[strVideoID].PreviewPwd == "123456")
            {
                return true;
            }
            return false;
        }

        private void Frm_VideoPlayGroupControls_PTZAndTalk_Move(object sender, EventArgs e)
        {
            //videoPlayGroupControls_PTZAndTalk1.ControlMove();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoPlayGroupControls_PTZAndTalk1.StartTalkingEvent += VideoPlayGroupControls_PTZAndTalk1_StartTalkingEvent1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            videoPlayGroupControls_PTZAndTalk1.StartTalkingEvent -= VideoPlayGroupControls_PTZAndTalk1_StartTalkingEvent1;
        }

        private bool VideoPlayGroupControls_PTZAndTalk1_StartTalkingEvent1(object sneder, object StartTalkBeginValue)
        {
            bool bolResult = false;
            IVideoTalk iv = (IVideoTalk)sneder;
            //MessageBox.Show(iv.CurrentTalkChannel.VideoTalkChannelName + "开始对讲");
            //MessageBox.Show(iv.CurrentTalkChannel.VideoTalkChannelName + "录音1 ");
            return bolResult;
        }

        private void Frm_VideoPlayGroupControls_PTZAndTalk_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoPlayGroupControls_PTZAndTalk1.ControlClose();
            SDKState.Ezviz_SDKRelease();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SDKState.Ezviz_SDKRelease();
        }
    }
}
