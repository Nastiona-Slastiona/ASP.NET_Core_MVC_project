using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;

namespace WEB_953506_Kruglaya.TagHelpers
{
    public class PagerTagHelper: TagHelper
    {
        LinkGenerator _linkGenerator;
        public int PageCurrent { get; set; }
        public int PageTotal { get; set; }
        public string PagerClass { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; } 
        public int? CategoryId { get; set; }

        public PagerTagHelper(LinkGenerator linkGenerator)
        {
            _linkGenerator = linkGenerator;
        }
        public override void Process(TagHelperContext context,
        TagHelperOutput output)
        {
            output.TagName = "nav";
            output.TagMode = TagMode.StartTagAndEndTag;
            var ulTag = new TagBuilder("ul");
            ulTag.AddCssClass("pagination pagination-lg");
            ulTag.AddCssClass(PagerClass);
            

            var url = _linkGenerator.GetPathByAction(Action,
               Controller,
               new
               {
                   page = PageCurrent - 1,
                   categories = CategoryId == 0
                           ? null
                           : CategoryId
               });
            var item = GetPagerItem(
            url: url, text: "Previous",
            active: false,
            disabled: false
            );
            ulTag.InnerHtml.AppendHtml(item);

            for (int i = 1; i <= PageTotal; i++)
            {
                url =_linkGenerator.GetPathByAction(Action,
                Controller,
                new
                {
                    page = i,
                    categories = CategoryId == 0
                            ?null
                            : CategoryId
                });
                item = GetPagerItem(
                url: url, text: i.ToString(),
                active: i == PageCurrent,
                disabled: i == PageCurrent
                );
                ulTag.InnerHtml.AppendHtml(item);
            }
            url =   _linkGenerator.GetPathByAction(Action,
              Controller,
              new
              {
                  page = PageCurrent != PageTotal ? PageCurrent + 1 : PageTotal,
                  categories = CategoryId == 0
                          ? null
                          : CategoryId
              });
            url = PageCurrent != PageTotal ? url : "";
            item = GetPagerItem(
            url: url, text: "Next",
            active: false,
            disabled: false
            );
            ulTag.InnerHtml.AppendHtml(item);
            output.Content.AppendHtml(ulTag);
        }

        private TagBuilder GetPagerItem(string url, string text, bool active = false, bool disabled = false)
        {
            var liTag = new TagBuilder("li");
            liTag.AddCssClass("page-item");
            liTag.AddCssClass(active ? "active" : "");
            var aTag = new TagBuilder("a");
            aTag.AddCssClass("page-link");
            aTag.Attributes.Add("href",url);
            aTag.InnerHtml.Append(text);
            liTag.InnerHtml.AppendHtml(aTag);
            return liTag;
        }
    }

}

