using MongoDB.Driver;
using certinom_sadper_v1.Modelos.ColeccionesDB;
using certinom_sadper_v1.Data.Repositories.Interfaces;
using certinom_sadper_v1.Data.Services;
using certinom_sadper_v1.Data.Factories;

namespace certinom_sadper_v1.Data.Repositories
{

    public class NEmpresaRepository : RepositoryService<mdl_Empresa>, INEmpresaRepository
    {
        private readonly IMongoDBContextFactory _contextFactory;
        private readonly ILogger<NEmpresaRepository> _logger;
        public NEmpresaRepository(IMongoDBContextFactory contextFactory, ILogger<NEmpresaRepository> logger)
            : base(contextFactory, "NEmpresa")
        {
            _contextFactory = contextFactory;
            _logger = logger;
        }

        public async Task<mdl_Empresa> GetEmpresaAsync()
        {
            try
            {
                // Verificar que la conexión esté inicializada
                if (!_contextFactory.IsInitialized)
                {
                    _logger.LogWarning("Intento de acceso sin inicializar conexión");
                    throw new InvalidOperationException("Debe iniciar sesión primero");
                }
                var _collection = GetCollection();
                return await _collection.Find(_ => true).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener empresa");
                throw;
            }
        }
        
        public async Task<bool> ActualizarEmpresaAsync(mdl_Empresa empresa)
        {
            try
            {
                if (!_contextFactory.IsInitialized)
                {
                    _logger.LogWarning("Intento de actualización sin inicializar conexión");
                    throw new InvalidOperationException("Debe iniciar sesión primero");
                }

                var filter = Builders<mdl_Empresa>.Filter.Eq(e => e.sCo_rfc, empresa.sCo_rfc);
                var update = Builders<mdl_Empresa>.Update
                    .Set(e => e.sCo_nomsat, empresa.sCo_nomsat)
                    .Set(e => e.sCo_infona, empresa.sCo_infona)
                    .Set(e => e.sCo_imss, empresa.sCo_imss)
                    .Set(e => e.sCo_estado, empresa.sCo_estado)
                    .Set(e => e.sCo_ciudad, empresa.sCo_ciudad)
                    .Set(e => e.sCo_colonia, empresa.sCo_colonia)
                    .Set(e => e.sCo_calle, empresa.sCo_calle)
                    .Set(e => e.sCo_cp, empresa.sCo_cp)
                    .Set(e => e.sCo_rfcleg, empresa.sCo_rfcleg)
                    .Set(e => e.sCo_curpleg, empresa.sCo_curpleg)
                    .Set(e => e.sCo_rfiscal, empresa.sCo_rfiscal)
                    .Set(e => e.sCo_tiporg, empresa.sCo_tiporg)
                    .Set(e => e.sCo_legal, empresa.sCo_legal)
                    .Set(e => e.sCo_rfcsub, empresa.sCo_rfcsub);

                return await UpdateOneAsync(filter, update);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al actualizar empresa con RFC: {RFC}", empresa.sCo_rfc);
                throw;
            }

        }
    
    }
}
