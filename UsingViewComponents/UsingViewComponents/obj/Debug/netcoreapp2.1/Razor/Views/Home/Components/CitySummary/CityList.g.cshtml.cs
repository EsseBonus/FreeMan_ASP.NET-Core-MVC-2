#pragma checksum "C:\Users\User\Desktop\Ololo_Asp.Net\UsingViewComponents\UsingViewComponents\Views\Home\Components\CitySummary\CityList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2be7bdf24d7be8418f348e26760a14d4b638582"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_CitySummary_CityList), @"mvc.1.0.view", @"/Views/Home/Components/CitySummary/CityList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Components/CitySummary/CityList.cshtml", typeof(AspNetCore.Views_Home_Components_CitySummary_CityList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2be7bdf24d7be8418f348e26760a14d4b638582", @"/Views/Home/Components/CitySummary/CityList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_CitySummary_CityList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UsingViewComponents.Models.City>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 49, true);
            WriteLiteral("\r\n<table class=\"table table-sm table-bordered\">\r\n");
            EndContext();
#line 4 "C:\Users\User\Desktop\Ololo_Asp.Net\UsingViewComponents\UsingViewComponents\Views\Home\Components\CitySummary\CityList.cshtml"
     foreach (var city in Model)
    {

#line default
#line hidden
            BeginContext(143, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(174, 9, false);
#line 7 "C:\Users\User\Desktop\Ololo_Asp.Net\UsingViewComponents\UsingViewComponents\Views\Home\Components\CitySummary\CityList.cshtml"
           Write(city.Name);

#line default
#line hidden
            EndContext();
            BeginContext(183, 60, true);
            WriteLiteral("</td>\r\n            <td class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(244, 33, false);
#line 9 "C:\Users\User\Desktop\Ololo_Asp.Net\UsingViewComponents\UsingViewComponents\Views\Home\Components\CitySummary\CityList.cshtml"
           Write(city.Population.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(277, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 12 "C:\Users\User\Desktop\Ololo_Asp.Net\UsingViewComponents\UsingViewComponents\Views\Home\Components\CitySummary\CityList.cshtml"
    }

#line default
#line hidden
            BeginContext(320, 80, true);
            WriteLiteral("    <tr>\r\n        <th>Total:</th>\r\n        <td class=\"text-right\">\r\n            ");
            EndContext();
            BeginContext(401, 46, false);
#line 16 "C:\Users\User\Desktop\Ololo_Asp.Net\UsingViewComponents\UsingViewComponents\Views\Home\Components\CitySummary\CityList.cshtml"
       Write(Model.Sum(p => p.Population).ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(447, 36, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UsingViewComponents.Models.City>> Html { get; private set; }
    }
}
#pragma warning restore 1591
