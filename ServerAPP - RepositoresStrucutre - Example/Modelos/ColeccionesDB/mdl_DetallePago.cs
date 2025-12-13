using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace certinom_sadper_v1.Modelos.ColeccionesDB
{
    /*  Title: NDetallePago
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
    public class mdl_DetallePago
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sId { get; set; } = string.Empty;

        [BsonElement("em_numero")]
        public int iEm_numero { get; set; }

        [BsonElement("ce_nombre")]
        public string sCe_nombre { get; set; } = string.Empty;

        [BsonElement("detalledelpago")]
        public mdl_DetalleDelPago[] aDetalledelpago { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; } = string.Empty;

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; } = string.Empty;

        public mdl_DetallePago()
        {
            iEm_numero = 0;
            sCe_nombre = string.Empty;
            aDetalledelpago = Array.Empty<mdl_DetalleDelPago>();
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sSr_usuario = string.Empty;
        }
    }

    [BsonIgnoreExtraElements]
    public class mdl_DetalleDelPago
    {

        [BsonElement("ce_deleted")]
        public bool bCe_deleted { get; set; }

        [BsonElement("ce_periodo")]
        public int iCe_periodo { get; set; }

        [BsonElement("ce_tiponom")]
        public string sCe_tiponom { get; set; } = string.Empty;

        [BsonElement("ce_tiposnc")]
        public string sCe_tiposnc { get; set; } = string.Empty;

        [BsonElement("ce_turno")]
        public string sCe_turno { get; set; } = string.Empty;

        [BsonElement("ce_sucursal")]
        public int iCe_sucursal { get; set; }

        [BsonElement("ce_ccosto")]
        public int iCe_ccosto { get; set; }

        [BsonElement("ce_celula")]
        public string sCe_celula { get; set; } = string.Empty;

        [BsonElement("ce_grupo")]
        public string sCe_grupo { get; set; } = string.Empty;

        [BsonElement("ce_subgrp")]
        public string sCe_subgrp { get; set; } = string.Empty;

        [BsonElement("ce_super")]
        public int iCe_super { get; set; }

        [BsonElement("ce_cpago")]
        public int iCe_cpago { get; set; }

        [BsonElement("ce_tipocon")]
        public string sCe_tipocon { get; set; } = string.Empty;

        [BsonElement("ce_nivel")]
        public int iCe_nivel { get; set; }

        [BsonElement("ce_fecini")]
        public DateTime dtCe_fecini { get; set; }

        [BsonElement("ce_fecfin")]
        public DateTime dtCe_fecfin { get; set; }

        [BsonElement("ce_pd")]
        public int iCe_pd { get; set; }

        [BsonElement("ce_cantida"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_cantida { get; set; }

        [BsonElement("ce_acsalar"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_acsalar { get; set; }

        [BsonElement("ce_diast"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_diast { get; set; }

        [BsonElement("ce_diasims"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_diasims { get; set; }

        [BsonElement("ce_diasinc"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_diasinc { get; set; }

        [BsonElement("ce_diasau"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_diasau { get; set; }

        [BsonElement("ce_diasfes"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_diasfes { get; set; }

        [BsonElement("ce_diasvac"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_diasvac { get; set; }

        [BsonElement("ce_totalper"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_totalper { get; set; }

        [BsonElement("ce_pgrimss"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_pgrimss { get; set; }

        [BsonElement("ce_pgrispt"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_pgrispt { get; set; }

        [BsonElement("ce_subispt"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_subispt { get; set; }

        [BsonElement("ce_creispt"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_creispt { get; set; }

        [BsonElement("ce_difsub"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_difsub { get; set; }

        [BsonElement("ce_totalimss"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_totalimss { get; set; }

        [BsonElement("ce_acimss"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_acimss { get; set; }

        [BsonElement("ce_totalisr"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_totalisr { get; set; }

        [BsonElement("ce_acispt"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_acispt { get; set; }

        [BsonElement("ce_cresal"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_cresal { get; set; }

        [BsonElement("ce_accresa"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_accresa { get; set; }

        [BsonElement("ce_aporta"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_aporta { get; set; }

        [BsonElement("ce_acaport"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_acaport { get; set; }

        [BsonElement("ce_reteni"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_reteni { get; set; }

        [BsonElement("ce_acreten"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_acreten { get; set; }

        [BsonElement("ce_sdi"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_sdi { get; set; }

        [BsonElement("ce_sdivar"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_sdivar { get; set; }

        [BsonElement("ce_status")]
        public bool bCe_status { get; set; }

        [BsonElement("ce_numchec")]
        public string sCe_numchec { get; set; } = string.Empty;

        [BsonElement("ce_prevsoc"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_prevsoc { get; set; }

        [BsonElement("ce_divisi")]
        public int iCe_divisi { get; set; }

        [BsonElement("ce_saldia"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_saldia { get; set; }

        [BsonElement("ce_puesto")]
        public int iCe_puesto { get; set; }

        [BsonElement("ce_certifi")]
        public bool bCe_certifi { get; set; }

        [BsonElement("ce_filexml")]
        public string sCe_filexml { get; set; } = string.Empty;

        [BsonElement("ce_filepdf")]
        public string sCe_filepdf { get; set; } = string.Empty;

        [BsonElement("ce_errcert")]
        public string sCe_errcert { get; set; } = string.Empty;

        [BsonElement("ce_errmail")]
        public string sCe_errmail { get; set; } = string.Empty;

        [BsonElement("ce_exfaho"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_exfaho { get; set; }

        [BsonElement("ce_uuid")]
        public string sCe_uuid { get; set; } = string.Empty;

        [BsonElement("ce_sigueme")]
        public string sCe_sigueme { get; set; } = string.Empty;

        [BsonElement("ce_sditope"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_sditope { get; set; }

        [BsonElement("em_mes")]
        public int iEm_mes { get; set; }

        [BsonElement("em_fechai")]
        public DateTime dtEm_fechai { get; set; }

        [BsonElement("em_im3sm"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_im3sm { get; set; }

        [BsonElement("em_impd"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_impd { get; set; }

        [BsonElement("em_imgmp"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_imgmp { get; set; }

        [BsonElement("em_imguar"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_imguar { get; set; }

        [BsonElement("em_imrt"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_imrt { get; set; }

        [BsonElement("em_imcf"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_imcf { get; set; }

        [BsonElement("em_imiv"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_imiv { get; set; }

        [BsonElement("em_imcv"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_imcv { get; set; }

        [BsonElement("em_imtot"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_imtot { get; set; }

        [BsonElement("em_sar"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sar { get; set; }

        [BsonElement("em_info"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_info { get; set; }

        [BsonElement("em_aguina"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_aguina { get; set; }

        [BsonElement("em_vacaci"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_vacaci { get; set; }

        [BsonElement("em_primav"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_primav { get; set; }

        [BsonElement("em_estatal"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_estatal { get; set; }

        [BsonElement("em_otro"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_otro { get; set; }

        [BsonElement("em_prov1"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_prov1 { get; set; }

        [BsonElement("em_prov2"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_prov2 { get; set; }

        [BsonElement("em_prov3"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_prov3 { get; set; }

        [BsonElement("em_prov4"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_prov4 { get; set; }

        [BsonElement("em_prov5"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_prov5 { get; set; }

        [BsonElement("em_fondret"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_fondret { get; set; }

        [BsonElement("em_sevida1"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sevida1 { get; set; }

        [BsonElement("em_sevida2"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sevida2 { get; set; }

        [BsonElement("em_fahoret"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_fahoret { get; set; }

        [BsonElement("em_fideico"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_fideico { get; set; }

        [BsonElement("em_preasis"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_preasis { get; set; }

        [BsonElement("em_despen"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_despen { get; set; }

        [BsonElement("em_variab"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_variab { get; set; }

        [BsonElement("em_premioa"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_premioa { get; set; }

        [BsonElement("em_pcresal"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_pcresal { get; set; }

        [BsonElement("em_segauto"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_segauto { get; set; }

        [BsonElement("em_priant"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_priant { get; set; }

        [BsonElement("ce_conceptos")]
        public mdl_Concepto[] aCe_conceptos { get; set; }

        [BsonElement("ce_seguimiento")]
        public string sCe_Seguimiento { get; set; } = string.Empty;

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; } = string.Empty;

        public mdl_DetalleDelPago()
        {
            bCe_deleted = false;
            iCe_periodo = 0;
            sCe_tiponom = string.Empty;
            sCe_tiposnc = string.Empty;
            sCe_turno = string.Empty;
            iCe_sucursal = 0;
            iCe_ccosto = 0;
            sCe_celula = string.Empty;
            sCe_grupo = string.Empty;
            sCe_subgrp = string.Empty;
            iCe_super = 0;
            iCe_cpago = 0;
            sCe_tipocon = string.Empty;
            iCe_nivel = 0;
            dtCe_fecini = new DateTime(1900, 1, 1, 0, 0, 0);
            dtCe_fecfin = new DateTime(1900, 1, 1, 0, 0, 0);
            iCe_pd = 0;
            fCe_cantida = 0.0m;
            fCe_acsalar = 0.0m;
            fCe_diast = 0.0m;
            fCe_diasims = 0.0m;
            fCe_diasinc = 0.0m;
            fCe_diasau = 0.0m;
            fCe_diasfes = 0.0m;
            fCe_diasvac = 0.0m;
            fCe_totalper = 0.0m;
            fCe_pgrimss = 0.0m;
            fCe_pgrispt = 0.0m;
            fCe_subispt = 0.0m;
            fCe_creispt = 0.0m;
            fCe_difsub = 0.0m;
            fCe_totalimss = 0.0m;
            fCe_acimss = 0.0m;
            fCe_totalisr = 0.0m;
            fCe_acispt = 0.0m;
            fCe_cresal = 0.0m;
            fCe_accresa = 0.0m;
            fCe_aporta = 0.0m;
            fCe_acaport = 0.0m;
            fCe_reteni = 0.0m;
            fCe_acreten = 0.0m;
            fCe_sdi = 0.0m;
            fCe_sdivar = 0.0m;
            bCe_status = false;
            sCe_numchec = string.Empty;
            fCe_prevsoc = 0.0m;
            iCe_divisi = 0;
            fCe_saldia = 0.0m;
            iCe_puesto = 0;
            bCe_certifi = false;
            sCe_filexml = string.Empty;
            sCe_filepdf = string.Empty;
            sCe_errcert = string.Empty;
            sCe_errmail = string.Empty;
            fCe_exfaho = 0.0m;
            sCe_uuid = string.Empty;
            sCe_sigueme = string.Empty;
            fCe_sditope = 0.0m;
            iEm_mes = 0;
            dtEm_fechai = new DateTime(1900, 1, 1, 0, 0, 0);
            fEm_im3sm = 0.0m;
            fEm_impd = 0.0m;
            fEm_imgmp = 0.0m;
            fEm_imguar = 0.0m;
            fEm_imrt = 0.0m;
            fEm_imcf = 0.0m;
            fEm_imiv = 0.0m;
            fEm_imcv = 0.0m;
            fEm_imtot = 0.0m;
            fEm_sar = 0.0m;
            fEm_info = 0.0m;
            fEm_aguina = 0.0m;
            fEm_vacaci = 0.0m;
            fEm_primav = 0.0m;
            fEm_estatal = 0.0m;
            fEm_otro = 0.0m;
            fEm_prov1 = 0.0m;
            fEm_prov2 = 0.0m;
            fEm_prov3 = 0.0m;
            fEm_prov4 = 0.0m;
            fEm_prov5 = 0.0m;
            fEm_fondret = 0.0m;
            fEm_sevida1 = 0.0m;
            fEm_sevida2 = 0.0m;
            fEm_fahoret = 0.0m;
            fEm_fideico = 0.0m;
            fEm_preasis = 0.0m;
            fEm_despen = 0.0m;
            fEm_variab = 0.0m;
            fEm_premioa = 0.0m;
            fEm_pcresal = 0.0m;
            fEm_segauto = 0.0m;
            fEm_priant = 0.0m;
            aCe_conceptos = Array.Empty<mdl_Concepto>();
            sCe_Seguimiento = string.Empty;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sSr_usuario = string.Empty;
        }
    }

    [BsonIgnoreExtraElements]
    public class mdl_Concepto
    {
        [BsonElement("ce_perdec")]
        public int iCe_perdec { get; set; }

        [BsonElement("ce_tipopd")]
        public string sCe_tipopd { get; set; } = string.Empty;

        [BsonElement("ce_unidad"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_unidad { get; set; }

        [BsonElement("ce_subtotal"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_subtotal { get; set; }

        [BsonElement("ce_exenimss"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_exenimss { get; set; }

        [BsonElement("ce_exenisr"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_exenisr { get; set; }

        [BsonElement("ce_acumula"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCe_acumula { get; set; }

        [BsonElement("ce_referencia")]
        public string sCe_referencia { get; set; } = string.Empty;

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; } = string.Empty;

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; } = string.Empty;

        public mdl_Concepto()
        {
            iCe_perdec = 0;
            sCe_tipopd = string.Empty;
            fCe_unidad = 0.0m;
            fCe_subtotal = 0.0m;
            fCe_exenimss = 0.0m;
            fCe_exenisr = 0.0m;
            fCe_acumula = 0.0m;
            sCe_referencia = string.Empty;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sSr_usuario = string.Empty;
        }
    }
}
