#pragma checksum "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcButton/MwcButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3fa541cd4b8da68bff070484cf3d89728e4ad9e"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class MwcButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "mwc-button");
            __builder.AddAttribute(1, "icon", 
#nullable restore
#line 4 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcButton/MwcButton.razor"
          Icon

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "label", 
#nullable restore
#line 5 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcButton/MwcButton.razor"
           Label

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "raised", 
#nullable restore
#line 6 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcButton/MwcButton.razor"
            Raised

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "Unelevated", 
#nullable restore
#line 7 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcButton/MwcButton.razor"
                Unelevated

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "Outlined", 
#nullable restore
#line 8 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcButton/MwcButton.razor"
              Outlined

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "Dense", 
#nullable restore
#line 9 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcButton/MwcButton.razor"
           Dense

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "Disabled", 
#nullable restore
#line 10 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcButton/MwcButton.razor"
              Disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "trailingIcon", 
#nullable restore
#line 11 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcButton/MwcButton.razor"
                  TrailingIcon

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "slot", 
#nullable restore
#line 12 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcButton/MwcButton.razor"
          Slot

#line default
#line hidden
#nullable disable
            );
            __builder.AddMultipleAttributes(10, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 13 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcButton/MwcButton.razor"
                ElementAttributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcButton/MwcButton.razor"
             OnClickCallback

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "\n    ");
            __builder.AddContent(13, 
#nullable restore
#line 16 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcButton/MwcButton.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcButton/MwcButton.razor"
       
    [Parameter]
    public string Icon { get; set; }

    [Parameter]
    public string Label { get; set; }

    [Parameter]
    public bool Raised { get; set; }

    [Parameter]
    public bool Unelevated { get; set; }

    [Parameter]
    public bool Outlined { get; set; }

    [Parameter]
    public bool Dense { get; set; }

    [Parameter]
    public bool Disabled { get; set; }

    [Parameter]
    public bool TrailingIcon { get; set; }

    [Parameter]
    public string Slot { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> ElementAttributes { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnClickCallback { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
