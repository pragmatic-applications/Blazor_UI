//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Microsoft.AspNetCore.Components;

//namespace BlazorUI.Views
//{
//    public partial class CheckboxList<TItem> : ComponentBase
//    {
//        [Parameter] public IEnumerable<TItem> Items { get; set; }
//        [Parameter] public List<TItem> SelectedItems { get; set; }
//        [Parameter] public RenderFragment<TItem> ItemFragment { get; set; }
//        [Parameter] public RenderFragment<TItem> ItemTemplate { get; set; }
//        [Parameter] public EventCallback<List<TItem>> SelectedItemsChanged { get; set; }

//        public void DoChange(TItem item)
//        {
//            if(this.SelectedItems.Contains(item))
//            {
//                this.SelectedItems.Remove(item);
//            }
//            else
//            {
//                this.SelectedItems.Add(item);
//            }

//            this.SelectedItemsChanged.InvokeAsync(this.SelectedItems);
//        }
//    }
//}
