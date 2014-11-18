using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicPages.Code
{
    public interface IPage
    {
        IList<KeyValuePair<string, IWidget>> PageWidgets { get; set; }
        string View { get; set; }
    }
}