#pragma checksum "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcAppBar/MwcAppBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "983f0b92c614e1dc95ea4802a341a62f3c71c89c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazingMaterials.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class MwcAppBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcAppBar/MwcAppBar.razor"
       
    [Parameter]
    public bool Fixed { get; set; }

    [Parameter]
    public string Title { get; set; } = "";

    [Parameter]
    public bool CenterTitle { get; set; }

    [Parameter]
    public bool Prominent { get; set; }

    [Parameter]
    public bool Dense { get; set; }

    [Parameter]
    public RenderFragment NavigationIcon { get; set; }

    [Parameter]
    public RenderFragment ButtonContent { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [CascadingParameter]
    protected MwcDrawerState.Manager DrawerState { get; set; }

    public void ToggleDrawer(MouseEventArgs e)
    {
        DrawerState.Open = !DrawerState.Open;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
