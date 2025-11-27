using certinom_sadper_v1.Data.Factories;
using certinom_sadper_v1.Data.Repositories.Interfaces;
using certinom_sadper_v1.Data.Services;
using certinom_sadper_v1.Modelos.ColeccionesDB;
using MongoDB.Driver;

namespace certinom_sadper_v1.Data.Repositories
{
    public class NParcalRepository : RepositoryService<mdl_ParametrosCalculoNomina>, INParcalRepository
    {
        private readonly IMongoDBContextFactory _contextFactory;
        private readonly ILogger<NParcalRepository> _logger;

        public NParcalRepository(IMongoDBContextFactory contextFactory, ILogger<NParcalRepository> logger)
            : base(contextFactory, "NParcal")
        {
            _contextFactory = contextFactory;
            _logger = logger;
        }

        public async Task<List<mdl_Parcal>> ObtenerPeriodosAsync()
        {
            List<mdl_Parcal> lsPeriodos = new List<mdl_Parcal>();
            try
            {
                if (!_contextFactory.IsInitialized)
                {
                    _logger.LogWarning("Intento de acceso sin inicializar conexión");
                    throw new InvalidOperationException("Debe iniciar sesión primero");
                }
                var _collection = GetCollection();
                var documento = await _collection
                    .Find(Builders<mdl_ParametrosCalculoNomina>.Filter.Empty)
                    .FirstOrDefaultAsync();

                if (documento?.aParcal != null )
                {
                    lsPeriodos = documento.aParcal.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener los periodos del calculo de nómina");
                throw;

            }
            return lsPeriodos;
        }
    }
}
