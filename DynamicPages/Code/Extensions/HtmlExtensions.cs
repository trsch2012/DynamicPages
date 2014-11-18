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
                if (page != null)
                {
                    bool isEdit = htmlHelper.ViewBag.IsEdit != null && htmlHelper.ViewBag.IsEdit;
                    var pageWidgets = page.PageWidgets;
                    if (pageWidgets != null && pageWidgets.Any())
                    {
                        var renderedWidgets = string.Empty;
                        foreach (
                                var pageWidget in
                                        pageWidgets.Where(x => x.Key.Equals(zoneId, StringComparison.OrdinalIgnoreCase))
                                )
                        {
                            pageWidget.Value.IsEditMode = isEdit;
                            renderedWidgets += htmlHelper.Partial(
                                    pageWidget.Value.View,
                                    pageWidget.Value.Model,
                                    htmlHelper.ViewData);
                        }
                        var html = MvcHtmlString.Create(renderedWidgets);
                        if (isEdit)
                        {
                            html = htmlHelper.Partial(Zone.View, new Zone { Content = html, Name = zoneId });
                        }

                        return html;
                    }
                }

            }
            catch (Exception ex)
            {
                return MvcHtmlString.Create(ex.Message);
            }

            return MvcHtmlString.Create(string.Empty);
        }
    }
}