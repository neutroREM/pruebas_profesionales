using certinom_sadper_v1.Data.Factories;
using certinom_sadper_v1.Data.Repositories.Interfaces;
using certinom_sadper_v1.Modelos.ColeccionesDB;
using certinom_sadper_v1.Modelos.Settings;
using MongoDB.Driver;


namespace certinom_sadper_v1.Data.Services
{
    public class NReporteNominaService : INReporteNominaService
    {
        private readonly IMongoCollection<mdl_Emplea> _NEmplea;
        private readonly IMongoCollection<mdl_DetallePago> _NDetallePago;
        private readonly IMongoDBContextFactory _contextFactory;
        private readonly ILogger<NReporteNominaService> _logger;
        public NReporteNominaService(
            IMongoDBContextFactory contextFactory,
            ILogger<NReporteNominaService> logger)
        {
            _contextFactory = contextFactory;
            _logger = logger;
            mdl_MongoDBSettings asas = new mdl_MongoDBSettings();
            // Obtener las colecciones del contexto a través del factory
            //var context = new cls_MongoDBContext(asas);
            var context = contextFactory.GetContext();
            _NEmplea = context.GetCollection<mdl_Emplea>("NEmplea");
            _NDetallePago = context.GetCollection<mdl_DetallePago>("NDetallePago");
        }

        /// <summary>
        /// Metodo que obtiene la informacion de colaborador, con la informacion necesaria para el reporte 
        /// </summary>
        /// <returns>Lista de tipo mdl_Emplea con la informacion de la consulta</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<List<mdl_Emplea>> ConsultaNEmplea()
        {
            List<mdl_Emplea> lsInfoColab = new List<mdl_Emplea>();
            try
            {
                if (!_contextFactory.IsInitialized)
                {
                    _logger.LogWarning("Intento de consulta sin inicializar conexión");
                    throw new InvalidOperationException("Debe iniciar sesión primero");
                }

                // Aquí va tu lógica de consulta
                // Por ejemplo:
                // lsInfoColab = await _NEmplea.Find(_ => true).ToListAsync();

                return lsInfoColab;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en ConsultaNEmplea");
               
                return lsInfoColab;
            }
        
        }

        public Task<mdl_DetallePago> ConsultaNDetallePago()
        {
            if (!_contextFactory.IsInitialized)
            {
                throw new InvalidOperationException("Debe iniciar sesión primero");
            }

            throw new NotImplementedException();
        }

        public Task<string> GenerarReporteExcel(string sInfoFormulario)
        {
            if (!_contextFactory.IsInitialized)
            {
                throw new InvalidOperationException("Debe iniciar sesión primero");
            }

            throw new NotImplementedException();
        }

        public Task<string> GenerarReportePDF(string sInforFormulario)
        {
            if (!_contextFactory.IsInitialized)
            {
                throw new InvalidOperationException("Debe iniciar sesión primero");
            }

            throw new NotImplementedException();
        }

    }
}
