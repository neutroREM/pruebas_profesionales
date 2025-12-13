using certinom_sadper_v1.Data.Repositories.Interfaces;

namespace certinom_sadper_v1.Data.Services
{
    public class TimbrarPeriodoService : ITimbrarPeriodoService
    {
        public Task<string> Notificacion()
        {
            return Task.FromResult("Timbrar Período");
        }
    }
}
