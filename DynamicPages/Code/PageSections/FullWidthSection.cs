using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicPages.Code.PageSections
{
    public class FullWidthSection: IPageSection
    {
        public FullWidthSection()
        {
        }

        public string View { get { return "~/Views/PageSections/FullWidthSection.cshtml"; } } 

        public object Model { get; set; }
    }
}