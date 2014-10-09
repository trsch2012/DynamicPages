using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicPages.Code
{
    public class Page: IPage
    {
        public Page()
        {
            MetaData = new List<IMetaData>();
            PageSections = new List<KeyValuePair<string, IPageSection>>();
        }

        public string Title { get; set; }
        public ICollection<IMetaData> MetaData { get; set; }
        public IList<KeyValuePair<string, IPageSection>> PageSections { get; set; }
        public string View { get; set; }
    }
}