﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/1/22 1:50:56 (UTC +8:00)
** desc： ...
*************************************************/

namespace AutumnBox.Basic.ACP
{
    public struct ACPResponseData
    {
        public bool IsSuccessful
        {
            get
            {
                return FirstCode == ACP.FCODE_SUCCESS;
            }
        }
        public byte FirstCode { get; set; }
        public byte[] Data { get; set; }
    }
}
