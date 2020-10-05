#pragma checksum "C:\Users\User\Desktop\Ololo_Asp.Net\Users\Users\Views\Claims\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c748f7c649be1981397f5e0202165ff0fc696ebb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Claims_Index), @"mvc.1.0.view", @"/Views/Claims/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Claims/Index.cshtml", typeof(AspNetCore.Views_Claims_Index))]
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
#line 3 "C:\Users\User\Desktop\Ololo_Asp.Net\Users\Users\Views\_ViewImports.cshtml"
using Users.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c748f7c649be1981397f5e0202165ff0fc696ebb", @"/Views/Claims/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c5c97083b4a4c73d67119dfc1568565b0750fb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Claims_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<System.Security.Claims.Claim>>
    {
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
        private global::Users.Infrastructure.ClaimTypeTagHelper __Users_Infrastructure_ClaimTypeTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 236, true);
            WriteLiteral("\r\n<div class=\"bg-primary m-1 p-1 text-white\"><h4>Claims</h4></div>\r\n<table class=\"table table-sm table-bordered\">\r\n    <tr>\r\n        <th>Subject</th>\r\n        <th>Issuer</th>\r\n        <th>Type</th>\r\n        <th>Value</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 12 "C:\Users\User\Desktop\Ololo_Asp.Net\Users\Users\Views\Claims\Index.cshtml"
     if (Model == null || Model.Count() == 0)
    {

#line default
#line hidden
            BeginContext(340, 69, true);
            WriteLiteral("        <tr><td colspan=\"4\" class=\"text-center\">No Claims</td></tr>\r\n");
            EndContext();
#line 15 "C:\Users\User\Desktop\Ololo_Asp.Net\Users\Users\Views\Claims\Index.cshtml"
    }
    else
    {
        

#line default
#line hidden
#line 18 "C:\Users\User\Desktop\Ololo_Asp.Net\Users\Users\Views\Claims\Index.cshtml"
         foreach (System.Security.Claims.Claim claim in Model.OrderBy(x => x.Type))
        {

#line default
#line hidden
            BeginContext(529, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(568, 18, false);
#line 21 "C:\Users\User\Desktop\Ololo_Asp.Net\Users\Users\Views\Claims\Index.cshtml"
               Write(claim.Subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(586, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(614, 12, false);
#line 22 "C:\Users\User\Desktop\Ololo_Asp.Net\Users\Users\Views\Claims\Index.cshtml"
               Write(claim.Issuer);

#line default
#line hidden
            EndContext();
            BeginContext(626, 23, true);
            WriteLiteral("</td>\r\n                ");
            EndContext();
            BeginContext(649, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5eceec2fdeac49db98ba7b6a08edca65", async() => {
            }
            );
            __Users_Infrastructure_ClaimTypeTagHelper = CreateTagHelper<global::Users.Infrastructure.ClaimTypeTagHelper>();
            __tagHelperExecutionContext.Add(__Users_Infrastructure_ClaimTypeTagHelper);
            BeginWriteTagHelperAttribute();
#line 23 "C:\Users\User\Desktop\Ololo_Asp.Net\Users\Users\Views\Claims\Index.cshtml"
                             WriteLiteral(claim.Type);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Users_Infrastructure_ClaimTypeTagHelper.ClaimType = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("identity-claim-type", __Users_Infrastructure_ClaimTypeTagHelper.ClaimType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(692, 22, true);
            WriteLiteral("\r\n                <td>");
            EndContext();
            BeginContext(715, 11, false);
#line 24 "C:\Users\User\Desktop\Ololo_Asp.Net\Users\Users\Views\Claims\Index.cshtml"
               Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(726, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "C:\Users\User\Desktop\Ololo_Asp.Net\Users\Users\Views\Claims\Index.cshtml"
        }

#line default
#line hidden
#line 26 "C:\Users\User\Desktop\Ololo_Asp.Net\Users\Users\Views\Claims\Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(770, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<System.Security.Claims.Claim>> Html { get; private set; }
    }
}
#pragma warning restore 1591
