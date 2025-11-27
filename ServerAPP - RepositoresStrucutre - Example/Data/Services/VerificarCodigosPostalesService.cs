using certinom_sadper_v1.Data.Repositories.Interfaces;

namespace certinom_sadper_v1.Data.Services
{
    public class VerificarCodigosPostalesService : IVerificarCodigosPostalesService
    {
        public Task<string> Notificacion()
        {

            return Task.FromResult("Verificar Códigos Postales");
        
        }

    }
}
