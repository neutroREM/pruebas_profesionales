using Microsoft.JSInterop;

namespace certinom_sadper_v1.Helper
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask Inactividad<T>(this IJSRuntime js, IJSObjectReference modulo,
            DotNetObjectReference<T> dotNetObjectReference) where T : class
        {
            //IJSObjectReference? module = await js.InvokeAsync<IJSObjectReference>("import", "./Shared/MainLayout.razor.js");
            await modulo.InvokeVoidAsync("Inactividad", dotNetObjectReference);
        }
        public static async ValueTask AlertaConfirmacion<T>(this IJSRuntime js, IJSObjectReference modulo, string sAdminAccion,
            DotNetObjectReference<T> dotNetObjectReference) where T : class
        {
            await modulo.InvokeVoidAsync($"{sAdminAccion}MensajeConfirmacion", dotNetObjectReference);
        }


        public static void GuardarComo(this IJSRuntime js, string nombreArchivo, byte[] ayArchivo)
        {
            js.InvokeAsync<object>("saveAsFile",
                nombreArchivo,
                Convert.ToBase64String(ayArchivo));
        }

        public static void AbirDocumento(this IJSRuntime js, byte[] ayArchivo, string sMetodo)
        {
            js.InvokeAsync<object>(sMetodo, ayArchivo);
        }
    }
}
