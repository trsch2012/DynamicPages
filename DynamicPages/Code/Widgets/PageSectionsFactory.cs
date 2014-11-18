using System;

namespace DynamicPages.Code.Widgets
{
    public class PageSectionsFactory
    {
        public static IWidget GetPageSection(WidgetType widgetType)
        {
            switch (widgetType)
            {
                case WidgetType.FullWidthWidget:
                    return new FullWidthSection();
                default:
                    throw new Exception("Page Section Not Found");
            }
        }
    }
}