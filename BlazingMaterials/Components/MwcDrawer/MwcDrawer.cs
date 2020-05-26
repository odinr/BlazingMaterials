using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazingMaterials.Components
{
    partial class MwcDrawer : ComponentBase
    {
        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        public ElementReference Ref { get; protected set; }

        protected MwcDrawerAdapter Adapter;
        protected MwcDrawerState State;
        protected MwcDrawerState.Manager Manager;

        public MwcDrawer()
        {
            State = new MwcDrawerState();
            Manager = new MwcDrawerState.Manager(State);
            Manager.OnStateChanged += StateHasChanged;
        }

        protected async override Task OnAfterRenderAsync(Boolean first)
        {
            await base.OnAfterRenderAsync(first);
            if (first)
            {
                Adapter = new MwcDrawerAdapter(JSRuntime, Ref);
                await Adapter.Connect(Ref);
                Adapter.OnOpenChanged += open => Manager.Open = open;
            }
        }
    }
}