using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfiguringApps.Infrastructure
{
    public class BrowserTypeMiddleware_or_RequestEditingMiddleware
    {
        private RequestDelegate nextDelegate;

        public BrowserTypeMiddleware_or_RequestEditingMiddleware(RequestDelegate next) =>
            nextDelegate = next;

        public async Task Invoke(HttpContext httpContext)
        {
            httpContext.Items["EdgeBrowser"] =
                httpContext.Request.Headers["User-Agent"].Any(v => v.ToLower().Contains("edge"));

            await nextDelegate.Invoke(httpContext);
        }
    }
}
