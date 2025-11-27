using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace certinom_sadper_v1.Modelos.ColeccionesDB
{
    /*  Title: NPerdec
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
    public class mdl_Perdec
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sId { get; set; } = string.Empty;

        #region Arreglos 
        [BsonElement("nperdec")]
        public mdl_NPerDec[] aNPerDec { get; set; }

        [BsonElement("nconpimp")]
        public mdl_ConpImp[] aNConpimp { get; set; }

        [BsonElement("nemplepd")]
        public mdl_EmplePD[] aNEmplepd { get; set; }

        [BsonElement("nfahopd")]
        public mdl_FondoAhorro[] aNFahopd { get; set; }

        [BsonElement("npensipd")]
        public mdl_Pension[] aNPensipd { get; set; }

        [BsonElement("npremipd")]
        public mdl_PremioAsistencia[] aNPremipd { get; set; }

        [BsonElement("nprevsoc")]
        public mdl_PrevSoc[] aNPrevsoc { get; set; }

        [BsonElement("nsindipd")]
        public mdl_CuotaSindical[] aNSindipd { get; set; }

        [BsonElement("nsprompd")]
        public mdl_SPromPD[] aNSprompd { get; set; }

        [BsonElement("nvalepd")]
        public mdl_Vale[] aNValepd { get; set; }

        [BsonElement("nestatal")]
        public mdl_Estatal[] aNEstatal { get; set; }

        #endregion

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; } = string.Empty;

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; } = string.Empty;

        public mdl_Perdec()
        {
            aNPerDec = Array.Empty<mdl_NPerDec>();
            aNConpimp = Array.Empty<mdl_ConpImp>();
            aNEmplepd = Array.Empty<mdl_EmplePD>();
            aNFahopd = Array.Empty<mdl_FondoAhorro>();
            aNPensipd = Array.Empty<mdl_Pension>();
            aNPremipd = Array.Empty<mdl_PremioAsistencia>();
            aNPrevsoc = Array.Empty<mdl_PrevSoc>();
            aNSindipd = Array.Empty<mdl_CuotaSindical>();
            aNSprompd = Array.Empty<mdl_SPromPD>();
            aNValepd = Array.Empty<mdl_Vale>();
            aNEstatal = Array.Empty<mdl_Estatal>();
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sSr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// Modelo de percepciones y deducciones
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_NPerDec
    {
        [BsonElement("pd_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sPd_id { get; set; }

        [BsonElement("pd_numero")]
        public int iPd_numero { get; set; }

        [BsonElement("pd_pd")]
        public string sPd_pd { get; set; }

        [BsonElement("pd_descrip")]
        public string sPd_descrip { get; set; }

        [BsonElement("pd_tipo")]
        public string sPd_tipo { get; set; }

        [BsonElement("pd_espejo")]
        public bool bPd_espejo { get; set; }

        [BsonElement("pd_aplicar"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPd_aplicar { get; set; }

        [BsonElement("pd_formula")]
        public string sPd_formula { get; set; }

        [BsonElement("pd_excento"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPd_excento { get; set; }

        [BsonElement("pd_desexce")]
        public string sPd_desexce { get; set; }

        [BsonElement("pd_gispt")]
        public string sPd_gispt { get; set; }

        [BsonElement("pd_gimss")]
        public string sPd_gimss { get; set; }

        [BsonElement("pd_ginfona")]
        public string sPd_ginfona { get; set; }

        [BsonElement("pd_acumula")]
        public string sPd_acumula { get; set; }

        [BsonElement("pd_aptu")]
        public string sPd_aptu { get; set; }

        [BsonElement("pd_exceisp"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPd_exceisp { get; set; }

        [BsonElement("pd_isexfor")]
        public string sPd_isexfor { get; set; }

        [BsonElement("pd_toispt"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPd_toispt { get; set; }

        [BsonElement("pd_isformu")]
        public string sPd_isformu { get; set; }

        [BsonElement("pd_exceims"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPd_exceims { get; set; }

        [BsonElement("pd_imexfor")]
        public string sPd_imexfor { get; set; }

        [BsonElement("pd_toimss"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPd_toimss { get; set; }

        [BsonElement("pd_imformu")]
        public string sPd_imformu { get; set; }

        [BsonElement("pd_ley")]
        public string sPd_ley { get; set; }

        [BsonElement("pd_salajus")]
        public string sPd_salajus { get; set; }

        [BsonElement("pd_diajus")]
        public string sPd_diajus { get; set; }

        [BsonElement("pd_sumdias")]
        public string sPd_sumdias { get; set; }

        [BsonElement("pd_he4hdia")]
        public string sPd_he4hdia { get; set; }

        [BsonElement("pd_he4dsem")]
        public string sPd_he4dsem { get; set; }

        [BsonElement("pd_he9hsem")]
        public string sPd_he9hsem { get; set; }

        [BsonElement("pd_ajuste"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPd_ajuste { get; set; }

        [BsonElement("pd_corto")]
        public string sPd_corto { get; set; }

        [BsonElement("pd_codigo")]
        public string sPd_codigo { get; set; }

        [BsonElement("pd_basesta")]
        public string sPd_basesta { get; set; }

        [BsonElement("pd_unpago")]
        public bool bPd_unpago { get; set; }

        [BsonElement("pd_ccont")]
        public string sPd_ccont { get; set; }

        [BsonElement("pd_numsat")]
        public int iPd_numsat { get; set; }

        [BsonElement("pd_nombrescr")]
        public string sPd_nombrescr { get; set; }

        [BsonElement("pd_script")]
        public string sPd_script { get; set; }

        [BsonElement("pd_otrosat")]
        public int iPd_otrosat { get; set; }

        [BsonElement("pd_sr_recno")]
        public long iPd_sr_recno { get; set; }

        [BsonElement("pd_sr_deleted")]
        public string sPd_sr_deleted { get; set; }

        [BsonElement("pd_sr_fecha")]
        public DateTime dtPd_sr_fecha { get; set; }

        [BsonElement("pd_sr_usuario")]
        public string sPd_sr_usuario { get; set; }

        // Constructor para inicializar las propiedades con los valores predeterminados
        public mdl_NPerDec()
        {
            sPd_id = ObjectId.GenerateNewId().ToString();
            iPd_numero = 0;
            sPd_pd = string.Empty;
            sPd_descrip = string.Empty;
            sPd_tipo = string.Empty;
            bPd_espejo = false;
            fPd_aplicar = 0.0m;
            sPd_formula = string.Empty;
            fPd_excento = 0.0m;
            sPd_desexce = string.Empty;
            sPd_gispt = string.Empty;
            sPd_gimss = string.Empty;
            sPd_ginfona = string.Empty;
            sPd_acumula = string.Empty;
            sPd_aptu = string.Empty;
            fPd_exceisp = 0.0m;
            
            sPd_isexfor = string.Empty;
            fPd_toispt = 0.0m;
            sPd_isformu = string.Empty;
            fPd_exceims = 0.0m;
            sPd_imexfor = string.Empty;
            fPd_toimss = 0.0m;
            sPd_imformu = string.Empty;
            sPd_ley = string.Empty;
            sPd_salajus = string.Empty;
            sPd_diajus = string.Empty;
            sPd_sumdias = string.Empty;
            sPd_he4hdia = string.Empty;
            sPd_he4dsem = string.Empty;
            sPd_he9hsem = string.Empty;
            fPd_ajuste = 0.0m;
          
            sPd_corto = string.Empty;
            sPd_codigo = string.Empty;
            sPd_basesta = string.Empty;
            bPd_unpago = false;
            sPd_ccont = string.Empty;
            iPd_numsat = 0;
            sPd_nombrescr = string.Empty;
            sPd_script = string.Empty;
            iPd_otrosat = 0;
            iPd_sr_recno = 0;
            sPd_sr_deleted = string.Empty;
            dtPd_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sPd_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// Verificar nombre
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_ConpImp
    {
        [BsonElement("cc_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sCc_id { get; set; }

        [BsonElement("cc_sucur")]
        public int iCc_sucur { get; set; }

        [BsonElement("cc_pd")]
        public int iCc_pd { get; set; }

        [BsonElement("cc_tipoi")]
        public string sCc_tipoi { get; set; }

        [BsonElement("cc_ccosto")]
        public int iCc_ccosto { get; set; }

        [BsonElement("cc_sr_recno")]
        public long iCc_sr_recno { get; set; }

        [BsonElement("cc_sr_deleted")]
        public string sCc_sr_deleted { get; set; }

        [BsonElement("cc_sr_fecha")]
        public DateTime dtCc_sr_fecha { get; set; }

        [BsonElement("cc_sr_usuario")]
        public string sCc_sr_usuario { get; set; }

        // Constructor para inicializar las propiedades con los valores predeterminados
        public mdl_ConpImp()
        {
            sCc_id = ObjectId.GenerateNewId().ToString();
            iCc_sucur = 0;
            iCc_pd = 0;
            sCc_tipoi = string.Empty;
            iCc_ccosto = 0;
            iCc_sr_recno = 0;
            sCc_sr_deleted = string.Empty;
            dtCc_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sCc_sr_usuario = string.Empty;
        }

    }

    [BsonIgnoreExtraElements]
    public class mdl_PrevSoc
    {
        [BsonElement("pv_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sPd_id { get; set; }

        [BsonElement("pv_tipoemp")]
        public string sPv_tipoemp { get; set; }

        [BsonElement("pv_pretipo")]
        public string sPv_pretipo { get; set; }

        [BsonElement("pv_pernum")]
        public int iPv_pernum { get; set; }

        [BsonElement("pv_monto"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPv_monto { get; set; }

        [BsonElement("pv_perform")]
        public string sPv_perform { get; set; }

        [BsonElement("pv_dedref")]
        public int iPv_dedref { get; set; }

        [BsonElement("pv_montode"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPv_montode { get; set; }

        [BsonElement("pv_refform")]
        public string sPv_refform { get; set; }

        [BsonElement("pv_ciclo")]
        public string sPv_ciclo { get; set; }

        [BsonElement("pv_periodo")]
        public int iPv_periodo { get; set; }

        [BsonElement("pv_excimss")]
        public string sPv_excimss { get; set; }

        [BsonElement("pv_monexim"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPv_monexim { get; set; }

        [BsonElement("pv_imformu")]
        public string sPv_imformu { get; set; }

        [BsonElement("pv_excispt")]
        public string sPv_excispt { get; set; }

        [BsonElement("pv_monexis"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPv_monexis { get; set; }

        [BsonElement("pv_isformu")]
        public string sPv_isformu { get; set; }

        [BsonElement("pv_exinfon")]
        public string sPv_exinfon { get; set; }

        [BsonElement("pv_nomeinf"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPv_nomeinf { get; set; }

        [BsonElement("pv_informu")]
        public string sPv_informu { get; set; }

        [BsonElement("pv_tope"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPv_tope { get; set; }

        [BsonElement("pv_toformu")]
        public string sPv_toformu { get; set; }

        [BsonElement("pv_acumula")]
        public string sPv_acumula { get; set; }

        [BsonElement("pv_tipcont")]
        public string sPv_tipcont { get; set; }

        [BsonElement("pv_tiponom")]
        public string sPv_tiponom { get; set; }

        [BsonElement("pv_sucursa")]
        public int iPv_sucursa { get; set; }

        [BsonElement("pv_imprec")]
        public string sPv_imprec { get; set; }

        [BsonElement("pv_catego")]
        public int iPv_catego { get; set; }

        [BsonElement("pv_cfgpago")]
        public bool bPv_cfgpago { get; set; }

        [BsonElement("pv_activi")]
        public string sPv_activi { get; set; }

        [BsonElement("pv_sr_recno")]
        public long iPv_sr_recno { get; set; }

        [BsonElement("pv_sr_deleted")]
        public string sPv_sr_deleted { get; set; }

        [BsonElement("pv_sr_fecha")]
        public DateTime dtPv_sr_fecha { get; set; }

        [BsonElement("pv_sr_usuario")]
        public string sPv_sr_usuario { get; set; }

        public mdl_PrevSoc()
        {
            sPd_id = ObjectId.GenerateNewId().ToString();
            sPv_tipoemp = string.Empty;
            sPv_pretipo = string.Empty;
            iPv_pernum = 0;
            fPv_monto = 0.0m;
            ;
            sPv_perform = string.Empty;
            iPv_dedref = 0;
            fPv_montode = 0.0m;
            ;
            sPv_refform = string.Empty;
            sPv_ciclo = string.Empty;
            iPv_periodo = 0;
            sPv_excimss = string.Empty;
            fPv_monexim = 0.0m;
            ;
            sPv_imformu = string.Empty;
            sPv_excispt = string.Empty;
            fPv_monexis = 0.0m;
            ;
            sPv_isformu = string.Empty;
            sPv_exinfon = string.Empty;
            fPv_nomeinf = 0.0m;
            ;
            sPv_informu = string.Empty;
            fPv_tope = 0.0m;
            ;
            sPv_toformu = string.Empty;
            sPv_acumula = string.Empty;
            sPv_tipcont = string.Empty;
            sPv_tiponom = string.Empty;
            iPv_sucursa = 0;
            sPv_imprec = string.Empty;
            iPv_catego = 0;
            bPv_cfgpago = false;
            sPv_activi = string.Empty;
            iPv_sr_recno = 0;
            sPv_sr_deleted = string.Empty;
            dtPv_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sPv_sr_usuario = string.Empty;
        }

    }

    [BsonIgnoreExtraElements]
    public class mdl_Estatal
    {
        [BsonElement("gp_sucursa")]
        public int iGp_sucursa { get; set; }

        [BsonElement("gp_concep")]
        public int iGp_concep { get; set; }

        [BsonElement("gp_numero")]
        public int iGp_numero { get; set; }

        [BsonElement("gp_tiposn")]
        public string sGp_tiposn { get; set; }

        [BsonElement("gp_conta")]
        public string sGp_conta { get; set; }

        [BsonElement("em_subgrp")]
        public string sEm_subgrp { get; set; }

        [BsonElement("gp_sr_recno")]
        public long iGp_sr_recno { get; set; }

        [BsonElement("gp_sr_deleted")]
        public string sGp_sr_deleted { get; set; }

        [BsonElement("gp_sr_fecha")]
        public DateTime dtGp_sr_fecha { get; set; }

        [BsonElement("gp_sr_usuario")]
        public string sGp_sr_usuario { get; set; }
        public mdl_Estatal()
        {
            iGp_sucursa = 0;
            iGp_concep = 0;
            iGp_numero = 0;
            sGp_tiposn = string.Empty;
            sGp_conta = string.Empty;
            sEm_subgrp = string.Empty;
            iGp_sr_recno = 0;
            sGp_sr_deleted = string.Empty;
            dtGp_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sGp_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// Verificar nombre
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Vale
    {
        [BsonElement("vp_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sPd_id { get; set; }

        [BsonElement("vp_tiposnc")]
        public string sVp_tiposnc { get; set; }

        [BsonElement("vp_tiponom")]
        public string sVp_tiponom { get; set; }

        [BsonElement("vp_tipocon")]
        public string sVp_tipocon { get; set; }

        [BsonElement("vp_pd")]
        public int iVp_pd { get; set; }

        [BsonElement("vp_sr_recno")]
        public long iVp_sr_recno { get; set; }

        [BsonElement("vp_sr_deleted")]
        public string sVp_sr_deleted { get; set; }

        [BsonElement("vp_sr_fecha")]
        public DateTime dtVp_sr_fecha { get; set; }

        [BsonElement("vp_sr_usuario")]
        public string sVp_sr_usuario { get; set; }

        public mdl_Vale()
        {
            sPd_id = ObjectId.GenerateNewId().ToString();
            sVp_tiposnc = string.Empty;
            sVp_tiponom = string.Empty;
            sVp_tipocon = string.Empty;
            iVp_pd = 0;
            iVp_sr_recno = 0;
            sVp_sr_deleted = string.Empty;
            dtVp_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sVp_sr_usuario = string.Empty;
        }
    }

    [BsonIgnoreExtraElements]
    public class mdl_EmplePD : mdl_PD
    {
        [BsonElement("pd_activi")]
        public string sPd_activi { get; set; }

        [BsonElement("pd_sr_recno")]
        public long iPd_sr_recno { get; set; }

        [BsonElement("pd_sr_deleted")]
        public string sPd_sr_deleted { get; set; }

        [BsonElement("pd_sr_fecha")]
        public DateTime dtPd_sr_fecha { get; set; }

        [BsonElement("pd_sr_usuario")]
        public string sPd_sr_usuario { get; set; }

        public mdl_EmplePD()
        {
            sPd_activi = string.Empty;
            iPd_sr_recno = 0;
            sPd_sr_deleted = string.Empty;
            dtPd_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sPd_sr_usuario = string.Empty;
        }
    }

    [BsonIgnoreExtraElements]
    public class mdl_FondoAhorro : mdl_PD
    {
        [BsonElement("pd_activi")]
        public string sPd_activi { get; set; }

        [BsonElement("pd_sr_recno")]
        public long iPd_sr_recno { get; set; }

        [BsonElement("pd_sr_deleted")]
        public string sPd_sr_deleted { get; set; }

        [BsonElement("pd_sr_fecha")]
        public DateTime dtPd_sr_fecha { get; set; }

        [BsonElement("pd_sr_usuario")]
        public string sPd_sr_usuario { get; set; }

        public mdl_FondoAhorro()
        {
            sPd_activi = string.Empty;
            iPd_sr_recno = 0;
            sPd_sr_deleted = string.Empty;
            dtPd_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sPd_sr_usuario = string.Empty;
        }
    }

    [BsonIgnoreExtraElements]
    public class mdl_Pension : mdl_PD
    {
        [BsonElement("pd_activi")]
        public string sPd_activi { get; set; }

        [BsonElement("pd_sr_recno")]
        public long iPd_sr_recno { get; set; }

        [BsonElement("pd_sr_deleted")]
        public string sPd_sr_deleted { get; set; }

        [BsonElement("pd_sr_fecha")]
        public DateTime dtPd_sr_fecha { get; set; }

        [BsonElement("pd_sr_usuario")]
        public string sPd_sr_usuario { get; set; }
        public mdl_Pension()
        {
            sPd_activi = string.Empty;
            iPd_sr_recno = 0;
            sPd_sr_deleted = string.Empty;
            dtPd_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sPd_sr_usuario = string.Empty;
        }
    }

    [BsonIgnoreExtraElements]
    public class mdl_PremioAsistencia : mdl_PD
    {
        [BsonElement("pd_expremi")]
        public bool bPd_expremi { get; set; }

        [BsonElement("pd_activi")]
        public string sPd_activi { get; set; }

        [BsonElement("pd_sr_recno")]
        public long iPd_sr_recno { get; set; }

        [BsonElement("pd_sr_deleted")]
        public string sPd_sr_deleted { get; set; }

        [BsonElement("pd_sr_fecha")]
        public DateTime dtPd_sr_fecha { get; set; }

        [BsonElement("pd_sr_usuario")]
        public string sPd_sr_usuario { get; set; }
        public mdl_PremioAsistencia()
        {
            bPd_expremi = false;
            sPd_activi = string.Empty;
            iPd_sr_recno = 0;
            sPd_sr_deleted = string.Empty;
            dtPd_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sPd_sr_usuario = string.Empty;
        }
    }

    [BsonIgnoreExtraElements]
    public class mdl_CuotaSindical : mdl_PD
    {
        [BsonElement("pd_activi")]
        public string sPd_activi { get; set; }

        [BsonElement("pd_sr_recno")]
        public long iPd_sr_recno { get; set; }

        [BsonElement("pd_sr_deleted")]
        public string sPd_sr_deleted { get; set; }

        [BsonElement("pd_sr_fecha")]
        public DateTime dtPd_sr_fecha { get; set; }

        [BsonElement("pd_sr_usuario")]
        public string sPd_sr_usuario { get; set; }

        public mdl_CuotaSindical()
        {
            sPd_activi = string.Empty;
            iPd_sr_recno = 0;
            sPd_sr_deleted = string.Empty;
            dtPd_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sPd_sr_usuario = string.Empty;
        }
    }

    [BsonIgnoreExtraElements]
    public class mdl_SPromPD : mdl_PD
    {
        [BsonElement("pd_sr_recno")]
        public long iPd_sr_recno { get; set; }

        [BsonElement("pd_sr_deleted")]
        public string sPd_sr_deleted { get; set; }

        [BsonElement("pd_sr_fecha")]
        public DateTime dtPd_sr_fecha { get; set; }

        [BsonElement("pd_sr_usuario")]
        public string sPd_sr_usuario { get; set; }

        public mdl_SPromPD()
        {
            iPd_sr_recno = 0;
            sPd_sr_deleted = string.Empty;
            dtPd_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sPd_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// clase general para los arreglos nemplepd, nfahopd, npensipd, npremipd, nsindpd, nsprompd
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_PD
    {
        [BsonElement("pd_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sPd_id { get; set; }

        [BsonElement("pd_todos")]
        public bool bPd_todos { get; set; }

        [BsonElement("pd_periodo")]
        public int iPd_periodo { get; set; }

        [BsonElement("pd_tiponom")]
        public string sPd_tiponom { get; set; }

        [BsonElement("pd_tipoemp")]
        public string sPd_tipoemp { get; set; }

        [BsonElement("em_numero")]
        public int iEm_numero { get; set; }

        [BsonElement("pd_numero")]
        public int iPd_numero { get; set; }

        [BsonElement("pd_monto"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPd_monto { get; set; }

        [BsonElement("pd_tiempo")]
        public string sPd_tiempo { get; set; }

        [BsonElement("pd_modelo")]
        public string sPd_modelo { get; set; }

        [BsonElement("pd_tipocon")]
        public string sPd_tipocon { get; set; }

        public mdl_PD()
        {
            sPd_id = ObjectId.GenerateNewId().ToString();
            bPd_todos = false;
            iPd_periodo = 0;
            sPd_tiponom = string.Empty;
            sPd_tipoemp = string.Empty;
            iEm_numero = 0;
            iPd_numero = 0;
            fPd_monto = 0.0m;
            ;
            sPd_tiempo = string.Empty;
            sPd_modelo = string.Empty;
            sPd_tipocon = string.Empty;
        }
    }
}
