#pragma checksum "C:\Users\User\Desktop\Ololo_Asp.Net\MvcModels\MvcModels\Views\Home\Names.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "376c0fcd49ed771655da32d54b9ec6f0355a5337"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Names), @"mvc.1.0.view", @"/Views/Home/Names.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Names.cshtml", typeof(AspNetCore.Views_Home_Names))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"376c0fcd49ed771655da32d54b9ec6f0355a5337", @"/Views/Home/Names.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Names : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<string>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Names", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\Ololo_Asp.Net\MvcModels\MvcModels\Views\Home\Names.cshtml"
  
    ViewBag.Title = "Names";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(105, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\User\Desktop\Ololo_Asp.Net\MvcModels\MvcModels\Views\Home\Names.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(163, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(167, 360, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fc1bc77712543c4bd90e90d410f6a4a", async() => {
                BeginContext(206, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 12 "C:\Users\User\Desktop\Ololo_Asp.Net\MvcModels\MvcModels\Views\Home\Names.cshtml"
         for (int i = 0; i < 3; i++)
        {

#line default
#line hidden
                BeginContext(257, 66, true);
                WriteLiteral("            <div class=\"form-group\">\r\n                <label>Name ");
                EndContext();
                BeginContext(325, 5, false);
#line 15 "C:\Users\User\Desktop\Ololo_Asp.Net\MvcModels\MvcModels\Views\Home\Names.cshtml"
                        Write(i + 1);

#line default
#line hidden
                EndContext();
                BeginContext(331, 103, true);
                WriteLiteral(":</label>\r\n                <input id=\"names\" name=\"names\" class=\"form-control\" />\r\n            </div>\r\n");
                EndContext();
#line 18 "C:\Users\User\Desktop\Ololo_Asp.Net\MvcModels\MvcModels\Views\Home\Names.cshtml"
        }

#line default
#line hidden
                BeginContext(445, 75, true);
                WriteLiteral("        <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(527, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "C:\Users\User\Desktop\Ololo_Asp.Net\MvcModels\MvcModels\Views\Home\Names.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(541, 65, true);
            WriteLiteral("    <table class=\"table table-sm table-bordered table-striped\">\r\n");
            EndContext();
#line 25 "C:\Users\User\Desktop\Ololo_Asp.Net\MvcModels\MvcModels\Views\Home\Names.cshtml"
         foreach (string name in Model)
        {

#line default
#line hidden
            BeginContext(658, 34, true);
            WriteLiteral("            <tr><th>Name:</th><td>");
            EndContext();
            BeginContext(693, 4, false);
#line 27 "C:\Users\User\Desktop\Ololo_Asp.Net\MvcModels\MvcModels\Views\Home\Names.cshtml"
                             Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(697, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 28 "C:\Users\User\Desktop\Ololo_Asp.Net\MvcModels\MvcModels\Views\Home\Names.cshtml"
        }

#line default
#line hidden
            BeginContext(720, 20, true);
            WriteLiteral("\r\n    </table>\r\n    ");
            EndContext();
            BeginContext(740, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a370214bfeb645cf9cc9f2defcb14078", async() => {
                BeginContext(786, 4, true);
                WriteLiteral("Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(794, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\Users\User\Desktop\Ololo_Asp.Net\MvcModels\MvcModels\Views\Home\Names.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
