using System.Collections.Generic;

namespace DynamicPages.Code.Pages
{
    public class HomePage: IPage
    {
        public HomePage()
        {
            PageWidgets = new List<KeyValuePair<string, IWidget>>();
        }

        public IList<KeyValuePair<string, IWidget>> PageWidgets { get; set; }
        public string View { get; set; }
    }
}