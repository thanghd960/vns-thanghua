using System.Collections.Generic;
using System;
namespace Vns.Core.Commons
{
    public static class ErrorConstant 
    {
        private static Dictionary<eMessageCode, string> keys = new Dictionary<eMessageCode, string>()
        {
            { eMessageCode.ERROR_000001, "Đã có lỗi xảy ra !!!" },
            { eMessageCode.ERROR_000002, "Không tìm thấy bài viết với id {0}" },
            { eMessageCode.SUCCESS_000001, "Article {0} was approved"}
        };

        public static string Get(eMessageCode errorCode)
        {
            return keys[errorCode];
        }

        public static string GetMessageWithData (eMessageCode errorCode, string value)
        {
            string messageTemplate = keys[errorCode];
            String message = String.Format(messageTemplate, value);
            return message;
        }

    }

    public enum eMessageCode
    {
        ERROR_000001,
        ERROR_000002,
        SUCCESS_000001,
        SUCCESS_000002,
    }
}