using certinom_sadper_v1.Data.Repositories.Interfaces;

namespace certinom_sadper_v1.Data.Services
{
    public class CambiarXMLTimbradoService : ICambiarXMLTimbradoService
    {
        public Task<string> Notificacion()
        {
            return Task.FromResult("Cambiar XML Timbrado");
        }
    }
}
