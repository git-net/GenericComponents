using Microsoft.AspNetCore.Components;

namespace GenericComponentVS.Shared
{
    public abstract  class  Case1Base<TComp>: ComponentBase
    {
       [Parameter] public RenderFragment<TComp> ChildContent { get; set; }

     
    }
}
