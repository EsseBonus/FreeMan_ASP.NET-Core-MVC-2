#pragma checksum "C:\Users\User\Desktop\Ololo_Asp.Net\UsingViewComponents\UsingViewComponents\Views\Shared\Components\PageSize\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44b2c64151d844584fd7ca118416f937537a2a3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PageSize_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PageSize/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/PageSize/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_PageSize_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44b2c64151d844584fd7ca118416f937537a2a3e", @"/Views/Shared/Components/PageSize/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PageSize_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<long>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 53, true);
            WriteLiteral("\r\n<div class=\"m-1 p-1 bg-info text-white\">Page size: ");
            EndContext();
            BeginContext(67, 5, false);
#line 3 "C:\Users\User\Desktop\Ololo_Asp.Net\UsingViewComponents\UsingViewComponents\Views\Shared\Components\PageSize\Default.cshtml"
                                              Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(72, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<long> Html { get; private set; }
    }
}
#pragma warning restore 1591
