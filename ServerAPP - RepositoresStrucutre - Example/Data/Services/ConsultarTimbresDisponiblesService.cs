using certinom_sadper_v1.Data.Repositories.Interfaces;

namespace certinom_sadper_v1.Data.Services
{
    public class ConsultarTimbresDisponiblesService : IConsultarTimbresDisponiblesService
    {
        public Task<string> Notificacion()
        {
            return Task.FromResult("Consultar Timbres Disponibles");
        }
    }
}
