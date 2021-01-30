using System;
namespace Vns.Infrastructure.ModelView
{
    public class BaseResponse
    {
        public bool Status { get; set; }
        public eMessageCode Code { get; set; }
        public string Message { get; set; }
    }
}
