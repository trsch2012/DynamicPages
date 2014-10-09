using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

using WebGrease.Extensions;

namespace DynamicPages.Code.Extensions
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString RenderZone(this HtmlHelper htmlHelper, string zoneId)
        {
            try
            {
                var page = (htmlHelper.ViewData.Model as IPage);
                var pageSections = page.PageSections;
                var renderedWidgets = string.Empty;
                foreach (var pageSection in pageSections.Where(x=>x.Key.Equals(zoneId, StringComparison.OrdinalIgnoreCase)))
                {
                    renderedWidgets += htmlHelper.Partial(pageSection.Value.View, pageSection.Value.Model, htmlHelper.ViewData);
                }

                return MvcHtmlString.Create(renderedWidgets);
            }
            catch (Exception ex)
            {
                return MvcHtmlString.Create(ex.Message);
            }
        }
    }
}