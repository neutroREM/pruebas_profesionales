using certinom_sadper_v1.Modelos.ColeccionesDB;

namespace certinom_sadper_v1.Data.Repositories.Interfaces
{
    public interface INParcalRepository :IRepositoryService<mdl_ParametrosCalculoNomina>
    {
        Task<List<mdl_Parcal>> ObtenerPeriodosAsync();
    }
}
