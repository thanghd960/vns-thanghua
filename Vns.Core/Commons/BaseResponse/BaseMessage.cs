using System;
namespace Vns.Core.Commons.BaseResponse
{
    public class BaseMessage
    {
        public MessageCode Code { get; set; }
        public string Message { get; set; }

        public string GetMessage(MessageCode code, string str)
        {
            return str == null ? ErrorConstant.Get(code) : ErrorConstant.GetMessageWithData(code, str);
        }
    }


}
