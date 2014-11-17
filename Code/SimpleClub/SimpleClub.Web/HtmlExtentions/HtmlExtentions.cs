using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleClub.Web {
    public static class HtmlExtentions {
        public static string Element(this HtmlHelper helper, string tagName, string className) {
            var tagBuilder = new TagBuilder(tagName);
            tagBuilder.AddCssClass(className);
            return tagBuilder.ToString();
        }
        public static string Paragraph(this HtmlHelper helper, string className, string content) {
            var tagBuilder = new TagBuilder("p");
            tagBuilder.AddCssClass(className);
            tagBuilder.InnerHtml += content;
            return tagBuilder.ToString();
        }
        public static string Image(this HtmlHelper helper, string alt, string src, string className) {
            var urlHelper = new UrlHelper(helper.ViewContext.RequestContext);

            var tagBuilder = new TagBuilder("img");
            tagBuilder.AddCssClass(className);
            tagBuilder.MergeAttribute("alt", alt);
            tagBuilder.MergeAttribute("src", urlHelper.Content(src));
            return tagBuilder.ToString();
        }

        public static MvcHtmlString ReviewItem(this HtmlHelper helper, ReviewDetails details) {
            var mainContainerTagBuilder = new TagBuilder("div");
            mainContainerTagBuilder.AddCssClass("item");

            var photoDivTagBuilder = new TagBuilder("div");
            photoDivTagBuilder.AddCssClass("picture");
            string photoTag = Image(helper, "people", details.UserPhotoUrl, "");
            photoDivTagBuilder.InnerHtml += photoTag;
            mainContainerTagBuilder.InnerHtml += photoDivTagBuilder.ToString();

            var descriptionTagBuilder = new TagBuilder("div");
            descriptionTagBuilder.AddCssClass("description");
            descriptionTagBuilder.InnerHtml += Paragraph(helper, "user-details", details.UserDetails);
            details.UserRecal.ToList().ForEach(s => descriptionTagBuilder.InnerHtml += Paragraph(helper, "user-recall", s));
            mainContainerTagBuilder.InnerHtml += descriptionTagBuilder.ToString();

            var placeTagBuilder = new TagBuilder("div");
            placeTagBuilder.AddCssClass("place");
            var linkTagBuilder = new TagBuilder("a");
            string linkUrl = SiteMapUtils.GetUrl(helper, details.SiteSection);
            linkTagBuilder.MergeAttribute("href", linkUrl);
            var textTagBuilder = new TagBuilder("span");

            string text = details.SiteSection.GetAttributeOfType<DescriptionAttribute>().Description;
            textTagBuilder.SetInnerText(text);
            linkTagBuilder.InnerHtml += textTagBuilder.ToString();
            placeTagBuilder.InnerHtml += linkTagBuilder.ToString();
            mainContainerTagBuilder.InnerHtml += placeTagBuilder.ToString();

            var clearTagBuilder = new TagBuilder("div");
            clearTagBuilder.AddCssClass("clear");
            mainContainerTagBuilder.InnerHtml += clearTagBuilder.ToString();
            
            return new MvcHtmlString(mainContainerTagBuilder.ToString());
        }
    }
}