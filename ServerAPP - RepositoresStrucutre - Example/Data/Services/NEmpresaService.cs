using certinom_sadper_v1.Modelos.ColeccionesDB;
using certinom_sadper_v1.Data.Repositories.Interfaces;

namespace certinom_sadper_v1.Data.Services
{
    public class NEmpresaService : INEmpresaService
    {
        /// <summary>
        /// Los objetos regresan como vacíos, nunca en null
        /// </summary>

        // ANTES: private readonly NEmpresaRepository _repo;
        // AHORA: Dependemos de la abstracción (la interfaz)
        private readonly INEmpresaRepository _repo;

        // ANTES: public NEmpresaService(NEmpresaRepository repo)
        // AHORA: Inyectamos la interfaz. El sistema de DI se encargará de darnos la clase correcta.
        public NEmpresaService(INEmpresaRepository repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Obtiene la primera empresa encontrada. Mucho más eficiente que traer todas.
        /// </summary>
        public async Task<mdl_Empresa> ObtenerInfoEmpresaAsync()
        {
            try
            {
                // CAMBIO CLAVE: Usamos el método especializado del repositorio.
                // Esto ejecuta una consulta a la base de datos que solo busca y devuelve 1 documento.
                var empresa = await _repo.GetEmpresaAsync();

                // Cumplimos la regla de "nunca regresar null".
                // Si la base de datos no devuelve nada (null), nosotros devolvemos un objeto nuevo y vacío.
                return empresa ?? new mdl_Empresa();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener la información de la empresa: {ex.Message}");
                // En caso de error, también devolvemos un objeto vacío.
                return new mdl_Empresa();
            }
        }

        /// <summary>
        /// Obtiene una empresa específica por su RFC.
        /// </summary>
        public async Task<mdl_Empresa> ObtenerEmpresaPorRfcAsync(string sRFCEmpresa)
        {
            // El método GetByRFC ya existe en nuestro repositorio base, lo reutilizamos.
            var empresa = await _repo.GetByRFC(sRFCEmpresa);

            // De nuevo, cumplimos la regla de nunca regresar null.
            return empresa ?? new mdl_Empresa();
        }

        /// <summary>
        /// Actualiza la información de una empresa.
        /// </summary>
        public async Task<bool> ActualizarInfoEmpresaAsync(mdl_Empresa empresa)
        {
            // Esta lógica ya estaba perfecta. El servicio delega la responsabilidad
            // de la actualización al repositorio, que es quien sabe cómo hablar con la BD.
            return await _repo.ActualizarEmpresaAsync(empresa);
        }

        public Task<string> Notificacion()
        {
            return Task.FromResult("Datos relacionados con la Empresa");
        }
    }
}
