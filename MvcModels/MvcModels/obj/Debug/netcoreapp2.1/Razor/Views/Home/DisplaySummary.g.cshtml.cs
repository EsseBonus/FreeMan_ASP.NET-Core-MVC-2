#pragma checksum "C:\Users\User\Desktop\Ololo_Asp.Net\MvcModels\MvcModels\Views\Home\DisplaySummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9eb7b827c9ed31f9c7c3f7d135ef939e5e729d49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplaySummary), @"mvc.1.0.view", @"/Views/Home/DisplaySummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DisplaySummary.cshtml", typeof(AspNetCore.Views_Home_DisplaySummary))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eb7b827c9ed31f9c7c3f7d135ef939e5e729d49", @"/Views/Home/DisplaySummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplaySummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcModels.Models.AddressSummary>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\Ololo_Asp.Net\MvcModels\MvcModels\Views\Home\DisplaySummary.cshtml"
  
    ViewBag.Title = "DisplaySummary";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(111, 156, true);
            WriteLiteral("\r\n<div class=\"bg-primary m-1 p-1 text-white\"><h2>Address</h2></div>\r\n<table class=\"table table-sm table-bordered table-striped\">\r\n    <tr><th>City:</th><td>");
            EndContext();
            BeginContext(268, 10, false);
#line 9 "C:\Users\User\Desktop\Ololo_Asp.Net\MvcModels\MvcModels\Views\Home\DisplaySummary.cshtml"
                     Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(278, 41, true);
            WriteLiteral("</td></tr>\r\n    <tr><th>Country:</th><td>");
            EndContext();
            BeginContext(320, 13, false);
#line 10 "C:\Users\User\Desktop\Ololo_Asp.Net\MvcModels\MvcModels\Views\Home\DisplaySummary.cshtml"
                        Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(333, 20, true);
            WriteLiteral("</td></tr>\r\n</table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcModels.Models.AddressSummary> Html { get; private set; }
    }
}
#pragma warning restore 1591
