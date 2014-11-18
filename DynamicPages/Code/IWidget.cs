using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DynamicPages.Code.Widgets;

namespace DynamicPages.Code
{
    public interface IWidget
    {
        string View { get; }
        object Model { get; set; }
        WidgetType Type { get; }
        bool IsEditMode { get; set; }
    }
}