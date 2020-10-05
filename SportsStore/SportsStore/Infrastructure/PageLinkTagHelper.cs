using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SportsStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;

        public PageLinkTagHelper(IUrlHelperFactory helperFactory) =>
            urlHelperFactory = helperFactory;

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public PagingInfo PageModel { get; set; }

        //<div page-model="@Model.PagingInfo" page-action="List"></div>
        public string PageAction { get; set; }


        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> PageUrlValues { get; set; }
            = new Dictionary<string, object>();


        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            TagBuilder div = new TagBuilder("div");

            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder a = new TagBuilder("a");

                PageUrlValues["productPage"] = i;

                a.Attributes["href"] = 
                    urlHelper.Action(PageAction, PageUrlValues);

                if (PageClassesEnabled)
                {
                    a.AddCssClass(PageClass);

                    a.AddCssClass(i == PageModel.CurrentPage
                        ? PageClassSelected 
                        : PageClassNormal);
                }

                a.InnerHtml.Append(i.ToString());
                div.InnerHtml.AppendHtml(a);
            }

            output.Content.AppendHtml(div.InnerHtml);
        }
    }
}
