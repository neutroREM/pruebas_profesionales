using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace certinom_sadper_v1.Modelos.ColeccionesDB
{
    /*  Title: NFolioDigital
        * 
        * Versión 1.0
        * 
        * Fecha: ** de **** del 999.
        * 
        * Autor: ASLOGIC S.A. de C.V.
        * 
        * Desarrollador: ₹aúl £strada ₥ejia
        * 
        * Módulo: Modelo / Colecciones NFolioDigital
        *                
        * Descripción: Clase que modela la colección de la DB NFolioDigital.                                                                                                                   / The hiphop it's my RELIGION & GOD(YHWH) guides my steps.
        * 
        * Historial de cambios: 
        */

    [BsonIgnoreExtraElements]
    public class mdl_FolioDigital
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sId { get; set; } = string.Empty;

        [BsonElement("em_numero")]
        public int iEm_numero { get; set; }

        [BsonElement("empresa")]
        public int iEmpresa { get; set; }

        [BsonElement("ce_periodo")]
        public int iCe_periodo { get; set; }

        [BsonElement("ce_tiponom")]
        public string sCe_tiponom { get; set; } = string.Empty;

        [BsonElement("ce_fecini")]
        public DateTime? dtCe_fecini { get; set; }

        [BsonElement("ce_fecfin")]
        public DateTime? dtCe_fecfin { get; set; }

        [BsonElement("ce_fecpago")]
        public DateTime? dtCe_fecpago { get; set; }

        [BsonElement("sucursal")]
        public int iSucursal { get; set; }

        [BsonElement("serie")]
        public string sSerie { get; set; } = string.Empty;

        [BsonElement("folio")]
        public int iFolio { get; set; }

        [BsonElement("foliouuid")]
        public string sFoliouuid { get; set; } = string.Empty;

        [BsonElement("numauto")]
        public string sNumauto { get; set; } = string.Empty;

        [BsonElement("numapro")]
        public int iNumapro { get; set; }

        [BsonElement("yearapro")]
        public int iYearapro { get; set; }

        [BsonElement("fecauto")]
        public DateTime? dtFecauto { get; set; }

        [BsonElement("fecsataut")]
        public string sFecsataut { get; set; } = string.Empty;

        [BsonElement("fecemite")]
        public string sFecemite { get; set; } = string.Empty;

        [BsonElement("regfed")]
        public string sRegfed { get; set; } = string.Empty;

        [BsonElement("razsoc")]
        public string sRazsoc { get; set; } = string.Empty;

        [BsonElement("fecuso")]
        public DateTime? dtFecuso { get; set; }

        [BsonElement("fecpago")]
        public DateTime? dtFecpago { get; set; }

        [BsonElement("horauso")]
        public string sHorauso { get; set; } = string.Empty;

        [BsonElement("tipouso")]
        public string sTipouso { get; set; } = string.Empty;

        [BsonElement("forpago")]
        public string sForpago { get; set; } = string.Empty;

        [BsonElement("conpago")]
        public string sConpago { get; set; } = string.Empty;

        [BsonElement("subtotal"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSubtotal { get; set; }

        [BsonElement("descto"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fDescto { get; set; }

        [BsonElement("iva"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fIva { get; set; }

        [BsonElement("excenvia")]
        public bool bExcenvia { get; set; }

        [BsonElement("tasacero")]
        public bool bTasacero { get; set; }

        [BsonElement("ieps"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fIeps { get; set; }

        [BsonElement("total"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fTotal { get; set; }

        [BsonElement("activa")]
        public string sActiva { get; set; } = string.Empty;

        [BsonElement("fcancel")]
        public string sFcancel { get; set; } = string.Empty;

        [BsonElement("imagenxml")]
        public string sImagenxml { get; set; } = string.Empty;

        [BsonElement("imagenpdf")]
        public string sImagenpdf { get; set; } = string.Empty;

        [BsonElement("cadenaorg")]
        public string sCadenaorg { get; set; } = string.Empty;

        [BsonElement("selloorg")]
        public string sSelloorg { get; set; } = string.Empty;

        [BsonElement("sellosat")]
        public string sSellosat { get; set; } = string.Empty;

        [BsonElement("cpipedorg")]
        public string sCpipedorg { get; set; } = string.Empty;

        [BsonElement("cpipedsat")]
        public string sCpipedsat { get; set; } = string.Empty;

        [BsonElement("cimagenbid")]
        public string sCimagenbid { get; set; } = string.Empty;

        [BsonElement("ccertno")]
        public string sCcertno { get; set; } = string.Empty;

        [BsonElement("ccertbefor")]
        public string sCcertbefor { get; set; } = string.Empty;

        [BsonElement("cpacregfed")]
        public string sCpacregfed { get; set; } = string.Empty;

        [BsonElement("cpacrazsoc")]
        public string sCpacrazsoc { get; set; } = string.Empty;

        [BsonElement("cpacnumcer")]
        public string sCpacnumcer { get; set; } = string.Empty;

        [BsonElement("feccertifi")]
        public DateTime? dtFeccertifi { get; set; }

        [BsonElement("cfeccertif")]
        public string sCfeccertif { get; set; } = string.Empty;

        [BsonElement("lugcertifi")]
        public string sLugcertifi { get; set; } = string.Empty;

        [BsonElement("cancelado")]
        public bool bCancelado { get; set; }

        [BsonElement("actualizar")]
        public bool bActualizar { get; set; }

        [BsonElement("usuario")]
        public string sUsuario { get; set; } = string.Empty;

        [BsonElement("fecha")]
        public DateTime? dtFecha { get; set; }

        [BsonElement("hora")]
        public string sHora { get; set; } = string.Empty;

        [BsonElement("ctextoack")]
        public string sCtextoack { get; set; } = string.Empty;

        [BsonElement("ctextocan")]
        public string sCtextocan { get; set; } = string.Empty;

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; } = string.Empty;

        [BsonElement("sr_fecha")]
        public DateTime? dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; } = string.Empty;

        public mdl_FolioDigital()
        {
            iEm_numero = 0;
            iEmpresa = 0;
            iCe_periodo = 0;
            sCe_tiponom = string.Empty;
            dtCe_fecini = new DateTime(1900, 1, 1, 0, 0, 0);
            dtCe_fecfin = new DateTime(1900, 1, 1, 0, 0, 0);
            dtCe_fecpago = new DateTime(1900, 1, 1, 0, 0, 0);
            iSucursal = 0;
            sSerie = string.Empty;
            iFolio = 0;
            sFoliouuid = string.Empty;
            sNumauto = string.Empty;
            iNumapro = 0;
            iYearapro = 0;
            dtFecauto = new DateTime(1900, 1, 1, 0, 0, 0);
            sFecsataut = string.Empty;
            sFecemite = string.Empty;
            sRegfed = string.Empty;
            sRazsoc = string.Empty;
            dtFecuso = new DateTime(1900, 1, 1, 0, 0, 0);
            sHorauso = string.Empty;
            sTipouso = string.Empty;
            sForpago = string.Empty;
            sConpago = string.Empty;
            fSubtotal = 0.0000m;
            fDescto = 0.0000m;
            fIva = 0.0000m;
            bExcenvia = false;
            bTasacero = false;
            fIeps = 0.0000m;
            fTotal = 0.0000m;
            sActiva = string.Empty;
            sFcancel = string.Empty;
            sImagenxml = string.Empty;
            sImagenpdf = string.Empty;
            sCadenaorg = string.Empty;
            sSelloorg = string.Empty;
            sSellosat = string.Empty;
            sCpipedorg = string.Empty;
            sCpipedsat = string.Empty;
            sCimagenbid = string.Empty;
            sCcertno = string.Empty;
            sCcertbefor = string.Empty;
            sCpacregfed = string.Empty;
            sCpacrazsoc = string.Empty;
            sCpacnumcer = string.Empty;
            dtFeccertifi = new DateTime(1900, 1, 1, 0, 0, 0);
            sCfeccertif = string.Empty;
            sLugcertifi = string.Empty;
            bCancelado = false;
            bActualizar = false;
            sUsuario = string.Empty;
            dtFecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sHora = string.Empty;
            sCtextoack = string.Empty;
            sCtextocan = string.Empty;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sSr_usuario = string.Empty;
        }

    }
}
