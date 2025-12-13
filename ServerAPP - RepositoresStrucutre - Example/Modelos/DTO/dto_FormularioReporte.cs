namespace certinom_sadper_v1.Modelos.DTO
{
    public class dto_FormularioReporte
    {
        /// <summary>
        /// Propiedad para la opcion Imprimir Informacion Por
        /// </summary>
        public string sImprimirInfoPor { get; set; }

        /// <summary>
        /// Propiedad para la opcion Seleccionar
        /// </summary>
        public string sSeleccionar { get; set; }

        /// <summary>
        /// Propiedad para la opcion Tipo de Colaborador
        /// </summary>
        public string sTipoColaborador { get; set; }

        /// <summary>
        /// Propiedad para la opcion de Imprimir informacion(Totales o solo Detalle)
        /// </summary>
        public string sInformacion { get; set; }

        /// <summary>
        /// Propiedad para la opcion de Comentarios al titulo
        /// </summary>
        public string sComentariosTitulo { get; set; }

        /// <summary>
        /// Numero de periodo
        /// </summary>
        public int iNumPeriodo { get; set; }

        /// <summary>
        /// Tipo de nomina del periodo seleccionado
        /// </summary>
        public string sTipoNomina { get; set; }

        /// <summary>
        /// Sucursal del periodo seleccionado
        /// </summary>
        public string sSucursal { get; set; }

        public dto_FormularioReporte()
        {
            sImprimirInfoPor = "NumColab";
            sSeleccionar = "Todos";
            sTipoColaborador = "T";
            sInformacion = "Detalle";
            sComentariosTitulo = "";
            iNumPeriodo = 0;
            sTipoNomina = "";
            sSucursal = "";
        }
    }
}
