using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazingMaterials.Components
{
    public abstract class BlazingModuleAdapter : BlazingInteroptAdapter
    {
        private static string Module = "BlazingMaterials";
        public readonly ElementReference? Element;

        public BlazingModuleAdapter(IJSRuntime runtime, ElementReference? _element) : base(runtime)
        {
            Element = _element;
        }

        public abstract string Package { get; }

        public override Task<T> JsInvokeAsync<T>(String func, ElementReference? element, params object[] args)
        {
            return base.JsInvokeAsync<T>($"{Module}.{Package}.{func}", element, args);
        }

        public Task Connect(params object[] args)
        {
            return this.JsInvokeAsync<object>("connect", Element, args);
        }
    }
}