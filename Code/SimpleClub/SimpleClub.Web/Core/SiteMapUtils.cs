using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleClub.Web {
    public static class SiteMapUtils {
        public static string GetUrl(this HtmlHelper helper, SiteSectonType siteSection) {
            string resultUrl = "";
            var urlHelper = new UrlHelper(helper.ViewContext.RequestContext);

            switch(siteSection) {
                case SiteSectonType.Club:
                    resultUrl = urlHelper.Action("Index", "Home");
                    break;
                case SiteSectonType.IndividualLessons:
                    resultUrl = urlHelper.Action("IndividualLessons", "Details");
                    break;
                case SiteSectonType.IndividualLessonsForChildren:
                    resultUrl = urlHelper.Action("IndividualLessonsForChildren", "Details");
                    break;
                case SiteSectonType.SkypeLessons:
                    resultUrl = urlHelper.Action("SkypeLessons", "Details");
                    break;
            }

            return resultUrl;
        }
    }
}