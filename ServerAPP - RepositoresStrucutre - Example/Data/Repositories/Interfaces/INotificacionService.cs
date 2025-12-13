namespace certinom_sadper_v1.Data.Repositories.Interfaces
{
    public interface INotificacionService
    {
        event Action<string, string> OnNotificar;
        void MostrarNotificacion(string mensaje, string tipo = "info");
    }
}
