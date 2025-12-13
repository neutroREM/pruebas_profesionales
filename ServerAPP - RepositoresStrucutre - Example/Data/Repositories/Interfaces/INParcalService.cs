using certinom_sadper_v1.Modelos.ColeccionesDB;

namespace certinom_sadper_v1.Data.Repositories.Interfaces
{
    public interface INParcalService
    {
        Task<List<mdl_Parcal>> ObtenerPeriodos();

    }
}
