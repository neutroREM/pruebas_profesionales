using certinom_sadper_v1.Data.Repositories.Interfaces;

namespace certinom_sadper_v1.Data.Services
{
    public class ReportarProblemaService : IReportarProblemaService
    {
        public Task<string> Notificacion()
        {
            return Task.FromResult("Reportar un problema");
        }
    }
}
