using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicPages.Code
{
    public class Zone
    {
        public MvcHtmlString Content { get; set; }
        public string Name { get; set; }
        public static string View { get { return "~/Views/Shared/_EditContainer.cshtml"; } }
    }
}