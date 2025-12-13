using certinom_sadper_v1.Data.Repositories.Interfaces;

namespace certinom_sadper_v1.Data.Services
{
    public class CancelarXMLService : ICancelarXMLService
    {
        public Task<string> Notificacion()
        {
            return Task.FromResult("Cancelación de XML");
        }
    }
}
