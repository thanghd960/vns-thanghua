using System;
using Microsoft.AspNetCore.Http;

namespace Vns.Core.Commons.WebHelper
{
    public partial class WebHelper : IWebHelper
    {
        private readonly HttpContext _httpContext;

        public WebHelper (HttpContext httpContext)
        {
            _httpContext = httpContext;
        }

        public bool IsRequestBeingRedirected => throw new NotImplementedException();

        public bool IsPostBeingDone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetCurrentIpAddress()
        {
            return _httpContext.Request.HttpContext.Connection.RemoteIpAddress.ToString();
        }

        public string GetStoreHost(bool useSsl)
        {
            throw new NotImplementedException();
        }

        public string GetStoreLocation()
        {
            throw new NotImplementedException();
        }

        public string GetStoreLocation(bool useSsl)
        {
            throw new NotImplementedException();
        }

        public string GetUrlReferrer()
        {
            throw new NotImplementedException();
        }

        public bool IsCurrentConnectionSecured()
        {
            throw new NotImplementedException();
        }

        public bool IsStaticResource(HttpRequest request)
        {
            throw new NotImplementedException();
        }

        public string MapPath(string path)
        {
            throw new NotImplementedException();
        }

        public string ModifyQueryString(string url, string queryStringModification, string anchor)
        {
            throw new NotImplementedException();
        }

        public T QueryString<T>(string name)
        {
            throw new NotImplementedException();
        }

        public string RemoveQueryString(string url, string queryString)
        {
            throw new NotImplementedException();
        }

        public string ServerVariables(string name)
        {
            throw new NotImplementedException();
        }
    }
}
