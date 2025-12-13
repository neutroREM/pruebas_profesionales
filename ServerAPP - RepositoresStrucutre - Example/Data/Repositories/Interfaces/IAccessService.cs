using certinom_sadper_v1.Modelos.ColeccionesDB;

namespace certinom_sadper_v1.Data.Repositories.Interfaces
{
    public interface IAccessService
    {
        Task<mdl_Usuario> Login(string sUserAccess, string sPasswordAccess);
        Task Logout();
    }
}
