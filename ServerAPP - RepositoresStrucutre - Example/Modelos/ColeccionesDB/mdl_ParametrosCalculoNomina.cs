using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;


namespace certinom_sadper_v1.Modelos.ColeccionesDB
{
    /*  Title: NParcal
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
    public class mdl_ParametrosCalculoNomina
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sId { get; set; } = string.Empty;

        [BsonElement("nparcal")]
        public mdl_Parcal[] aParcal { get; set; }

        [BsonElement("nperiodo")]
        public mdl_PeriodoPar[] aPeriodo { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; } = string.Empty;

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; } = string.Empty;

        public mdl_ParametrosCalculoNomina()
        {
            aParcal = Array.Empty<mdl_Parcal>();
            aPeriodo = Array.Empty<mdl_PeriodoPar>();
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sSr_usuario = string.Empty;
        }
    }


    [BsonIgnoreExtraElements]
    public class mdl_Parcal
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sId { get; set; } = string.Empty;

        [BsonElement("cl_descrip")]
        public string sCl_descrip { get; set; }= string.Empty;

        [BsonElement("cl_espec")]
        public string sCl_espec { get; set; }= string.Empty;


        [BsonElement("cl_periodo")]
        [Range(1, int.MaxValue, ErrorMessage = "El valor debe ser mayor a cero.")]
        public int iCl_periodo { get; set; }

        [BsonElement("cl_tiponom")]
        [Required(ErrorMessage = "El campo no puede estar vacío.")]
        public string sCl_tiponom { get; set; }= string.Empty;

        [BsonElement("cl_fecini")]
        public DateTime? dtCl_fecini { get; set; }

        [BsonElement("cl_fecfin")]
        public DateTime? dtCl_fecfin { get; set; }

        [BsonElement("cl_fecpago")]
        public DateTime? dtCl_fecpago { get; set; }

        [BsonElement("cl_numdias"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCl_numdias { get; set; }

        [BsonElement("cl_diasims"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCl_diasims { get; set; }

        [BsonElement("cl_numsem")]
        public int iCl_numsem { get; set; }

        [BsonElement("cl_numquin")]
        public int iCl_numquin { get; set; }

        [BsonElement("cl_isptmen")]
        public string sCl_isptmen { get; set; }= string.Empty;

        [BsonElement("cl_isptanu")]
        public string sCl_isptanu { get; set; }= string.Empty;

        [BsonElement("cl_ivalesdesp")]
        public string sCl_ivalesdesp { get; set; }= string.Empty;

        [BsonElement("cl_ivalesalim")]
        public string sCl_ivalesalim { get; set; }= string.Empty;

        [BsonElement("cl_control")]
        public int iCl_control { get; set; }

        [BsonElement("cl_factor"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCl_factor { get; set; }

        [BsonElement("cl_mes")]
        [Range(1, 12, ErrorMessage = "Debes seleccionar un mes")]
        public int iCl_mes { get; set; }

        [BsonElement("cl_proceso")]
        public DateTime? dtCl_proceso { get; set; }

        [BsonElement("cl_subinc")]
        public string sCl_subinc { get; set; }= string.Empty;

        [BsonElement("cl_ajuste"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCl_ajuste { get; set; }

        [BsonElement("cl_fahorro")]
        public string sCl_fahorro { get; set; }= string.Empty;

        [BsonElement("cl_prevsoc")]
        public string sCl_prevsoc { get; set; }= string.Empty;

        [BsonElement("cl_cdiavac")]
        public DateTime? dtCl_cdiavac { get; set; }

        [BsonElement("cl_retrope")]
        public string sCl_retrope { get; set; }= string.Empty;

        [BsonElement("cl_rifecha")]
        public DateTime? dtCl_rifecha { get; set; }

        [BsonElement("cl_rffecha")]
        public DateTime? dtCl_rffecha { get; set; }

        [BsonElement("cl_sdivar")]
        public string sCl_sdivar { get; set; }= string.Empty;

        [BsonElement("cl_sucur")]
        public int iCl_sucur { get; set; }

        [BsonElement("cl_turno")]
        public string sCl_turno { get; set; }= string.Empty;

        [BsonElement("cl_celula")]
        public string sCl_celula { get; set; }= string.Empty;

        [BsonElement("cl_grupo")]
        public string sCl_grupo { get; set; }= string.Empty;

        [BsonElement("cl_ccosto")]
        public int iCl_ccosto { get; set; }

        [BsonElement("cl_nivel")]
        public int iCl_nivel { get; set; }

        [BsonElement("cl_afechai")]
        public DateTime? dtCl_afechai { get; set; }

        [BsonElement("cl_afechaf")]
        public DateTime? dtCl_afechaf { get; set; }

        [BsonElement("cl_calific")]
        public bool bCl_calific { get; set; }

        [BsonElement("cl_tcambio"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCl_tcambio { get; set; }

        [BsonElement("cl_sr_recno")]
        public long iCl_sr_recno { get; set; }

        [BsonElement("cl_sr_deleted")]
        public string sCl_sr_deleted { get; set; }= string.Empty;

        [BsonElement("cl_sr_fecha")]
        public DateTime? dtCl_sr_fecha { get; set; }

        [BsonElement("cl_sr_usuario")]
        public string sCl_sr_usuario { get; set; }= string.Empty;

        [BsonElement("cl_seguimiento")]
        public string sCl_seguimiento { get; set; }= string.Empty;

        [BsonElement("cl_repnom")]
        public string sCl_repnom { get; set; }= string.Empty;


        public mdl_Parcal()
        {
            sCl_descrip = string.Empty;
            sCl_espec = string.Empty;
            iCl_periodo = 0;
            sCl_tiponom = string.Empty;
            dtCl_fecini = new DateTime(1900, 1, 1, 0, 0, 0);
            dtCl_fecfin = new DateTime(1900, 1, 1, 0, 0, 0);
            dtCl_fecpago = new DateTime(1900, 1, 1, 0, 0, 0);
            fCl_numdias = 0.00m;
            fCl_diasims = 0.00m;
            iCl_numsem = 0;
            iCl_numquin = 0;
            sCl_isptmen = "N";
            sCl_isptanu = "N";
            sCl_ivalesalim = "N";
            iCl_control = 0;
            fCl_factor = 0.00m;
            iCl_mes = 0;
            dtCl_proceso = new DateTime(1900, 1, 1, 0, 0, 0);
            sCl_subinc = "N";
            fCl_ajuste = 0.00m;
            sCl_fahorro = "N";
            sCl_prevsoc = "N";
            dtCl_cdiavac = new DateTime(1900, 1, 1, 0, 0, 0);
            sCl_retrope = "N";
            dtCl_rifecha = new DateTime(1900, 1, 1, 0, 0, 0);
            dtCl_rffecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sCl_sdivar = "N";
            iCl_sucur = 0;
            sCl_turno = string.Empty;
            sCl_celula = string.Empty;
            sCl_grupo = string.Empty;
            iCl_ccosto = 0;
            iCl_nivel = 0;
            dtCl_afechai = new DateTime(1900, 1, 1, 0, 0, 0);
            dtCl_afechaf = new DateTime(1900, 1, 1, 0, 0, 0);
            bCl_calific = false;
            fCl_tcambio = 0.00m;
            iCl_sr_recno = 0;
            sCl_sr_deleted = string.Empty;
            dtCl_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sCl_sr_usuario = string.Empty;
            sCl_repnom = string.Empty;
        }
    }


    [BsonIgnoreExtraElements]
    public class mdl_PeriodoPar
    {
        [BsonElement("pe_cia")]
        public int iPe_cia { get; set; }

        [BsonElement("pe_sucur")]
        public int iPe_sucur { get; set; }

        [BsonElement("pe_mes")]
        public int iPe_mes { get; set; }

        [BsonElement("pe_numsem")]
        public int iPe_numsem { get; set; }

        [BsonElement("pe_numper")]
        public int iPe_numper { get; set; }

        [BsonElement("pe_dias")]
        public int iPe_dias { get; set; }

        [BsonElement("pe_pertip")]
        public string sPe_pertip { get; set; }

        [BsonElement("pe_fecini")]
        public DateTime dtPe_fecini { get; set; }

        [BsonElement("pe_fecfin")]
        public DateTime dtPe_fecfin { get; set; }

        [BsonElement("pe_sr_recno")]
        public long iPe_sr_recno { get; set; }

        [BsonElement("pe_sr_deleted")]
        public string sPe_sr_deleted { get; set; }

        [BsonElement("pe_sr_fecha")]
        public DateTime dtPe_sr_fecha { get; set; }

        [BsonElement("pe_sr_usuario")]
        public string sPe_sr_usuario { get; set; }

        public mdl_PeriodoPar()
        {
            iPe_cia = 0;
            iPe_sucur = 0;
            iPe_mes = 0;
            iPe_numsem = 0;
            iPe_numper = 0;
            iPe_dias = 0;
            sPe_pertip = string.Empty;
            dtPe_fecini = new DateTime(1900, 1, 1, 0, 0, 0);
            dtPe_fecfin = new DateTime(1900, 1, 1, 0, 0, 0);
            iPe_sr_recno = 0;
            sPe_sr_deleted = string.Empty;
            dtPe_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sPe_sr_usuario = string.Empty;
        }
    }
}
