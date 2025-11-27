using certinom_sadper_v1.Modelos.ColeccionesDB;

namespace certinom_sadper_v1.Data.Repositories.Interfaces
{
    public interface IUserRepository :IRepositoryService<mdl_Usuario>
    {
        Task<mdl_Usuario> GetByRFCAsync(string sRFCUsuario);

    }
}
