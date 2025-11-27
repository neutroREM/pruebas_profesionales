using certinom_sadper_v1.Modelos.ColeccionesDB;

namespace certinom_sadper_v1.Modelos.TimbradoNomina
{
    /*  Title: Timbrado Nomina
        * 
        * Versión 1.0
        * 
        * Fecha: ** de **** del ⅻ d.C
        * 
        * Autor: ASLOGIC S.A. de C.V.
        * 
        * Desarrollador: ₹aúl £strada ₥ejia
        * 
        * Módulo: Timbrado de Nómina
        *                
        * Descripción: *****.                                                                                                                   
        * 
        * Historial de cambios: 
   */
    public class mdl_ProcesosNominaCFDI
    {
        public mdl_NValidacionCertificadoRequest oNValidacionCertRequest { get; set; }
        public mdl_NValidacionCertificadoResponse oNValidacionCertResponse { get; set; }
        public mdl_NTimbradoCFDINominaRequest oNTimbradoRequest { get; set; }
        public mdl_NTimbradoCFDINominResponse oNTimbradoResponse { get; set; }
        public mdl_NCancelacionNominaRequest oNCancelacionRequest { get; set; }
        public mdl_NCancelacionNominaResponse oNCancelacionResponse { get; set; }
        public mdl_NEnvioWebCFDITimbradosRequest oNEnvioWebCFDIRequest { get; set; }
        public mdl_NEnvioWebCFDITimbradosResponse oNEnvioWebCFDIResponse { get; set; }
        public mdl_NReimpresionCFDIRequest oNReimpresionCFDIRequest { get; set; }
        public mdl_NReimpresionCFDIResponse oNReimpresionCFDIResponse { get; set; }
        public mdl_NReimpresionCFDIData oNReimpresionCFDIData { get; set; }

        public mdl_ProcesosNominaCFDI()
        {
            oNValidacionCertRequest = new mdl_NValidacionCertificadoRequest();
            oNValidacionCertResponse = new mdl_NValidacionCertificadoResponse();
            oNTimbradoRequest = new mdl_NTimbradoCFDINominaRequest();
            oNTimbradoResponse = new mdl_NTimbradoCFDINominResponse();
            oNCancelacionRequest = new mdl_NCancelacionNominaRequest();
            oNCancelacionResponse = new mdl_NCancelacionNominaResponse();
            oNEnvioWebCFDIRequest = new mdl_NEnvioWebCFDITimbradosRequest();
            oNEnvioWebCFDIResponse = new mdl_NEnvioWebCFDITimbradosResponse();
            oNReimpresionCFDIRequest = new mdl_NReimpresionCFDIRequest();
            oNReimpresionCFDIResponse = new mdl_NReimpresionCFDIResponse();
            oNReimpresionCFDIData = new mdl_NReimpresionCFDIData();
        }

    }

    public class mdl_NValidacionCertificadoRequest()
    {
        public string sDataCerB64 { get; set; } = string.Empty;
        public string sDataKeyB64 { get; set; } = string.Empty;
        public string sPassword { get; set; } = string.Empty;
        public bool bAmbiente { get; set; }
    }

    public class mdl_NValidacionCertificadoResponse()
    {
        public string sTipo { get; set; } = string.Empty;

        public string sMensaje { get; set; } = string.Empty;

        public string sMensajeFirmaSAT { get; set; } = string.Empty;

        public DateTime dtFechaFinCertificado { get; set; }
    }


    public class mdl_NTimbradoCFDINominaRequest()
    {
        public int iPeriodo { get; set; }
        public int iNumeroColaborador { get; set; }
        public string sCertB64 { get; set; } = string.Empty;
        public string sKeyB64 { get; set; } = string.Empty;
        public string sPassword { get; set; } = string.Empty;
        public bool bAmbiente { get; set; }
        public string sTipoNomina { get; set; } = string.Empty;
        public string sParametros { get; set; } = string.Empty;
        public DateTime dtFechaPago { get; set; }
    }


    public class mdl_NTimbradoCFDINominResponse()
    {
        // Datos del periodo
        public int iPeriodo { get; set; }
        public string sFolio { get; set; } = string.Empty;

        // Datos del colaborador
        public int iNumeroEmpleado { get; set; }
        public string sNombreEmpleado { get; set; } = string.Empty;
        public string sRFCEmpleado { get; set; } = string.Empty;
        public bool bEsUltimo { get; set; } = false;


        // Datos del emisor
        public string sNombreEmpresa { get; set; } = string.Empty;
        public string sRFCEmpresa { get; set; } = string.Empty;

        // Datos del CFDI
        public Comprobante? oComprobante { get; set; }
        public string sUUID { get; set; } = string.Empty;
        public byte[] ayXMLNomina { get; set; } = Array.Empty<byte>();
        public byte[] ayPDFNomina { get; set; } = Array.Empty<byte>();

        /* Datos de validación */
        // CFDI en general / respuesta del timbrado por el SOAP
        public string sMensajeCFDI { get; set; } = string.Empty;
        public string sEstatusCFDI { get; set; } = string.Empty;
        public string sDetalleCFDI { get; set; } = string.Empty;
        public string sCodigoCFDI { get; set; } = string.Empty;

        // registro del XML en la DB 
        public string sMensajeDBXML { get; set; } = string.Empty;
        public string sEstatusDBXML { get; set; } = string.Empty;

        // registro del PDF en la DB
        public string sMensajeDBPDF { get; set; } = string.Empty;
        public string sEstatusDBPDF { get; set; } = string.Empty;

        // envío del PDF y XML por correo
        public string sMensajeCorreo { get; set; } = string.Empty;
        public string sEstatusCorreo { get; set; } = string.Empty;
        public Task TaskCorreo { get; set; } = Task.CompletedTask;

        // publicación del PDF y XML en el SOAP
        public string sMensajePDFXML { get; set; } = string.Empty;
        public string sEstatusPDFXML { get; set; } = string.Empty;
        public Task TaskPDFXML { get; set; } = Task.CompletedTask;

        //Objetos de la DB 
        public mdl_FolioDigital oFolioDigital { get; set; } = new mdl_FolioDigital();


    }


    public class mdl_NCancelacionNominaRequest()
    {
        public int iNumeroColaboradorCancelar { get; set; }
        public int iPeriodoColaboradorCancelar { get; set; }
        public bool bCancelFlag { get; set; } = false; // Indica la activación de las variables del constructor cls_CancelacionCFDI
        public string sRFColaborador { get; set; } = string.Empty;
        public string sFolioCancelacion { get; set; } = string.Empty; // Folio del CFDI de nómina a cancelar
        public string sMotivoCancelacion { get; set; } = string.Empty; // Motivo de la cancelación del CFDI de nómina   
        public string sUUID { get; set; } = string.Empty;
        public byte[] ayPFX { get; set; } = new byte[0];
        public string sPFXB64 { get; set; } = string.Empty; // PFX en Base64
        public string sRFCEmisor { get; set; } = string.Empty; // RFC del Colaborador   
        public string sPasswordPFX { get; set; } = string.Empty; // Contraseña del PFX

        public bool bEsCalidad { get; set; } = false; // Indica si es un ambiente de calidad o producción   

        public string sNombreDocumento { get; set; } = string.Empty; // Nombre del documento de cancelación (RFCEmpresa + Serie + Folio)

        public bool bEsMultiple { get; set; } = false; // Indica si es una cancelación múltiple de CFDI de nómina
    }


    public class mdl_NCancelacionNominaResponse()
    {
        public int iNumeroColaboradorCancelar { get; set; }
        public int iPeriodoCancelar { get; set; } = 0;
        public string sNombreColaborador { get; set; } = string.Empty;
        public string sRFColaborador { get; set; } = string.Empty;
        public string sUUID { get; set; } = string.Empty;
        public string sMensajeCancelacion { get; set; } = string.Empty;
        public string sCodigoErrorCancelacion { get; set; } = string.Empty;
        public string sEstatusCancelacion { get; set; } = string.Empty;
        public string sZIPB64 { get; set; } = string.Empty;
        public string sNombreZIP { get; set; } = string.Empty; // Nombre del documento de cancelación (RFCEmpresa + Serie + Folio)



    }

    public class mdl_NEnvioWebCFDITimbradosRequest()
    {
        public string sImprimirRecibosPor { get; set; } = string.Empty;
        public int iPeriodo { get; set; }
        public int iNumeroColaborador { get; set; }
    }

    public class mdl_NEnvioWebCFDITimbradosResponse()
    {
        public int iNumeroColaborador { get; set; }
        public string sNombreColaborador { get; set; } = string.Empty;
        public string sRFColaborador { get; set; } = string.Empty;
        public string sUUID { get; set; } = string.Empty;
        public int iPeriodoCorrespondiente { get; set; } = 0;
        public string sMensaje { get; set; } = string.Empty;
        public string sCodigo { get; set; } = string.Empty;
        public string sEstatus { get; set; } = string.Empty;

        public int iNumeroColaboradores { get; set; }
    }

    public class mdl_NReimpresionCFDIRequest()
    {
        public int iPeriodo { get; set; }
        public int iNumeroColaborador { get; set; }
        public bool bEsCalidad { get; set; } = false; // Indica si es un ambiente de calidad o producción
    }

    public class mdl_NReimpresionCFDIResponse
    {
        public int iPeriodo { get; set; }
        public string sZipB64 { get; set; } = string.Empty;
        public string sNombreZip { get; set; } = string.Empty;
        public List<mdl_NReimpresionCFDIData> lsDatosCFDI { get; set; }

        public mdl_NReimpresionCFDIResponse()
        {
            lsDatosCFDI = new List<mdl_NReimpresionCFDIData>();
        }
    }

    public class mdl_NReimpresionCFDIData()
    {
        public int iNumeroColaborador { get; set; }
        public string sRFCColaborador { get; set; } = string.Empty;
        public string sNombreColaborador { get; set; } = string.Empty;
        public byte[] ayPDF { get; set; } = new byte[0];
        public byte[] ayXML { get; set; } = new byte[0];

        public string sXMLB64 { get; set; } = string.Empty;
        public string sPDFB64 { get; set; } = string.Empty;
        public string sNombreCFDI { get; set; } = string.Empty;

    }

    public class mdl_NCancelacionCFDINominaMultipleRequest
    {
        public string sRFCEmisor { get; set; } = string.Empty;
        public string sNombreEmisor { get; set; } = string.Empty;
        public string sFolioCancelacion { get; set; } = string.Empty; // Folio del CFDI de nómina a cancelar
        public string sMotivoCancelacion { get; set; } = string.Empty; // Motivo de la cancelación del CFDI de nómina   
        public string sRutaArchivo { get; set; } = string.Empty; // Ruta del archivo ZIP
        public string sXMLZipB64 { get; set; } = string.Empty;
        public bool bEsCalidad { get; set; } = false; // Indica si es ambiente de calidad
    }


    public class mdl_NCancelacionCFDINominaMultipleResponse
    {
        public int iNumeroColaboradorCancelar { get; set; }
        public int iPeriodoCancelar { get; set; } = 0;
        public string sNombreColaborador { get; set; } = string.Empty;
        public string sRFColaborador { get; set; } = string.Empty;
        public string sUUID { get; set; } = string.Empty;
        public string sMensajeCancelacion { get; set; } = string.Empty;
        public string sCodigoErrorCancelacion { get; set; } = string.Empty;
        public string sEstatusCancelacion { get; set; } = string.Empty;
    }
}
