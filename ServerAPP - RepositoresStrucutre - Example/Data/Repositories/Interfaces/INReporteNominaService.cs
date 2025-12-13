using certinom_sadper_v1.Modelos.ColeccionesDB;

namespace certinom_sadper_v1.Data.Repositories.Interfaces
{
    public interface INReporteNominaService
    {
        Task<mdl_DetallePago> ConsultaNDetallePago();

        Task<List<mdl_Emplea>> ConsultaNEmplea();

        Task<string> GenerarReportePDF(string sInforFormulario);

        Task<string> GenerarReporteExcel(string sInfoFormulario);
    }
}
