using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazingMaterials.Components
{
    public class BlazingInteroptAdapter : IDisposable
    {
        public readonly DotNetObjectReference<BlazingInteroptAdapter> Reference;
        protected readonly IJSRuntime Js;

        public BlazingInteroptAdapter(IJSRuntime runtime)
        {
            Js = runtime;
            Reference = DotNetObjectReference.Create(this);
        }

        #region Interopt
        public event Action<object[]> OnCallback;

        public virtual async Task<T> JsInvokeAsync<T>(String function, ElementReference? element, params object[] args)
        {
            return await Js.InvokeAsync<T>(function, Reference, element, args);
        }

        [JSInvokable]
        public void invokeDotNetCallback(params object[] args)
        {
            OnCallback?.Invoke(args);
        }
        #endregion

        #region IDisposable Support
        private bool Disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!Disposed)
            {
                if (disposing)
                {
                    Reference?.Dispose();
                }
                Disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}