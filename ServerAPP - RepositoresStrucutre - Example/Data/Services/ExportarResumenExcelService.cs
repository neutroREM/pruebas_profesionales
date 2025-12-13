using certinom_sadper_v1.Data.Repositories.Interfaces;

namespace certinom_sadper_v1.Data.Services
{
    public class ExportarResumenExcelService : IExportarResumenExcelService
    {
        public Task<string> Notificacion()
        {
            return Task.FromResult("Exportar Resumen en Excel");
        }
    }
}
