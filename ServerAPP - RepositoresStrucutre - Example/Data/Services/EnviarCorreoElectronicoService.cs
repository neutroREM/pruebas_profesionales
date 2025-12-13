using certinom_sadper_v1.Data.Repositories.Interfaces;

namespace certinom_sadper_v1.Data.Services
{
    public class EnviarCorreoElectronicoService : IEnviarCorreoElectronicoService
    {
        public Task<string> Notificacion()
        {
            return Task.FromResult("Enviar Correo Electrónico");
        }
    }
}
