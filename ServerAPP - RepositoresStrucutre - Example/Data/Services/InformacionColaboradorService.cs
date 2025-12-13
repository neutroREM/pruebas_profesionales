using certinom_sadper_v1.Data.Repositories.Interfaces;

namespace certinom_sadper_v1.Data.Services
{
    public class InformacionColaboradorService : IInformacionColaboradorService
    {
        public Task<string> Notificacion()
        {
            return Task.FromResult("Información del Colaborador");
        }
    }
}
