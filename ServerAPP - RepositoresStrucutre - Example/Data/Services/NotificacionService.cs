using certinom_sadper_v1.Data.Repositories.Interfaces;

namespace certinom_sadper_v1.Data.Services
{
    public class NotificacionService : INotificacionService
    {
        public event Action<string, string>? OnNotificar;

        public void MostrarNotificacion(string mensaje, string tipo = "info")
        {
            OnNotificar?.Invoke(mensaje, tipo);
        }

    }
}
