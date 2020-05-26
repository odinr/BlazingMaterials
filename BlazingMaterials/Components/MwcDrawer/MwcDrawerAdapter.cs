using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazingMaterials.Components
{

    public partial class MwcDrawerAdapter : BlazingModuleAdapter
    {
        public override string Package => "MwcDrawer";
        public MwcDrawerAdapter(IJSRuntime _runtime, ElementReference _element) : base(_runtime, _element) { }

        public event Action<bool> OnOpenChanged;

        [JSInvokable]
        public void OpenStateHandler(bool open)
        {
            OnOpenChanged?.Invoke(open);
        }
    }
}