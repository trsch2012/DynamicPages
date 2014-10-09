using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicPages.Code
{
    public interface IPageSection
    {
        string View { get; }
        object Model { get; set; }
    }
}