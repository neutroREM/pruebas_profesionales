using certinom_sadper_v1.Modelos.ColeccionesDB;

namespace certinom_sadper_v1.Data.Repositories.Interfaces
{
    public interface IUserAccessRepository
    {
        Task<mdl_Usuario> GetByRFCyPasswordAsync(string sRFCUsuario, string sPassword);
        Task<string> GetRFCEmpresa(string sRFCUsuario);
    }
}
