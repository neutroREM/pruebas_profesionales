using certinom_sadper_v1.Data.Repositories.Interfaces;

namespace certinom_sadper_v1.Data.Services
{
    public class ImportarFiniquitoIndemnizacionService : IImportarFiniquitoIndemnizacionService
    {
        public Task<string> Notificacion()
        {
            return Task.FromResult("Importar Finiquitos de Indemnización");
        }
    }
}
