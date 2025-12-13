//using certinom_sadper_v1.Data.Factories;
//using certinom_sadper_v1.Data.Repositories.Interfaces;
//using certinom_sadper_v1.Data.Services;
//using certinom_sadper_v1.Modelos.ColeccionesDB;
//using MongoDB.Driver;

//namespace certinom_sadper_v1.Data.Repositories
//{
//    public class UserRepository: RepositoryService<mdl_Usuario>, IUserRepository
//    {

//        private readonly IMongoDBContextFactory _contextFactory;
//        private readonly ILogger<UserRepository> _logger;

//        //private IMongoCollection<mdl_Usuario> _userCollection;

//        public UserRepository(IMongoDBContextFactory contextFactory, ILogger<UserRepository> logger)
//       : base("Usuarios", contextFactory)
//        {
//            _contextFactory = contextFactory;
//             _logger = logger;
//            // Verificar si es mejor global o por método
//            //_userCollection = GetCollection();
//        }


//        public async Task<mdl_Usuario> GetByRFCAsync(string username)
//        {
//            try
//            {
//                // Verificar que la conexión esté inicializada
//                if (!_contextFactory.IsInitialized)
//                {
//                    _logger.LogWarning("Intento de acceso sin inicializar conexión");
//                    throw new InvalidOperationException("Debe iniciar sesión primero");
//                }
//                var _collection = GetCollection();
//                return await _collection.Find(_ => true).FirstOrDefaultAsync();
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex, "Error al obtener empresa");
//                throw;
//            }
//        }

//        //public async Task<string> GetByRFCyPassword(mdl_Usuario usuario)
//        //{
//        //    string response = string.Empty;
//        //    try
//        //    {
//        //        if (!_contextFactory.IsInitialized)
//        //        {
//        //            _logger.LogWarning("Intento de actualización sin inicializar conexión");
//        //            throw new InvalidOperationException("Debe iniciar sesión primero");
//        //        }



//        //        await CreateAsync(usuario);

//        //        var findUser = await GetByRFCyPassword(usuario.sRfcUsuario);
//        //        if (findUser != null)
//        //        {
//        //            response = findUser.id;
//        //        }
//        //        else
//        //        {
//        //            response = string.Empty;
//        //        }



//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        _logger.LogError(ex, "Error al crear el usuario: {usuario}", usuario.sUserAccess);
//        //        response = $"Error al crear el usuario: {usuario.sUserAccess}";
//        //        throw;
//        //    }
//        //    return response;
//        //}

//    }
//}
