using certinom_sadper_v1.Data.Repositories.Interfaces;

namespace certinom_sadper_v1.Data.Services
{
    public class CierreAnualOperacionesService : ICierreAnualOperacionesService
    {
        public Task<string> Notificacion()
        {
            return Task.FromResult("Cierre Anual de Operaciones");
        }
    }
}
