namespace certinom_sadper_v1.Modelos.Settings
{
    public class mdl_Consulta
    {    /// <summary>
         /// Nombre del módulo 
         /// </summary>
        public string sNombreModulo { get; set; }

        /// <summary>
        /// Nombre del submódulo
        /// </summary>
        public string sNombreSubModulo { get; set; }


        /// <summary>
        /// Qué catálogo o 
        /// formulario consulta
        /// </summary>
        public string sEntidad { get; set; }

        /// <summary>
        /// Url del componente donde se manda a llamar 
        /// </summary>
        public string sUrlAnterior { get; set; }

        /// <summary>
        /// Si el formulario tiene valores establecidos
        /// secoloca un json serializado de la información
        /// </summary>
        public string sJsonObjetoFormulario { get; set; }

        /// <summary>
        /// Parámetros que se envían al 
        /// formulario independiente
        /// </summary>
        public string? sParametrosEntrada { get; set; }

        /// <summary>
        /// Si el formulario es llamado desde uno donde 
        /// haya un menú tab se manda el id del tab-pane
        /// activo, al momento de regresar al formulario principal
        /// este debe volverse a activar
        /// </summary>
        public string sTabActivo { get; set; }

        /// <summary>
        /// Valor de la columna 1 cuando una fila 
        /// de la tabla del catálogo es seleccionada con 
        /// doble clic
        /// </summary>
        public int iNumeroSeleccion { get; set; }

        /// <summary>
        /// Valor de la columna 2 cuando una fila 
        /// de la tabla del catálogo es seleccionada con 
        /// doble clic
        /// </summary>
        public string sNombreSeleccion { get; set; }

        /// <summary>
        /// Número de la fila 
        /// que es seleccionada con 
        /// doble clic en la tabla del catálogo
        /// </summary>
        public int iNumeroFilaSeleccion { get; set; }


        public mdl_Consulta()
        {

            sNombreModulo = string.Empty;
            sNombreSubModulo = string.Empty;
            iNumeroSeleccion = 0;
            sNombreSeleccion = string.Empty;
            sEntidad = string.Empty;
            sUrlAnterior = string.Empty;
            iNumeroFilaSeleccion = 0;
            sJsonObjetoFormulario = string.Empty;
            sTabActivo = string.Empty;
        }
    }
}
