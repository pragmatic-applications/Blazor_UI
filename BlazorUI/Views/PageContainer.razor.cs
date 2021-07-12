using System.Collections.Generic;

using Domain;

using Microsoft.AspNetCore.Components;

using PageFeatures;

namespace BlazorUI.Views
{
    public partial class PageContainer
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public List<PageLink> NavLinks { get; set; }

        [Inject] public NavigationJSI NavigationJSI { get; set; }
        [Parameter] public BrowserDimension BrowserDimensionParameter { get; set; }
        [Parameter] public bool IsJavaScriptReadyParameter { get; set; }
    }
}
