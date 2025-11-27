using certinom_sadper_v1.Modelos.ColeccionesDB;

namespace certinom_sadper_v1.Data.Repositories.Interfaces
{
    public interface INEmpresaRepository : IRepositoryService<mdl_Empresa>
    {
        Task<mdl_Empresa> GetEmpresaAsync();
        Task<bool> ActualizarEmpresaAsync(mdl_Empresa empresa);
    }
}
