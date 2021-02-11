using System.Collections.Generic;
using System;
namespace Vns.Core.Commons
{
    public static class ErrorConstant 
    {
        private static Dictionary<MessageCode, string> keysError = new Dictionary<MessageCode, string>()
        {
            { MessageCode.Exception, "Error: {0}"},
            { MessageCode.NullPointer, "Null Pointer"},
            { MessageCode.BE0001, "Đã có lỗi xảy ra !!! {0}" },
            { MessageCode.BE0002, "Không tìm thấy bài viết với mã {0}"}
        };

        public static string Get(MessageCode errorCode)
        {
            return keysError[errorCode];
        }

        public static string GetMessageWithData (MessageCode errorCode, string value)
        {
            string messageTemplate = keysError[errorCode];
            string message = string.Format(messageTemplate, value);
            return message;
        }

    }

    public enum MessageCode
    {
        Exception,
        NullPointer,
        BE0001,
        BE0002,
    }
}