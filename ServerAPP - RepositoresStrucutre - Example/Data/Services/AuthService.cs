using Blazored.SessionStorage;
using certinom_sadper_v1.Data.Repositories.Interfaces;
using certinom_sadper_v1.Modelos.ColeccionesDB;
using certinom_sadper_v1.Modelos.Settings;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components;

using Newtonsoft.Json;
using System.Text;

namespace certinom_sadper_v1.Data.Services
{
    public class AuthService : IAuthService
    {

        private readonly HttpClient _httpService;
        private NavigationManager _navigationManager;
        private ISessionStorageService _sessionStorage;
        private readonly ILogger<AuthService> _logger;


        public mdl_UsuarioAuth User { get; private set; }
        public Dictionary<string, string> dicEjecucionTareas { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Diccionario de Tipo de Nóminas
        /// </summary>
        public Dictionary<string, string> dicTipoNomina { get; } = new()
        {
            {"ORD", "Nómina Ordinaria"},
            {"CNF", "Nómina Confidencial"},
            {"ASL", "Nómina Asimilados"},
            {"SND", "Nómina Sindicalizados"},
            {"NSD", "Nómina No Sindicalizados"}
        };

        /// <summary>
        ///  Constructor de la clase, injection de servicios a utilizar
        /// </summary>
        /// <param name="httpService"> HttpClient para las peticiones HTTP</param>
        /// <param name="navigationManager">Navegación en la aplicación</param>
        /// <param name="sessionStorage">Almacenamiento de session en el navegador</param>
        /// Historial de Cambios

        public AuthService(
            HttpClient httpService,
            NavigationManager navigationManager,
            ISessionStorageService sessionStorage,
            ILogger<AuthService> logger
        )
        {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _sessionStorage = sessionStorage;
            _logger = logger;
        }

        /// <summary>
        ///  Inicializa el servicio de autenticación 
        ///  verificando que hay un Usuario con un token válido
        ///  en el almacenamiento del navegador
        /// </summary>
        /// Historial de Cambios
        /// Implementación de la función GetUser

        public async Task Initialize()
        {
            var user = await GetUser();
            User = user;
        }

        /// <summary>
        /// Servicio de autenticación al loguearse
        /// </summary>
        /// <param name="bUsuarioAutenticado">Valida si el usuario fue autenticado del lado del servidor</param>
        /// <param name="oUserAuth"> objeto de UsuarioAuth</param>
        /// Historial de Cambios
        /// Conversión de usuario a base 64 
        /// 
        public async Task Login(mdl_UsuarioAuth oUserAuth, bool bUsuarioAutenticado)
        {
            if (bUsuarioAutenticado && oUserAuth != null)
            {
                string sBase64UserAuth = Convert.ToBase64String(Encoding.Default.GetBytes(JsonConvert.SerializeObject(oUserAuth)));
                await _sessionStorage.SetItemAsStringAsync("user", sBase64UserAuth);
                User = oUserAuth;
            }
            else
            {
                oUserAuth = null;
                await _sessionStorage.SetItemAsync("user", oUserAuth);
            }
        }

        /// <summary>
        /// Obtiene el usuario autenticado
        /// </summary>
        /// <returns>Objeto de Usuario autenticado</returns>
        /// Historial de Cambios
        /// Validación en caso de que "user" no se encuentre en el almacenamiento del navegador
        public async Task<mdl_UsuarioAuth> GetUser()
        {
            string sBase64UserAuth = await _sessionStorage.GetItemAsync<string>("user");
            if (sBase64UserAuth == null)
                return null;
            return JsonConvert.DeserializeObject<mdl_UsuarioAuth>(Encoding.Default.GetString(Convert.FromBase64String(sBase64UserAuth)));
        }

        /// <summary>
        /// Actualiza los daatos del usuario autenticado, insertando la empresa a la que accede
        /// </summary>
        /// <param name="sRfc">RFC de la empresa</param>
        /// <param name="sAnioFiscal">Año fiscal de la empresa</param>
        /// <param name="sNombreEmpresa">Nombre de la empresa</param>
        /// Historial de Cambios
        public async Task UpdateUser(string sRfcAnioTipo, string sNombreEmpresa)
        {
            mdl_UsuarioAuth oUserAuth = await GetUser();
            oUserAuth.EmpresaAcceso = sRfcAnioTipo;
            oUserAuth.EmpresaAccesoNombre = sNombreEmpresa;
            await Login(oUserAuth, true);
        }

        /// <summary> 
        /// Actualiza los datos de un usuario que tiene acceso a más de una empresa
        /// </summary>
        /// <returns></returns>
        public async Task UpdateUserBuscador()
        {
            mdl_UsuarioAuth oUserAuth = await GetUser();
            oUserAuth.EmpresaAcceso = string.Empty;
            oUserAuth.EmpresaAccesoNombre = string.Empty;
            await Login(oUserAuth, true);
        }

        /// <summary>
        /// Registra las estdísticas de la empresa en las variables de sesión en un b64
        /// </summary>
        /// <param name="sEstadisticaJson">Objeto mdl_NEstadistica serializado</param>
        /// <returns></returns>
        public async Task UpdateEstadistica(string sEstadisticaJson)
        {
            sEstadisticaJson = Convert.ToBase64String(Encoding.Default.GetBytes(sEstadisticaJson));
            await _sessionStorage.SetItemAsStringAsync("est", sEstadisticaJson);
        }

        /// <summary>
        /// Obtiene el valor de las estadísticas y las deserializa en un objeto mdl_NEstadistica para obtener sus propiedades
        /// </summary>
        /// <returns>mdl_NEstadistica</returns>
        //public async Task<mdl_NEstadistica> GetEstadistica()
        //{
        //    string sBase64UserAuth = await _sessionStorage.GetItemAsync<string>("est");
        //    if (sBase64UserAuth == null)
        //        return null;
        //    try
        //    {
        //        string sjson = Encoding.Default.GetString(Convert.FromBase64String(sBase64UserAuth));
        //        sjson = sjson.Replace(")", " ").Replace("ISODate(", "");


        //        mdl_NEstadistica oEstadistica = JsonConvert.DeserializeObject<mdl_NEstadistica>(sjson);
        //        return oEstadistica;

        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}


        /// <summary>
        ///  Termina la sesión eliminando los datos del usuario
        /// </summary>
        /// Historial de Cambios
        public async Task Logout()
        {
            User = null;
            await _sessionStorage.RemoveItemAsync("user");
        }


        public void AddTarea(string sClave, string sValor)
        {
            dicEjecucionTareas.Add(sClave, sValor);
        }
        public void RemoveTarea(string sClave)
        {
            dicEjecucionTareas.Remove(sClave);
        }

        public bool GetCountTareas()
        {
            if (dicEjecucionTareas.Count > 0)
                return true;
            else return false;
        }

        #region FormularioConsulta 

        public async Task AddParametrosConsulta(mdl_Consulta oConsulta)
        {
            string sBaseUri = _navigationManager.BaseUri.ToString();

            string sN = oConsulta.sUrlAnterior.Replace(sBaseUri, "");
            oConsulta.sUrlAnterior = sN;

            string sConsultaJson = Convert.ToBase64String
                (Encoding.Default.GetBytes(JsonConvert.SerializeObject(oConsulta)));

            if (await _sessionStorage.ContainKeyAsync("FormConsulta"))
            {
                await RemoveParametrosConsulta();
            }
            await _sessionStorage.SetItemAsStringAsync("FormConsulta", sConsultaJson);

        }

        public async Task<mdl_Consulta> GetParametrosConsulta()
        {
            string sConsultaB64 = await _sessionStorage.GetItemAsStringAsync("FormConsulta");

            try
            {
                string sjson = Encoding.Default.GetString(Convert.FromBase64String(sConsultaB64));

                mdl_Consulta oConsulta = JsonConvert.DeserializeObject<mdl_Consulta>(sjson);
                return oConsulta;

            }
            catch (Exception ex)
            {
                return new mdl_Consulta();
            }

        }


        public async Task RemoveParametrosConsulta()
        {
            await _sessionStorage.RemoveItemAsync("FormConsulta");
        }

        #endregion


    }
}
