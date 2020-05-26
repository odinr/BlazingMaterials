#pragma checksum "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcDrawer/MwcDrawer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24da7b72617d9ba013f68311675b9d6589b9c0ab"
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
    public partial class MwcDrawer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "mwc-drawer");
            __builder.AddAttribute(1, "hasHeader", 
#nullable restore
#line 3 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcDrawer/MwcDrawer.razor"
                                   ShowHeader

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "type", 
#nullable restore
#line 3 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcDrawer/MwcDrawer.razor"
                                                      DrawerType

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "open", 
#nullable restore
#line 3 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcDrawer/MwcDrawer.razor"
                                                                         State.Open

#line default
#line hidden
#nullable disable
            );
            __builder.AddElementReferenceCapture(4, (__value) => {
#nullable restore
#line 3 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcDrawer/MwcDrawer.razor"
                  Ref = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "span");
            __builder.AddAttribute(7, "slot", "title");
            __builder.AddContent(8, 
#nullable restore
#line 4 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcDrawer/MwcDrawer.razor"
                        Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "span");
            __builder.AddAttribute(11, "slot", "subtitle");
            __builder.AddContent(12, 
#nullable restore
#line 5 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcDrawer/MwcDrawer.razor"
                           SubTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __Blazor.BlazingMaterials.Components.MwcDrawer.TypeInference.CreateCascadingValue_0(__builder, 14, 15, 
#nullable restore
#line 6 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcDrawer/MwcDrawer.razor"
                            Manager

#line default
#line hidden
#nullable disable
            , 16, (__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.AddContent(18, 
#nullable restore
#line 7 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcDrawer/MwcDrawer.razor"
         NavLinks

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "slot", "appContent");
                __builder2.AddContent(22, 
#nullable restore
#line 8 "/Users/odin.rochmann/Home Projects/BlazingMaterials/BlazingMaterials/Components/MwcDrawer/MwcDrawer.razor"
                                ChildContent

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
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
namespace __Blazor.BlazingMaterials.Components.MwcDrawer
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
