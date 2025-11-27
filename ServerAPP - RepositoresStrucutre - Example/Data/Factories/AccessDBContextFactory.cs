using certinom_sadper_v1.Modelos.Settings;
using Microsoft.Extensions.Options;

namespace certinom_sadper_v1.Data.Factories
{
    public class AccessDBContextFactory : IAccessDBContextFactory
    {
        private cls_MongoDBContext? _context;
        private readonly mdl_MongoDBSettings _baseSettings;
        private ILogger<AccessDBContextFactory> _logger;
        private readonly object _lock = new();
        private bool _isInitialized = false;

        public AccessDBContextFactory(IOptions<mdl_MongoDBSettings> settings, ILogger<AccessDBContextFactory> logger)
        {
            _baseSettings = settings.Value;
            _logger = logger;
        }

        public bool IsInitialized => _isInitialized;

        public async Task<bool> InitializeAsync()
        {
            if (_isInitialized) return true;

            lock (_lock)
            {
                if (_isInitialized) return true;

                try
                {
                    string sDatabaseName = "CERTINOM";
                    var sessionSettings = new mdl_MongoDBSettings
                    {
                        sHost = _baseSettings.sHost,
                        sPort = _baseSettings.sPort,
                        sUsuarioPrt = _baseSettings.sUsuarioPrt,
                        sPassPrt = _baseSettings.sPassPrt,
                        sDatabase = sDatabaseName 
                    };

                    _context = new cls_MongoDBContext(sessionSettings);
                    _isInitialized = true;
                    _logger.LogInformation("Conexión a la base de datos de acceso '{DbName}' inicializada.", sessionSettings.sDatabase);
                    return true;
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error al inicializar la conexión a MongoDB");
                    return false;
                }
            }
        }

        public cls_MongoDBContext GetContext()
        {
            if (!_isInitialized || _context == null)
            {
                throw new InvalidOperationException(
                    "La conexión a la base de datos no ha sido inicializada. " +
                "Llama a InitializeAsync() primero.");
            }
            return _context;
        }

    }
}
