using certinom_sadper_v1.Data.Repositories.Interfaces;

namespace certinom_sadper_v1.Data.Services
{
    public class ConvertirXMLSFTPService : IConvertirXMLSFTPService
    {
        public Task<string> Notificacion()
        {
            return Task.FromResult("Convertir XML a SFTP");
        }
    }
}
