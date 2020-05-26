using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazingMaterials.Components
{
    public abstract class BaseMwcCompomnent : ComponentBase, IDisposable
    {

        protected virtual Task OnFirstAfterRenderAsync()
        {
            return Task.CompletedTask;
        }

        private Queue<Func<Task>> afterRenderCallQuene = new Queue<Func<Task>>();

        protected void CallAfterRender(Func<Task> action)
        {
            afterRenderCallQuene.Enqueue(action);
        }


        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {
                await OnFirstAfterRenderAsync();
            }

            if (afterRenderCallQuene.Count > 0)
            {
                var actions = afterRenderCallQuene.ToArray();
                afterRenderCallQuene.Clear();

                foreach (var action in actions)
                {
                    if (Disposed)
                    {
                        return;
                    }

                    await action();
                }
            }
        }

        protected bool Disposed { get; private set; }
        public virtual void Dispose()
        {
            Disposed = true;
        }

        protected void InvokeStateHasChanged()
        {
            InvokeAsync(() =>
            {
                if (!Disposed)
                {
                    StateHasChanged();
                }
            });
        }

        // [Parameter]
        // public ForwardRef RefBack { get; set; }

        private ElementReference _ref;

        /// <summary>
        /// Returned ElementRef reference for DOM element.
        /// </summary>
        public virtual ElementReference Ref
        {
            get => _ref;
            set
            {
                _ref = value;
                // RefBack?.Set(value);
            }
        }


        [Inject]
        protected IJSRuntime Js { get; set; }
    }
}