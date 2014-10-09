using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicPages.Code
{
    public interface IMetaData 
    {
        string Value { get; set; }
        string Key { get; set; }
    }
}