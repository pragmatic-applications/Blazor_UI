using Interfaces;

using PageFeatures;

namespace BlazorUI.Views
{
    public partial class PageFeature : CoreComponent
    {
        public PagerData PagerDataValue { get; set; }
        public ISelect SelectParameterValue { get; set; }

        protected override void OnParametersSet()
        {
            this.PagerDataValue = this.PagerDataParameter;
            this.SelectParameterValue = this.SelectParameter;

            this.SpreadValue = this.SpreadParameter;
        }
    }
}
