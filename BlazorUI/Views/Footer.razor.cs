using System.Collections.Generic;

using Microsoft.AspNetCore.Components;

using PageFeatures;

namespace BlazorUI.Views
{
    public partial class Footer
    {
        [Parameter] public List<PageLink> NavLinks { get; set; }

        [Parameter] public string BisName { get; set; }
    }
}
