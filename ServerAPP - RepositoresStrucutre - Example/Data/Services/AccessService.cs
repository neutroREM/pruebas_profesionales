using certinom_sadper_v1.Data.Factories;
using certinom_sadper_v1.Data.Repositories.Interfaces;
using certinom_sadper_v1.Modelos.ColeccionesDB;
using certinom_sadper_v1.Modelos.Settings;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace certinom_sadper_v1.Data.Services
{
    public class AccessService : IAccessService
    {
        private readonly IAccessDBContextFactory _contextAccessFactory;
        private readonly IMongoDBContextFactory _contextFactory;
        private readonly IUserAccessRepository _userAccessRepository;
        private readonly ILogger<AccessService> _logger;
        private readonly string _secretKey;

        public AccessService(IOptions<mdl_JwtSettings> jwtSettings, IAccessDBContextFactory contextAccessFactory, IMongoDBContextFactory contextFactory, IUserAccessRepository userAccessRepository, ILogger<AccessService> logger)
        {
            _secretKey = jwtSettings.Value.SecretKey;
            _contextAccessFactory = contextAccessFactory;
            _contextFactory = contextFactory;
            _userAccessRepository = userAccessRepository;
            _logger = logger;
        }

        public async Task<mdl_Usuario> Login(string sUserAccess, string sPasswordAccess)
        {
            bool initialized = await _contextAccessFactory.InitializeAsync();

            var specificUser = await _userAccessRepository.GetByRFCyPasswordAsync(sUserAccess, sPasswordAccess);

            if (specificUser != null && !string.IsNullOrEmpty(specificUser.sRfcUsuario) && !string.IsNullOrEmpty(specificUser.sNombre))
            {
                string sRFCUsuario = specificUser.sRfcUsuario;
                _logger.LogInformation("Usuario '{Username}' autenticado exitosamente para el RFC.", specificUser.sRfcUsuario);

                // roles del usuario
                // Acceder al rol en caso de que se utilice alguno para autentificar al usuario

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, sRFCUsuario),
                    new Claim(ClaimTypes.NameIdentifier, specificUser.Id.ToString()),
                    new Claim("FullName", specificUser.sNombre)
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_secretKey);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(claims),
                    Expires = DateTime.UtcNow.AddMinutes(30),
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                specificUser.Token = tokenHandler.WriteToken(token); // Adjunta token al usuario

                string sRFCEmpresa = await _userAccessRepository.GetRFCEmpresa(sRFCUsuario);
                await _contextFactory.InitializeAsync(sRFCEmpresa); // Se inicializa la conexion a la DB que tiene el acceso a los usuario

            }
            else
            {
                _logger.LogWarning("Intento de login fallido para usuario: {Username}", sUserAccess);
                specificUser = new mdl_Usuario();
            }
               
            return specificUser; // Return null if login fails
        }

        public Task Logout()
        {
            // Implement logout logic if needed (e.g., token invalidation)
            return Task.CompletedTask;
        }
    }
}
