using certinom_sadper_v1.Modelos.ColeccionesDB;

namespace certinom_sadper_v1.Data.Repositories.Interfaces
{
    public interface INEmpresaService 
    {
        Task<mdl_Empresa> ObtenerInfoEmpresaAsync();


        Task<mdl_Empresa> ObtenerEmpresaPorRfcAsync(string rfc);


        Task<bool> ActualizarInfoEmpresaAsync(mdl_Empresa empresa);

       
        Task<string>Notificacion();
    }
}
