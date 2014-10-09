using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicPages.Code.PageSections
{
    public class PageSectionsFactory
    {
        public static IPageSection GetPageSection(string pageSectionType)
        {
            switch (pageSectionType)
            {
                case "FullWidthSection":
                    return new FullWidthSection();
                default:
                    throw new Exception("Page Section Not Found");
            }
        }
    }
}