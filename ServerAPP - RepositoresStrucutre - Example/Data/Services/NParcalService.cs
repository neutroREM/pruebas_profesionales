using certinom_sadper_v1.Data.Repositories.Interfaces;
using certinom_sadper_v1.Modelos.ColeccionesDB;

namespace certinom_sadper_v1.Data.Services
{
    public class NParcalService: INParcalService
    {
        private readonly INParcalRepository _repo;
        private readonly ILogger<NParcalService> _logger;
        public NParcalService(INParcalRepository repo, ILogger<NParcalService> logger)
        {
            _repo = repo;
            _logger = logger;
        }
        
        public async Task<List<mdl_Parcal>> ObtenerPeriodos()
        {
            List<mdl_Parcal> lsPeriodos = new List<mdl_Parcal>();

            try
            {
                lsPeriodos = await _repo.ObtenerPeriodosAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener periodos de cálculo de nómina");
                throw;
            }

            return lsPeriodos;
        }
    }
}
