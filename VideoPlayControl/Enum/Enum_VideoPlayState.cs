﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayControl
{
    /// <summary>
    /// 当前视频状态
    /// </summary>
    public enum Enum_VideoPlayState
    {
        /// <summary>
        /// 视频信息尚未赋值
        /// </summary>
        VideoInfoNull=0,
        
        /// <summary>
        /// 视频信息赋值完成
        /// </summary>
        VideoInfoInit=1,
        
        /// <summary>
        /// 处于播放状态
        /// </summary>
        InPlayState=2,
        
        /// <summary>
        /// 连接中
        /// </summary>
        Connecting=3,
        
        /// <summary>
        /// 未处于播放状态
        /// </summary>
        NotInPlayState =-1
    }


    /// <summary>
    /// 视频回放状态
    /// </summary>
    public enum Enum_VideoPlaybackState
    {
        /// <summary>
        /// 空未赋值状态
        /// </summary>
        Null=0,

        /// <summary>
        /// 关闭
        /// </summary>
        Stopped=1,
        
        /// <summary>
        /// 暂停
        /// </summary>
        Paused=2,

        /// <summary>
        /// 回放中
        /// </summary>
        Playing = 3
    }
}
