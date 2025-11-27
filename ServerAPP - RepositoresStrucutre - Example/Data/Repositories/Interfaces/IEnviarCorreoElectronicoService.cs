namespace certinom_sadper_v1.Data.Repositories.Interfaces
{
    public interface IEnviarCorreoElectronicoService
    {
        Task<string> Notificacion();
    }
}
