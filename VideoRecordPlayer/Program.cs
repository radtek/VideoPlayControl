﻿using Newtonsoft.Json;
using PublicClassCurrency;
using SKVideoRecordConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VideoRecordPlayer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //args = new string[] { @"G:\上班汇总\Working\维护项目\公用项目\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl_UseDemo\bin\Debug\AxisRecord\000601_00_20180127085739_06.bin" };
            //args = new string[] { @"D:\工作\雄迈\SDK\Demo\VideoPlayControl\VideoPlayControl\VideoPlayControl_UseDemo\bin\Debug\BlueSkyVideoRecFile\192.168.18.254\000201_01_20180423101542_09.bsr" };
            //args = new string[] { @"D:\工作\雄迈\SDK\Demo\VideoPlayControl\VideoPlayControl\VideoPlayControl_UseDemo\bin\Debug\BlueSkyVideoRecFile\192.168.18.254\000201_01_20180423101542_09.bsr" };
            //args = new string[] { @"C:\SHIKE_Video\4610\20180425114454\461001_01_20180425114504_09.bsr" };
            //args = new string[] { @"C:\SHIKE_Video\4610\000801_02_20180425152604_09.bsr" };
            //args = new string[] { @"C:\SHIKE_Video\0007\20180413211119\000701_00_20180413211141_06.bin" };
            Application.Run(StartFormCreator(args));
        }
        static Form StartFormCreator(string[] args)
        {
            if (args != null && args.Length >= 1)
            {
                string Temp_strValue = args[0];
                if (!string.IsNullOrEmpty(Temp_strValue))
                {
                    VideoRecordInfo v = VideoPlayControl.VideoRecordInfoConvert.GetVideoRecordInfo_ByFileName(Temp_strValue);
                    if (v.VideoRecordType == Enum_VIdeoRecordType.Axis)
                    {
                        return new FrmMain(v);
                    }
                    else
                    {
                        return new FrmVideoRecordBackplay(v);
                    }
                    
                }
            }
            return new FrmVideoRecordBackplay();
        }


        
    }
}
