using Microsoft.AspNetCore.Components;

namespace BlazorUI
{
    public class UIEntityBase : ComponentBase
    {
        [Parameter] public bool IsCrudParameter { get; set; } = false;

        public string GridCssClass => this.IsCrudParameter ? "grid_col_repeat_4_1fr" : "grid_col_repeat_3_1fr";

        public string UrlDetail { get; set; }
        public string UrlEdit { get; set; }
        public string UrlDelete { get; set; }
    }
}
