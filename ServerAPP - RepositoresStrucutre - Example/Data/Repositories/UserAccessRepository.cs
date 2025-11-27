using certinom_sadper_v1.Data.Factories;
using certinom_sadper_v1.Data.Repositories.Interfaces;
using certinom_sadper_v1.Modelos.ColeccionesDB;
using MongoDB.Driver;

namespace certinom_sadper_v1.Data.Repositories
{
    public class UserAccessRepository: IUserAccessRepository
    {
        private readonly IAccessDBContextFactory _accessFactory;
        private readonly ILogger<UserAccessRepository> _logger;

        public UserAccessRepository(IAccessDBContextFactory accessFactory, ILogger<UserAccessRepository> logger)
        {
            _accessFactory = accessFactory;
            _logger = logger;
        }

        private IMongoCollection<mdl_Usuario> GetCollection()
        {
            var context = _accessFactory.GetContext();
            return context.GetCollection<mdl_Usuario>("NUsuario");
        }

        public async Task<mdl_Usuario> GetByRFCyPasswordAsync(string sRFCUsuario, string sPassword)
        {
            mdl_Usuario oUsuario = new();

            var userCollection = GetCollection();   
            
            var filter = Builders<mdl_Usuario>.Filter.Eq(u => u.sRfcUsuario, sRFCUsuario) &
                         Builders<mdl_Usuario>.Filter.Eq(u => u.sPassword, sPassword) &
                         Builders<mdl_Usuario>.Filter.Eq(u => u.sSr_deleted, "0") &
                         Builders<mdl_Usuario>.Filter.Eq(u => u.bSr_suspended, false);
            var user = await userCollection.Find(filter).FirstOrDefaultAsync();
            
            if (user != null)
            {
                oUsuario = user;
            }

            return oUsuario;
        }

        public async Task<string> GetRFCEmpresa(string sRFCUsuario)
        {
            mdl_Permiso oPermiso = new();
            var permisoCollection = _accessFactory.GetContext().GetCollection<mdl_Permiso>("NPermisoUsuario");
            var filter = Builders<mdl_Permiso>.Filter.Eq(p => p.sRfcUsuario, sRFCUsuario) &
                         Builders<mdl_Permiso>.Filter.Eq(p => p.sSr_deleted, "0");
            var permiso = await permisoCollection.Find(filter).FirstOrDefaultAsync();
            if (permiso != null)
            {
                oPermiso = permiso;
            }
            return oPermiso.sRfcEmpresa;
        }

    }
}
