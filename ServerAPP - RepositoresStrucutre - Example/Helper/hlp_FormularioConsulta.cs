using certinom_sadper_v1.Data.Repositories.Interfaces;
using certinom_sadper_v1.Modelos.Settings;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components;

namespace certinom_sadper_v1.Helper
{
    public class hlp_FormularioConsulta
    {
        //Servicios
        //private readonly srv_HTTPClient _httpClient;
        private readonly IAuthService _authenticationService;
        private readonly NavigationManager _navigationManager;


        /// <summary>
        /// Definir el diccionario de rutas como una constante dentro de la clase
        /// </summary>
        private static readonly Dictionary<string, string> EntidadRutas = new()
        {
            { "NTimbradoCFDINomina", "/CertificarRecibos/TimbrarPeriodo/NTimbradoCFDINomina" },
            { "EnviarEmailCFDINominaTimbrados", "/CertificarRecibos/TimbrarPeriodo/EnviarEmailCFDINominaTimbrados"},
            { "CancelarCFDINominaTimbrados", "/CertificarRecibos/TimbrarPeriodo/CancelarCFDINominaTimbrados"},
            { "EnviarWebCFDINominaTimbrados", "/CertificarRecibos/TimbrarPeriodo/EnviarWebCFDINominaTimbrados"},
            { "CancelarMultiplesCFDINominaTimbrados", "/CertificarRecibos/TimbrarPeriodo/CancelarMultiplesCFDINominaTimbrados"}
        };

        /// <summary>
        /// Constructor 
        /// </summary>
        /// Historial de Cambios
        ///
        public hlp_FormularioConsulta(IAuthService authenticationService, NavigationManager Navegacion)
        {
            _authenticationService = authenticationService;
            _navigationManager = Navegacion;
        }



        /// <summary>
        /// abrirFormulario, abre los formularios correspondientes a filtros especificando el nombre
        /// </summary>
        /// <param name="sModulo">Nombre del módulo</param>
        /// <param name="sSubMod">Nombre del submódulo</param>
        /// <param name="sUri">uri de la página anterior</param>
        /// <param name="sEntidad">Entidad del formulario a consultar</param>
        /// <param name="sParams">Parametros de entrada</param>
        /// <param name="sJsonAnterior">Objeto serializado del formulario amnterior</param>
        /// <param name="sTab">id del tab activo</param>
        /// <returns></returns>
        public async Task abrirFormulario(string sModulo, string sSubMod, string sUri,
            string sEntidad, string sParams, string sJsonAnterior, string sTab)
        {
            try
            {
                //llenando info de consulta 
                mdl_Consulta oConsulta = new()
                {
                    sNombreModulo = sModulo,
                    sNombreSubModulo = sSubMod,
                    sUrlAnterior = sUri,
                    sEntidad = sEntidad,
                    sParametrosEntrada = sParams,
                    sJsonObjetoFormulario = sJsonAnterior,
                    sTabActivo = sTab
                };

                await _authenticationService.AddParametrosConsulta(oConsulta);

                //enrutamiento
                if (EntidadRutas.ContainsKey(sEntidad))
                {
                    _navigationManager.NavigateTo(EntidadRutas[sEntidad]);
                }
                //else
                //{
                //    _navigationManager.NavigateTo("/CertificarRecibos/TimbrarPeriodo/NTimbradoCFDINomina");
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //await _httpClient.CrearLog(ex, "150", "hlpFormularioConsulta-abrirFormulario");
            }
        }
    }
}
