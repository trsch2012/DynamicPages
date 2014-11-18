namespace DynamicPages.Code.Widgets
{
    public class FullWidthSection: IWidget
    {
        public string View
        {
            get
            {
                return IsEditMode?"~/Views/Widgets/FullWidthWidgetEdit.cshtml":"~/Views/Widgets/FullWidthWidget.cshtml";
            }
        }

        public object Model { get; set; }

        public WidgetType Type
        {
            get
            {
                return WidgetType.FullWidthWidget;
            }
        }


        public bool IsEditMode { get; set; }
    }
}