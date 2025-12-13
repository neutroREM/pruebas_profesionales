using certinom_sadper_v1.Modelos.ColeccionesDB;
using certinom_sadper_v1.Modelos.Settings;

namespace certinom_sadper_v1.Data.Repositories.Interfaces
{
    public interface IAuthService
    {
        mdl_UsuarioAuth User { get; }
        
        Dictionary<string, string> dicTipoNomina { get; }

        Task Initialize();
        Task Login(mdl_UsuarioAuth oUserAuth, bool bUsuarioAutenticado);
        Task<mdl_UsuarioAuth> GetUser();
        Task UpdateUser(string sRfcAnioTipo, string sNombreEmpresa);
        Task UpdateUserBuscador();
        Task Logout();
        Task UpdateEstadistica(string sJSON);
        //Task<mdl_NEstadistica> GetEstadistica();

        //Tareas de larga ejecución para evitar el cierre de sesión por inactividad
        void AddTarea(string sClave, string sValor);
        void RemoveTarea(string sClave);
        bool GetCountTareas();

        //Control de formularios de consulta
        Task AddParametrosConsulta(mdl_Consulta oConsulta);
        Task<mdl_Consulta> GetParametrosConsulta();
        Task RemoveParametrosConsulta();
    }
}
