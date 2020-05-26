#pragma checksum "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcDrawer/MwcDrawer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24da7b72617d9ba013f68311675b9d6589b9c0ab"
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
    public partial class MwcDrawer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcDrawer/MwcDrawer.razor"
       

    [Parameter]
    public MwcDrawerType Type { get; set; }

    [Parameter]
    public bool ShowHeader { get; set; } = true;

    [Parameter]
    public bool Open { get { return Manager.Open; } set { Manager.Open = value; } }

    [Parameter]
    public RenderFragment Title { get; set; }

    [Parameter]
    public RenderFragment SubTitle { get; set; }

    [Parameter]
    public RenderFragment NavLinks { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }


    protected string DrawerType
    {
        get { return Enum.GetName(typeof(MwcDrawerType), Type).ToLower(); }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
