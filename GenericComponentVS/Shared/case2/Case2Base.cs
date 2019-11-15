using Microsoft.AspNetCore.Components;

namespace GenericComponentVS.Shared
{
    public abstract class Case2Base<TComp, TItem> : Case1Base<TComp> {
 
        [Parameter] public RenderFragment<(TComp Comp, TItem obj )> Template { get; set; } //Test.razor  line3 cause  compile fail cs0234  
        //[Parameter] public RenderFragment<Args<TComp,TItem>> Template { get; set; }// compile success , works.
    }

    public class Args<TComp, TItem>
    {
        public TComp Comp { get; set; }
        public TItem Item { get; set; }
    }
}
