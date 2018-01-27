﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/1/21 7:25:19 (UTC +8:00)
** desc： ...
*************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutumnBox.Basic.ACP
{
    /*ACP标准*/
    public static class ACP
    {
        public const ushort STD_PORT = 24020;
        public const double VERSION = 0.9;
        public const int TIMEOUT_VALUE = 5000;
       
        public const string ACP_ANDROID_PACKAGENAME = "top.atmb.autumnbox";
        //Commands
        public const String CMD_GETICON = "geticon";
        public const String CMD_GETPKGINFO = "getpkginfo";
        public const String CMD_TEST = "test";
        //Error Codes
        public const byte FCODE_SUCCESS = 0;
        public const byte FCODE_UNKNOW_ERR = 1;
        public const byte FCODE_ERR_WITH_EX = 2;
        public const byte FCODE_PKG_NOT_FOUND = 3;
        public const byte FCODE_UNKNOW_COMMAND = 4;
        public const byte FCODE_NO_RESPONSE = 5;
        public const byte FCODE_TIMEOUT = 6;
        public static void PrintLog(String TAG, String str)
        {
            Console.WriteLine(TAG + ":  " + str);
        }
    }
}
