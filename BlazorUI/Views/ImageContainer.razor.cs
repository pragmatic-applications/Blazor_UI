using System.Collections.Generic;

using Microsoft.AspNetCore.Components;

namespace BlazorUI.Views
{
    public partial class ImageContainer : ComponentBase
    {
        [Parameter] public string ImageParameter { get; set; }
        [Parameter] public string UrlApiImageParameter { get; set; }
        [Parameter] public string MaxWidthParameter { get; set; }

        [Parameter(CaptureUnmatchedValues = true)] public Dictionary<string, object> Attributes { get; set; }

        public string Url { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            this.Url = $"{this.UrlApiImageParameter}/{this.ImageParameter}";
        }
    }
}
