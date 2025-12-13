using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;


namespace certinom_sadper_v1.Modelos.ColeccionesDB
{
    /*  Title: NEmpresa
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
        * Descripción:                                                                                                                    / The hiphop it's my RELIGION & GOD(YHWH) guides my steps.
        * 
        * Historial de cambios: 
        */

    [BsonIgnoreExtraElements]
    public class mdl_Empresa
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sId { get; set; } = string.Empty;

        [BsonElement("co_cia")]
        public int iCo_cia { get; set; }

        [BsonElement("co_calle")]
        public string sCo_calle { get; set; } = string.Empty;

        [BsonElement("co_colonia")]
        public string sCo_colonia { get; set; } = string.Empty;

        [BsonElement("co_ciudad")]
        public string sCo_ciudad { get; set; } = string.Empty;

        [BsonElement("co_estado")]
        public string sCo_estado { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("co_cp")]
        public string sCo_cp { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("co_rfc")]
        public string sCo_rfc { get; set; }

        //[Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("co_infona")]
        public string sCo_infona { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("co_imss")]
        public string sCo_imss { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("co_area")]
        public int iCo_area { get; set; }

        [Range(0, 99.99, ErrorMessage = "El porcentaje es incorrecto")]
        [BsonElement("co_ahorror"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCo_ahorror { get; set; }

        [Range(0, 99.99, ErrorMessage = "El porcentaje es incorrecto")]
        [BsonElement("co_ahorroa"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCo_ahorroa { get; set; }

        [Range(0, 99.99, ErrorMessage = "El porcentaje es incorrecto")]
        [BsonElement("co_cuotas"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCo_cuotas { get; set; }

        [BsonElement("co_sar"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCo_sar { get; set; }

        [BsonElement("co_cxp")]
        public string sCo_cxp { get; set; } = string.Empty;

        [BsonElement("co_prevsoc")]
        public string sCo_prevsoc { get; set; } = string.Empty;

        [BsonElement("co_factor"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCo_factor { get; set; }

        [Range(0, 10, ErrorMessage = "El porcentaje es incorrecto")]
        [BsonElement("co_impest"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCo_impest { get; set; }

        [BsonElement("co_impfed"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCo_impfed { get; set; }

        [BsonElement("co_impotro"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCo_impotro { get; set; }

        [Range(0, 99.99, ErrorMessage = "El porcentaje es incorrecto")]
        [BsonElement("co_ahosinr"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCo_ahosinr { get; set; }

        [Range(0, 99.99, ErrorMessage = "El porcentaje es incorrecto")]
        [BsonElement("co_ahosina"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCo_ahosina { get; set; }

        [Range(0, 5, ErrorMessage = "El porcentaje es incorrecto")]
        [BsonElement("co_pinfona"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCo_pinfona { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("co_legal")]
        public string sCo_legal { get; set; } = string.Empty;

        [BsonElement("co_telleg")]
        public string sCo_telleg { get; set; } = string.Empty;

        [BsonElement("co_rfcleg")]
        public string sCo_rfcleg { get; set; }

        [BsonElement("co_curpleg")]
        public string sCo_curpleg { get; set; } = string.Empty;

        [BsonElement("co_activi")]
        public string sCo_activi { get; set; } = string.Empty;

        [BsonElement("co_puerto")]
        public string sCo_puerto { get; set; } = string.Empty;

        [BsonElement("co_muser")]
        public string sCo_muser { get; set; } = string.Empty;

        [BsonElement("co_mpass")]
        public string sCo_mpass { get; set; } = string.Empty;

        [BsonElement("co_mserver")]
        public string sCo_mserver { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("co_rfiscal")]
        public string sCo_rfiscal { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("co_rpuesto")]
        public string sCo_rpuesto { get; set; } = string.Empty;

        [BsonElement("co_munici")]
        public string sCo_munici { get; set; } = string.Empty;

        [BsonElement("co_nomsat")]
        public string sCo_nomsat { get; set; } = string.Empty;

        [BsonElement("co_actividad")]
        public string sCo_actividad { get; set; } = string.Empty;

        //[Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("co_rfcsub")]
        public string sCo_rfcsub { get; set; } = string.Empty;


        [BsonElement("co_tiporg")]
        public string sCo_tiporg { get; set; } = string.Empty;

        [BsonElement("co_descripcion")]
        public string sCo_descripcion { get; set; } = string.Empty;

        [BsonElement("co_espromocion")]
        public bool bCo_espromocion { get; set; }

        [BsonElement("co_fechainipromo")]
        public DateTime dtCo_fechainipromo { get; set; }

        [BsonElement("co_fechafinpromo")]
        public DateTime dtCo_fechafinpromo { get; set; }

        [BsonElement("co_fechainicontratofijo")]
        public DateTime dtCo_fechainicontratofijo { get; set; }

        [BsonElement("co_fechafincontratofijo")]
        public DateTime dtCo_fechafincontratofijo { get; set; }


        [BsonElement("co_csdcliente", Order = 71)]
        public string sCSDCliente { get; set; } = string.Empty;

        [BsonElement("co_keycliente", Order = 72)]
        public string sKeyCliente { get; set; } = string.Empty;

        [BsonElement("co_csdfile", Order = 73)]
        public string sCSFile { get; set; } = string.Empty;

        [BsonElement("co_keyfile", Order = 74)]
        public string sKeyFile { get; set; } = string.Empty;

        [BsonElement("co_cerpass", Order = 75)]
        public string sCertificadoPass { get; set; } = string.Empty;

        [BsonElement("co_fechafincer", Order = 76)]
        public DateTime dtFechaFinCert { get; set; }





        [BsonElement("cerpass")]
        public string sCerpass { get; set; } = string.Empty;
        [BsonElement("filecer")]
        public string sFilecer { get; set; } = string.Empty;


        [BsonElement("fcerkey")]
        public string sFcerkey { get; set; } = string.Empty;

        [BsonElement("empresa")]
        public int iEmpresa { get; set; }

        [BsonElement("sucursal")]
        public int iSucursal { get; set; }

        [BsonElement("fielclave")]
        public string sFielclave { get; set; } = string.Empty;



        //*********************************************




        [BsonElement("fimgrfc")]
        public string sFimgrfc { get; set; } = string.Empty;

        [BsonElement("fimglogo")]
        public string sFimglogo { get; set; } = string.Empty;


        [BsonElement("numcer")]
        public string sNumcer { get; set; } = string.Empty;

        [BsonElement("fecauto")]
        public DateTime dtFecauto { get; set; }

        [BsonElement("fecsataut")]
        public string sFecsataut { get; set; } = string.Empty;

        [BsonElement("donataria")]
        public bool bDonataria { get; set; }

        [BsonElement("retail")]
        public bool bRetail { get; set; }

        [BsonElement("combustibl")]
        public bool bCombustibl { get; set; }

        [BsonElement("impulocale")]
        public bool bImpulocale { get; set; }

        [BsonElement("terceros")]
        public bool bTerceros { get; set; }

        [BsonElement("divisas")]
        public bool bDivisas { get; set; }

        [BsonElement("pacfd")]
        public bool bPacfd { get; set; }

        [BsonElement("rvoe")]
        public bool bRvoe { get; set; }

        [BsonElement("donafech")]
        public DateTime dtDonafech { get; set; }

        [BsonElement("actualizar")]
        public bool bActualizar { get; set; }

        [BsonElement("usuario")]
        public string sUsuario { get; set; } = string.Empty;

        [BsonElement("fecha")]
        public DateTime dtFecha { get; set; }

        [BsonElement("hora")]
        public string sHora { get; set; } = string.Empty;

        #region arreglos
        //definción de nareas
        [BsonElement("nareas")]
        public mdl_Area[] aNAreas { get; set; }

        //definción de nbancos
        [BsonElement("nbancos")]
        public mdl_Banco[] aNBancos { get; set; }

        //definición de ncelulas
        [BsonElement("ncelulas")]
        public mdl_Celula[] aNCelulas { get; set; }

        //definición de ndeptos
        /// <summary>
        /// Centros de Costo
        /// </summary>
        [BsonElement("ndeptos")]
        public mdl_Departamento[] aNDeptos { get; set; }

        //definicion de ndivisi
        [BsonElement("ndivisi")]
        public mdl_Division[] aNDivisi { get; set; }

        [BsonElement("nsucursa")]
        public mdl_Sucursal[] aNSucursa { get; set; }

        //definición de nfestivo
        [BsonElement("nfestivos")]
        public mdl_Festivo[] aNFestivos { get; set; }

        //definición de ngrupos
        [BsonElement("ngrupos")]
        public mdl_Grupo[] aNGrupos { get; set; }

        //definción de nniveles
        [BsonElement("nniveles")]
        public mdl_Nivel[] aNNiveles { get; set; }

        //definción de nperiodo
        [BsonElement("nperiodo")]
        public mdl_Periodo[] aNPeriodo { get; set; }


        //definición de npuestos
        [BsonElement("npuestos")]
        public mdl_Puesto[] aNPuestos { get; set; }

        //definición de nsemanas
        [BsonElement("nsemanas")]
        public mdl_Semana[] aNSemanas { get; set; }

        //definición de nsubgrp
        [BsonElement("nsubgrp")]
        public mdl_Grupo[] aNSubgrp { get; set; }

        //definición de nturnos
        [BsonElement("nturnos")]
        public mdl_Turno[] aNTurnos { get; set; }

        [BsonElement("nisranual")]
        public mdl_Impuestos[] aNIsrAnual { get; set; }

        [BsonElement("nisrmensual")]
        public mdl_Impuestos[] aNIsrMensual { get; set; }

        [BsonElement("nisrsubsidiomensual")]
        public mdl_Impuestos[] aNSubMensual { get; set; }

        [BsonElement("nisrquincenal")]
        public mdl_Impuestos[] aNIsrQuincenal { get; set; }

        [BsonElement("nisrsubsidioquincenal")]
        public mdl_Impuestos[] aNSubQuincenal { get; set; }

        [BsonElement("nisrcatorcenal")]
        public mdl_Impuestos[] aNIsrCatorcenal { get; set; }

        [BsonElement("nisrsubsidiocatorcenal")]
        public mdl_Impuestos[] aNSubCatorcenal { get; set; }

        [BsonElement("nisrsemanal")]
        public mdl_Impuestos[] aNIsrSemanal { get; set; }

        [BsonElement("nisrsubsidiosemanal")]
        public mdl_Impuestos[] aNSubSemanal { get; set; }

        [BsonElement("nisrdecenal")]
        public mdl_Impuestos[] aNIsrDecenal { get; set; }

        [BsonElement("nisrsubidiodecenal")]
        public mdl_Impuestos[] aNSubDecenal { get; set; }

        [BsonElement("nisrdiario")]
        public mdl_Impuestos[] aNIsrDiario { get; set; }

        [BsonElement("nisrsubsidiodiario")]
        public mdl_Impuestos[] aNSubDiario { get; set; }

        [BsonElement("ncuotasimss")]
        public mdl_CuotasImss[] aNCuotas { get; set; }

        [BsonElement("SADPER-INI")]
        public string sSADPER_INI { get; set; } = string.Empty;

        ///sadperini
        [BsonElement("sadperini")]
        public mdl_SadperIni[] aSadperIni { get; set; }

        [BsonElement("nminimos")]
        public mdl_Minimos[] aNMinimos { get; set; }

        [BsonElement("nbcausasimss")]
        public mdl_CausaBajaImss[] aNCausaImss { get; set; }

        [BsonElement("nbcausas")]
        public mdl_CausaBaja[] aNCausaBaja { get; set; }

        [BsonElement("nautorizaciones")]
        public mdl_Autorizaciones[] aNAutorizaciones { get; set; }

        [BsonElement("ncertifica")]
        public mdl_Certifica[] aNCertifica { get; set; }

        #endregion


        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; } = string.Empty;

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; } = string.Empty;

        //constructor
        public mdl_Empresa()
        {
            iCo_cia = 0;
            sCo_calle = string.Empty;
            sCo_colonia = string.Empty;
            sCo_ciudad = string.Empty;
            sCo_estado = string.Empty;
            sCo_cp = string.Empty;
            sCo_rfc = string.Empty;
            sCo_infona = string.Empty;
            sCo_imss = string.Empty;
            iCo_area = 0;
            fCo_ahorror = 0.0m;
            fCo_ahorroa = 0.0m;
            fCo_cuotas = 0.0m;
            fCo_sar = 0.0m;
            sCo_cxp = string.Empty;
            sCo_prevsoc = string.Empty;
            fCo_factor = 0.0m;
            fCo_impest = 0.0m;
            fCo_impfed = 0.0m;
            fCo_impotro = 0.0m;
            fCo_ahosinr = 0.0m;
            fCo_ahosina = 0.0m;
            fCo_pinfona = 0.0m;
            sCo_legal = string.Empty;
            sCo_telleg = string.Empty;
            sCo_rfcleg = string.Empty;
            sCo_curpleg = string.Empty;
            sCo_activi = string.Empty;
            sCo_puerto = string.Empty;
            sCo_muser = string.Empty;
            sCo_mpass = string.Empty;
            sCo_mserver = string.Empty;
            sCo_rfiscal = string.Empty;
            sCo_rpuesto = string.Empty;
            sCo_munici = string.Empty;
            sCo_nomsat = string.Empty;
            sCo_actividad = string.Empty;
            sCo_rfcsub = string.Empty;
            sCo_tiporg = string.Empty;
            sCo_descripcion = string.Empty;
            bCo_espromocion = false;
            dtCo_fechainicontratofijo = new DateTime(1900, 1, 1, 0, 0, 0);
            dtCo_fechafincontratofijo = new DateTime(1900, 1, 1, 0, 0, 0);
            dtCo_fechainipromo = new DateTime(1900, 1, 1, 0, 0, 0);
            dtCo_fechafinpromo = new DateTime(1900, 1, 1, 0, 0, 0);
            iEmpresa = 0;
            iSucursal = 0;
            sFielclave = string.Empty;
            sFilecer = string.Empty;
            sFcerkey = string.Empty;
            sFimgrfc = string.Empty;
            sFimglogo = string.Empty;
            sCerpass = string.Empty;
            sNumcer = string.Empty;
            dtFecauto = new DateTime(1900, 1, 1, 0, 0, 0);
            sFecsataut = string.Empty;
            bDonataria = false;
            bRetail = false;
            bCombustibl = false;
            bImpulocale = false;
            bTerceros = false;
            bDivisas = false;
            bPacfd = false;
            bRvoe = false;
            sSADPER_INI = string.Empty;
            dtDonafech = new DateTime(1900, 1, 1, 0, 0, 0);
            bActualizar = false;
            #region Arreglos
            aNAreas = Array.Empty<mdl_Area>();
            aNBancos = Array.Empty<mdl_Banco>();
            aNCelulas = Array.Empty<mdl_Celula>();
            aNDeptos = Array.Empty<mdl_Departamento>();
            aNDivisi = Array.Empty<mdl_Division>();
            aNSucursa = Array.Empty<mdl_Sucursal>();
            aNFestivos = Array.Empty<mdl_Festivo>();
            aNGrupos = Array.Empty<mdl_Grupo>();
            aNNiveles = Array.Empty<mdl_Nivel>();
            aNPeriodo = Array.Empty<mdl_Periodo>();
            aNPuestos = Array.Empty<mdl_Puesto>();
            aNSemanas = Array.Empty<mdl_Semana>();
            aNSubgrp = Array.Empty<mdl_Grupo>();
            aNTurnos = Array.Empty<mdl_Turno>();
            aNIsrAnual = Array.Empty<mdl_Impuestos>();
            aNIsrMensual = Array.Empty<mdl_Impuestos>();
            aNSubMensual = Array.Empty<mdl_Impuestos>();
            aNIsrQuincenal = Array.Empty<mdl_Impuestos>();
            aNSubQuincenal = Array.Empty<mdl_Impuestos>();
            aNIsrCatorcenal = Array.Empty<mdl_Impuestos>();
            aNSubCatorcenal = Array.Empty<mdl_Impuestos>();
            aNIsrSemanal = Array.Empty<mdl_Impuestos>();
            aNSubSemanal = Array.Empty<mdl_Impuestos>();
            aNIsrDecenal = Array.Empty<mdl_Impuestos>();
            aNSubDecenal = Array.Empty<mdl_Impuestos>();
            aNIsrDiario = Array.Empty<mdl_Impuestos>();
            aNSubDiario = Array.Empty<mdl_Impuestos>();
            aNCuotas = Array.Empty<mdl_CuotasImss>();
            aSadperIni = Array.Empty<mdl_SadperIni>();
            aNMinimos = Array.Empty<mdl_Minimos>();
            aNCausaImss = Array.Empty<mdl_CausaBajaImss>();
            aNCausaBaja = Array.Empty<mdl_CausaBaja>();
            aNAutorizaciones = Array.Empty<mdl_Autorizaciones>();
            aNCertifica = Array.Empty<mdl_Certifica>();
            #endregion




            sUsuario = string.Empty;
            dtFecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sHora = string.Empty;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sSr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// definición de nareas
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Area
    {

        [BsonElement("na_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sNa_id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El valor debe ser mayor a 0")]
        [BsonElement("na_numero")]
        public int? iNa_numero { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("na_descrip")]
        public string sNa_descrip { get; set; }

        [BsonElement("na_tiposnc")]
        public string sNa_tiposnc { get; set; }

        [BsonElement("na_sr_recno")]
        public long iNa_sr_recno { get; set; }

        [BsonElement("na_sr_deleted")]
        public string sNa_sr_deleted { get; set; }

        [BsonElement("na_sr_fecha")]
        public DateTime dtNa_sr_fecha { get; set; }

        [BsonElement("na_sr_usuario")]
        public string sNa_sr_usuario { get; set; }

        public mdl_Area()
        {
            sNa_id = ObjectId.GenerateNewId().ToString();
            iNa_numero = 0;
            sNa_descrip = string.Empty;
            sNa_tiposnc = string.Empty;
            iNa_sr_recno = 0;
            sNa_sr_deleted = "0";
            dtNa_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sNa_sr_usuario = string.Empty;

        }
    }

    /// <summary>
    /// definición de ncelulas
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Celula
    {
        [BsonElement("nc_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sNc_id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("nc_numero")]
        public string sNc_numero { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("nc_descrip")]
        public string sNc_descrip { get; set; }

        [BsonElement("nc_tiposnc")]
        public string sNc_tiposnc { get; set; }

        [BsonElement("na_sr_recno")]
        public long iNc_sr_recno { get; set; }

        [BsonElement("nc_sr_deleted")]
        public string sNc_sr_deleted { get; set; }

        [BsonElement("nc_sr_fecha")]
        public DateTime dtNc_sr_fecha { get; set; }

        [BsonElement("nc_sr_usuario")]
        public string sNc_sr_usuario { get; set; }

        public mdl_Celula()
        {
            sNc_id = ObjectId.GenerateNewId().ToString();
            sNc_numero = string.Empty;
            sNc_descrip = string.Empty;
            sNc_tiposnc = string.Empty;
            iNc_sr_recno = 0;
            sNc_sr_deleted = "0";
            dtNc_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sNc_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// Centros de costo, definición de ndptos
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Departamento
    {
        [BsonElement("cc_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sCc_id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El valor debe ser mayor a 0")]
        [BsonElement("cc_costo")]
        public int? ICc_costo { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("cc_nombre")]
        public string sCc_nombre { get; set; }

        [BsonElement("cc_cuenta")]
        public string sCc_cuenta { get; set; }

        [BsonElement("cc_numper")]
        public int iCc_numper { get; set; }

        [BsonElement("cc_plazas")]
        public int iCc_plazas { get; set; }

        [BsonElement("cc_head")]
        public int iCc_head { get; set; }

        [BsonElement("cc_prm01"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCc_prm01 { get; set; }

        [BsonElement("cc_prm02"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCc_prm02 { get; set; }

        [BsonElement("cc_prm03"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCc_prm03 { get; set; }

        [BsonElement("cc_prm04"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCc_prm04 { get; set; }

        [BsonElement("cc_prm05"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCc_prm05 { get; set; }

        [BsonElement("cc_prm06"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCc_prm06 { get; set; }

        [BsonElement("cc_prm07"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCc_prm07 { get; set; }

        [BsonElement("cc_prm08"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCc_prm08 { get; set; }

        [BsonElement("cc_prm09"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCc_prm09 { get; set; }

        [BsonElement("cc_prm10"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCc_prm10 { get; set; }

        [BsonElement("cc_prm11"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCc_prm11 { get; set; }

        [BsonElement("cc_prm12"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fCc_prm12 { get; set; }

        [BsonElement("cc_turno1")]
        public string sCc_turno1 { get; set; }

        [BsonElement("cc_turno2")]
        public string sCc_turno2 { get; set; }

        [BsonElement("cc_turno3")]
        public string sCc_turno3 { get; set; }

        [BsonElement("cc_turno4")]
        public string sCc_turno4 { get; set; }

        [BsonElement("pu_tipoemp")]
        public string sPu_tipoemp { get; set; }

        [BsonElement("cc_locaci")]
        public string sCc_locaci { get; set; }

        [BsonElement("cc_company")]
        public string sCc_company { get; set; }

        [BsonElement("cc_zona")]
        public string sCc_zona { get; set; }

        [BsonElement("cc_sede")]
        public string sCc_sede { get; set; }

        [BsonElement("cc_direc")]
        public string sCc_direc { get; set; }

        [BsonElement("cc_contac")]
        public string sCc_contac { get; set; }

        [BsonElement("cc_telcon")]
        public string sCc_telcon { get; set; }

        [BsonElement("cc_email")]
        public string sCc_email { get; set; }

        [BsonElement("cc_perfil")]
        public string sCc_perfil { get; set; }

        [BsonElement("cc_nomcor")]
        public string sCc_nomcor { get; set; }

        [BsonElement("cc_factorp"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fC_factorp { get; set; }

        [BsonElement("cc_tipo")]
        public string sCc_tipo { get; set; }

        [BsonElement("cc_sr_recno")]
        public long iCc_sr_recno { get; set; }

        [BsonElement("cc_sr_deleted")]
        public string sCc_sr_deleted { get; set; }

        [BsonElement("cc_sr_fecha")]
        public DateTime dtCc_sr_fecha { get; set; }

        [BsonElement("cc_sr_usuario")]
        public string sCc_sr_usuario { get; set; }

        //constructor
        public mdl_Departamento()
        {
            sCc_id = ObjectId.GenerateNewId().ToString();
            ICc_costo = 0;
            sCc_nombre = string.Empty;
            sCc_cuenta = string.Empty;
            iCc_numper = 0;
            iCc_plazas = 0;
            iCc_head = 0;
            fCc_prm01 = 0.0m;
            fCc_prm02 = 0.0m;
            fCc_prm03 = 0.0m;
            fCc_prm04 = 0.0m;
            fCc_prm05 = 0.0m;
            fCc_prm06 = 0.0m;
            fCc_prm07 = 0.0m;
            fCc_prm08 = 0.0m;
            fCc_prm09 = 0.0m;
            fCc_prm10 = 0.0m;
            fCc_prm11 = 0.0m;
            fCc_prm12 = 0.0m;
            sCc_turno1 = string.Empty;
            sCc_turno2 = string.Empty;
            sCc_turno3 = string.Empty;
            sCc_turno4 = string.Empty;
            sPu_tipoemp = string.Empty;
            sCc_locaci = string.Empty;
            sCc_company = string.Empty;
            sCc_zona = string.Empty;
            sCc_sede = string.Empty;
            sCc_direc = string.Empty;
            sCc_contac = string.Empty;
            sCc_telcon = string.Empty;
            sCc_email = string.Empty;
            sCc_perfil = string.Empty;
            sCc_nomcor = string.Empty;
            fC_factorp = 0.0m;
            sCc_tipo = string.Empty;
            iCc_sr_recno = 0;
            sCc_sr_deleted = "0";
            dtCc_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sCc_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// definición de ndivisi
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Division
    {
        [BsonElement("dv_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sDv_id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El valor debe ser mayor a 0")]
        [BsonElement("dv_direccion")]
        public int? iDv_direccion { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [BsonElement("dv_nombre")]
        public string sDv_nombre { get; set; }

        [BsonElement("dv_cuenta")]
        public string sDv_cuenta { get; set; }

        [BsonElement("dv_sr_recno")]
        public long iDv_sr_recno { get; set; }

        [BsonElement("dv_sr_deleted")]
        public string sDv_sr_deleted { get; set; }

        [BsonElement("dv_sr_fecha")]
        public DateTime dtDv_sr_fecha { get; set; }

        [BsonElement("dv_sr_usuario")]
        public string sDv_sr_usuario { get; set; }

        //constructor
        public mdl_Division()
        {
            sDv_id = ObjectId.GenerateNewId().ToString();
            iDv_direccion = 0;
            sDv_nombre = string.Empty;
            sDv_cuenta = string.Empty;
            iDv_sr_recno = 0;
            sDv_sr_deleted = "0";
            dtDv_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sDv_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// definicion de nsucursa
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Sucursal
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sId { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El valor debe ser mayor a 0")]
        [BsonElement("su_numero")]
        public int? iSu_numero { get; set; }

        [BsonElement("su_calle")]
        public string sSu_calle { get; set; }

        [BsonElement("su_colon")]
        public string sSu_colon { get; set; }

        [BsonElement("su_ciudad")]
        public string sSu_ciudad { get; set; }

        [BsonElement("su_estado")]
        public string sSu_estado { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("su_cp")]
        public string sSu_cp { get; set; }

        [BsonElement("su_zona")]
        public int iSu_zona { get; set; }

        [BsonElement("su_refer")]
        public string sSu_refer { get; set; }

        [BsonElement("su_edo"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSu_edo { get; set; }

        [BsonElement("su_impues"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSu_impues { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("su_imss")]
        public string sSu_imss { get; set; }

        [BsonElement("su_rfc")]
        public string sSu_rfc { get; set; }

        //[Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("su_infona")]
        public string sSu_infona { get; set; }

        [BsonElement("su_legal")]
        public string sSu_legal { get; set; }

        [BsonElement("su_fregtrab")]
        public DateTime? dtSu_fregtrab { get; set; }

        [BsonElement("su_rtimss"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSu_rtimss { get; set; }

        [BsonElement("su_pfaho"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSu_pfaho { get; set; }

        [BsonElement("su_efaho"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSu_efaho { get; set; }

        [BsonElement("su_psfaho"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSu_psfaho { get; set; }

        [BsonElement("su_esfaho"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSu_esfaho { get; set; }

        [BsonElement("su_sindi"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSu_sindi { get; set; }

        [BsonElement("su_cliente")]
        public string sSu_cliente { get; set; }

        [BsonElement("su_cuenta")]
        public string sSu_cuenta { get; set; }

        [BsonElement("su_banco")]
        public string sSu_banco { get; set; }

        [BsonElement("su_rfclega")]
        public string sSu_rfclega { get; set; }

        [BsonElement("su_curpleg")]
        public string sSu_curpleg { get; set; }

        [BsonElement("su_factor"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSu_factor { get; set; }

        [BsonElement("su_tasa"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSu_tasa { get; set; }

        [BsonElement("su_cia")]
        public int iSu_cia { get; set; }

        [BsonElement("su_suctra")]
        public bool bSu_suctra { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("su_rpuesto")]
        public string sSu_rpuesto { get; set; }

        [BsonElement("su_rfcsub")]
        public string sSu_rfcsub { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        public mdl_Sucursal()
        {
            sId = ObjectId.GenerateNewId().ToString();
            iSu_numero = 0;
            sSu_calle = string.Empty;
            sSu_colon = string.Empty;
            sSu_ciudad = string.Empty;
            sSu_estado = string.Empty;
            sSu_cp = string.Empty;
            iSu_zona = 0;
            sSu_refer = string.Empty;
            fSu_edo = 0.0m;
            fSu_impues = 0.0m;
            sSu_imss = string.Empty;
            sSu_rfc = string.Empty;
            sSu_infona = string.Empty;
            sSu_legal = string.Empty;
            dtSu_fregtrab = new DateTime(1900, 01, 01);
            fSu_rtimss = 0.0m;
            fSu_pfaho = 0.0m;
            fSu_efaho = 0.0m;
            fSu_psfaho = 0.0m;
            fSu_esfaho = 0.0m;
            fSu_sindi = 0.0m;
            sSu_cliente = string.Empty;
            sSu_cuenta = string.Empty;
            sSu_banco = string.Empty;
            sSu_rfclega = string.Empty;
            sSu_curpleg = string.Empty;
            fSu_factor = 0.0m;
            fSu_tasa = 0.0m;
            iSu_cia = 0;
            bSu_suctra = false;
            sSu_rpuesto = string.Empty;
            sSu_rfcsub = string.Empty;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sSr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// definición de nfestivo
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Festivo
    {
        [BsonElement("fe_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sFe_id { get; set; }

        [BsonElement("fe_todos")]
        public bool bFe_todos { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("fe_fecha")]
        public DateTime? dtFe_fecha { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("fe_descrip")]
        public string sFe_descrip { get; set; }

        [BsonElement("fe_tipoemp")]
        public string sFe_tipoemp { get; set; }

        [BsonElement("fe_tiponom")]
        public string sFe_tiponom { get; set; }

        [BsonElement("fe_tipocon")]
        public string sFe_tipocon { get; set; }

        [BsonElement("fe_tiposnc")]
        public string sFe_tiposnc { get; set; }

        [BsonElement("fe_sr_recno")]
        public long iFe_sr_recno { get; set; }

        [BsonElement("fe_sr_deleted")]
        public string sFe_sr_deleted { get; set; }

        [BsonElement("fe_sr_fecha")]
        public DateTime dtFe_sr_fecha { get; set; }

        [BsonElement("fe_sr_usuario")]
        public string sFe_sr_usuario { get; set; }
        //constructor
        public mdl_Festivo()
        {
            sFe_id = ObjectId.GenerateNewId().ToString();
            bFe_todos = false;
            dtFe_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sFe_descrip = string.Empty;
            sFe_tipoemp = string.Empty;
            sFe_tiponom = string.Empty;
            sFe_tipocon = string.Empty;
            sFe_tiposnc = string.Empty;
            iFe_sr_recno = 0;
            sFe_sr_deleted = "0";
            dtFe_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sFe_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// definición de ngrupos
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Grupo
    {
        [BsonElement("ng_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sNg_id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("ng_numero")]
        public string sNg_numero { get; set; }

        [BsonElement("ng_numant")]
        public string sNg_numant { get; set; }

        [BsonElement("ng_nextgrp")]
        public string sNg_nextgrp { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("ng_descrip")]
        public string sNg_descrip { get; set; }

        [BsonElement("ng_tiposnc")]
        public string sNg_tiposnc { get; set; }

        [BsonElement("ng_turno")]
        public string sNg_turno { get; set; }

        [BsonElement("ng_horas"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fNg_horas { get; set; }

        [BsonElement("ng_porpago"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fNg_porpago { get; set; }

        [BsonElement("ng_tippago")]
        public string sNg_tippago { get; set; }

        [BsonElement("hg_lunes")]
        public string sHg_lunes { get; set; }

        [BsonElement("ng_martes")]
        public string sNg_martes { get; set; }

        [BsonElement("ng_mierco")]
        public string sNg_mierco { get; set; }

        [BsonElement("ng_jueves")]
        public string sNg_jueves { get; set; }

        [BsonElement("ng_viernes")]
        public string sNg_viernes { get; set; }

        [BsonElement("ng_sabado")]
        public string sNg_sabado { get; set; }

        [BsonElement("ng_domingo")]
        public string sNg_domingo { get; set; }

        [BsonElement("ng_primdom")]
        public string sNg_primdom { get; set; }

        [BsonElement("ng_textrad")]
        public string sNg_textrad { get; set; }

        [BsonElement("ng_textrat")]
        public string sNg_textrat { get; set; }

        [BsonElement("ng_sr_recno")]
        public long iNg_sr_recno { get; set; }

        [BsonElement("ng_sr_deleted")]
        public string sNg_sr_deleted { get; set; }

        [BsonElement("ng_sr_fecha")]
        public DateTime dtNg_sr_fecha { get; set; }

        [BsonElement("ng_sr_usuario")]
        public string sNg_sr_usuario { get; set; }
        //constructor
        public mdl_Grupo()
        {
            sNg_id = ObjectId.GenerateNewId().ToString();
            sNg_numero = string.Empty;
            sNg_numant = string.Empty;
            sNg_nextgrp = string.Empty;
            sNg_descrip = string.Empty;
            sNg_tiposnc = string.Empty;
            sNg_turno = string.Empty;
            fNg_horas = 0.0m;
            fNg_porpago = 0.0m;
            sNg_tippago = string.Empty;
            sHg_lunes = string.Empty;
            sNg_martes = string.Empty;
            sNg_mierco = string.Empty;
            sNg_jueves = string.Empty;
            sNg_viernes = string.Empty;
            sNg_sabado = string.Empty;
            sNg_domingo = string.Empty;
            sNg_primdom = string.Empty;
            sNg_textrad = string.Empty;
            sNg_textrat = string.Empty;
            iNg_sr_recno = 0;
            sNg_sr_deleted = "0";
            dtNg_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sNg_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// definición de npuestos
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Puesto
    {

        [BsonElement("pu_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sPu_id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El valor debe ser mayor a 0")]
        [BsonElement("pu_numero")]
        public int? iPu_numero { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [BsonElement("pu_nombre")]
        public string sPu_nombre { get; set; }

        [BsonElement("pu_sueldo"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPu_sueldo { get; set; }

        [BsonElement("pu_minimo"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPu_minimo { get; set; }

        [BsonElement("pu_media"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPu_media { get; set; }

        [BsonElement("pu_propor"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPu_propor { get; set; }

        [BsonElement("pu_maximo"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPu_maximo { get; set; }

        [BsonElement("pu_sueldo_dia"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPu_sueldo_dia { get; set; }

        [BsonElement("pu_nivel")]
        public int iPu_nivel { get; set; }

        [BsonElement("pu_plazas")]
        public int iPu_plazas { get; set; }

        [BsonElement("pu_head")]
        public int iPu_head { get; set; }

        [BsonElement("pu_reporta")]
        public int iPu_reporta { get; set; }

        [BsonElement("pu_dreport")]
        public string sPu_dreport { get; set; }

        [BsonElement("pu_persona")]
        public int iPu_persona { get; set; }

        [BsonElement("pu_localiz")]
        public string sPu_localiz { get; set; }

        [BsonElement("pu_puntos")]
        public string sPu_puntos { get; set; }

        [BsonRepresentation(BsonType.Binary)]
        [BsonElement("pu_perfil")]
        public byte[] ayPu_perfil { get; set; }

        [BsonRepresentation(BsonType.Binary)]
        [BsonElement("pu_coorin")]
        public byte[] ayPu_coorin { get; set; }

        [BsonRepresentation(BsonType.Binary)]
        [BsonElement("pu_coorout")]
        public byte[] ayPu_coorout { get; set; }

        [BsonRepresentation(BsonType.Binary)]
        [BsonElement("pu_respon")]
        public byte[] ayPu_respon { get; set; }

        [BsonElement("pu_f01")]
        public int iPu_f01 { get; set; }

        [BsonElement("pu_f02")]
        public int iPu_f02 { get; set; }

        [BsonElement("pu_f03")]
        public int iPu_f03 { get; set; }

        [BsonElement("pu_f04")]
        public int iPu_f04 { get; set; }

        [BsonElement("pu_f05")]
        public int iPu_f05 { get; set; }

        [BsonElement("pu_f06")]
        public int iPu_f06 { get; set; }

        [BsonElement("pu_f07")]
        public int iPu_f07 { get; set; }

        [BsonElement("pu_f08")]
        public int iPu_f08 { get; set; }

        [BsonElement("pu_f09")]
        public int iPu_f09 { get; set; }

        [BsonElement("pu_f10")]
        public int iPu_f10 { get; set; }

        [BsonElement("pu_f11")]
        public int iPu_f11 { get; set; }

        [BsonElement("pu_f12")]
        public int iPu_f12 { get; set; }

        [BsonElement("pu_peso")]
        public int iPu_peso { get; set; }

        [BsonElement("pu_tipoemp")]
        public string sPu_tipoemp { get; set; }

        [BsonElement("pu_netogua"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPu_netogua { get; set; }

        [BsonElement("pu_netobgu"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPu_netobgu { get; set; }

        [BsonElement("pu_adianet"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPu_adianet { get; set; }

        [BsonElement("pu_bdianet"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPu_bdianet { get; set; }

        [BsonElement("pu_sr_recno")]
        public long iPu_sr_recno { get; set; }

        [BsonElement("pu_sr_deleted")]
        public string sPu_sr_deleted { get; set; }

        [BsonElement("pu_sr_fecha")]
        public DateTime dtPu_sr_fecha { get; set; }

        [BsonElement("pu_sr_usuario")]
        public string sPu_sr_usuario { get; set; }

        // Constructor para inicializar las propiedades con los valores predeterminados
        public mdl_Puesto()
        {
            sPu_id = ObjectId.GenerateNewId().ToString();
            iPu_numero = 0;
            sPu_nombre = string.Empty;
            fPu_sueldo = 0;
            fPu_minimo = 0;
            fPu_media = 0;
            fPu_propor = 0;
            fPu_maximo = 0;
            fPu_sueldo_dia = 0;
            iPu_nivel = 0;
            iPu_plazas = 0;
            iPu_head = 0;
            iPu_reporta = 0;
            sPu_dreport = string.Empty;
            iPu_persona = 0;
            sPu_localiz = string.Empty;
            sPu_puntos = string.Empty;
            ayPu_perfil = Array.Empty<byte>();
            ayPu_coorin = Array.Empty<byte>();
            ayPu_coorout = Array.Empty<byte>();
            ayPu_respon = Array.Empty<byte>();
            iPu_f01 = 0;
            iPu_f02 = 0;
            iPu_f03 = 0;
            iPu_f04 = 0;
            iPu_f05 = 0;
            iPu_f06 = 0;
            iPu_f07 = 0;
            iPu_f08 = 0;
            iPu_f09 = 0;
            iPu_f10 = 0;
            iPu_f11 = 0;
            iPu_f12 = 0;
            iPu_peso = 0;
            sPu_tipoemp = string.Empty;
            fPu_netogua = 0;
            fPu_netobgu = 0;
            fPu_adianet = 0;
            fPu_bdianet = 0;
            iPu_sr_recno = 0;
            sPu_sr_deleted = "0";
            dtPu_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sPu_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// definición de nsemanas
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Semana
    {
        [BsonElement("em_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sEm_id { get; set; }

        [BsonElement("em_semana")]
        public int iEm_semana { get; set; }

        [BsonElement("em_mes")]
        public string sEm_mes { get; set; }

        [BsonElement("em_fecini")]
        public DateTime dtEm_fecini { get; set; }

        [BsonElement("em_fecfin")]
        public DateTime dtEm_fecfin { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        //constructor
        public mdl_Semana()
        {
            sEm_id = ObjectId.GenerateNewId().ToString();
            iEm_semana = 0;
            sEm_mes = string.Empty;
            dtEm_fecini = new DateTime(1900, 1, 1, 0, 0, 0);
            dtEm_fecfin = new DateTime(1900, 1, 1, 0, 0, 0);
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sSr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// definición de nturnos
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Turno
    {
        [BsonElement("tu_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sTu_id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("tu_numero")]
        public string sTu_numero { get; set; }

        [BsonElement("tu_horas"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fTu_horas { get; set; }

        [BsonElement("tu_reloj")]
        public int iTu_reloj { get; set; }

        [BsonElement("tu_depto")]
        public int iTu_depto { get; set; }

        [BsonElement("tu_entra"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fTu_entra { get; set; }

        [BsonElement("tu_tole1"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fTu_tole1 { get; set; }

        [BsonElement("tu_salec"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fTu_salec { get; set; }

        [BsonElement("tu_entrac"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fTu_entrac { get; set; }

        [BsonElement("tu_tole2"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fTu_tole2 { get; set; }

        [BsonElement("tu_ante1"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fTu_ante1 { get; set; }

        [BsonElement("tu_ante2"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fTu_ante2 { get; set; }

        [BsonElement("tu_ante3"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fTu_ante3 { get; set; }

        [BsonElement("tu_ante4"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fTu_ante4 { get; set; }

        [BsonElement("tu_despu1"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fTu_despu1 { get; set; }

        [BsonElement("tu_despu2"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fTu_despu2 { get; set; }

        [BsonElement("tu_despu3"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fTu_despu3 { get; set; }

        [BsonElement("tu_despu4"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fTu_despu4 { get; set; }

        [BsonElement("tu_extras")]
        public int iTu_extras { get; set; }

        [BsonElement("tu_autoriz")]
        public bool bTu_autoriz { get; set; }

        [BsonElement("tu_labora")]
        public string sTu_labora { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [BsonElement("tu_descrip")]
        public string sTu_descrip { get; set; }

        [BsonElement("tu_entrada")]
        public string sTu_entrada { get; set; }

        [BsonElement("tu_salcom")]
        public string sTu_salcom { get; set; }

        [BsonElement("tu_entcom")]
        public string sTu_entcom { get; set; }

        [BsonElement("tu_salida")]
        public string sTu_salida { get; set; }

        [BsonElement("tu_jornal")]
        public int iTu_jornal { get; set; }

        [BsonElement("tu_12x12h")]
        public bool bTu_12x12h { get; set; }

        [BsonElement("tu_24x24h")]
        public bool bTu_24x24h { get; set; }

        [BsonElement("tu_28x14d")]
        public bool bTu_28x14d { get; set; }

        [BsonElement("tu_28x28d")]
        public bool bTu_28x28d { get; set; }

        [BsonElement("tu_56x28d")]
        public bool bTu_56x28d { get; set; }

        [BsonElement("tu_lunes")]
        public bool bTu_lunes { get; set; }

        [BsonElement("tu_martes")]
        public bool bTu_martes { get; set; }

        [BsonElement("tu_mierco")]
        public bool bTu_mierco { get; set; }

        [BsonElement("tu_jueves")]
        public bool bTu_jueves { get; set; }

        [BsonElement("tu_viernes")]
        public bool bTu_viernes { get; set; }

        [BsonElement("tu_sabado")]
        public bool bTu_sabado { get; set; }

        [BsonElement("tu_domingo")]
        public bool bTu_domingo { get; set; }

        [BsonElement("tu_sr_recno")]
        public long iTu_sr_recno { get; set; }

        [BsonElement("tu_sr_deleted")]
        public string sTu_sr_deleted { get; set; }

        [BsonElement("tu_sr_fecha")]
        public DateTime dtTu_sr_fecha { get; set; }

        [BsonElement("tu_sr_usuario")]
        public string sTu_sr_usuario { get; set; }

        public mdl_Turno()
        {
            sTu_id = ObjectId.GenerateNewId().ToString();
            sTu_numero = string.Empty;
            fTu_horas = 0.0m;
            iTu_reloj = 0;
            iTu_depto = 0;
            fTu_entra = 0.0m;
            fTu_tole1 = 0.0m;
            fTu_salec = 0.0m;
            fTu_entrac = 0.0m;
            fTu_tole2 = 0.0m;
            fTu_ante1 = 0.0m;
            fTu_ante2 = 0.0m;
            fTu_ante3 = 0.0m;
            fTu_ante4 = 0.0m;
            fTu_despu1 = 0.0m;
            fTu_despu2 = 0.0m;
            fTu_despu3 = 0.0m;
            fTu_despu4 = 0.0m;
            iTu_extras = 0;
            bTu_autoriz = false;
            sTu_labora = string.Empty;
            sTu_descrip = string.Empty;
            sTu_entrada = string.Empty;
            sTu_salcom = string.Empty;
            sTu_entcom = string.Empty;
            sTu_salida = string.Empty;
            iTu_jornal = 0;
            bTu_12x12h = false;
            bTu_24x24h = false;
            bTu_28x14d = false;
            bTu_28x28d = false;
            bTu_56x28d = false;
            bTu_lunes = false;
            bTu_martes = false;
            bTu_mierco = false;
            bTu_jueves = false;
            bTu_viernes = false;
            bTu_sabado = false;
            bTu_domingo = false;
            iTu_sr_recno = 0;
            sTu_sr_deleted = "0";
            dtTu_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sTu_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// definición de nbancos
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Banco
    {
        [BsonElement("bc_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sBc_id { get; set; }

        [BsonElement("bc_numero")]
        public int iBc_numero { get; set; }

        [BsonElement("bc_nombre")]
        public string sBc_nombre { get; set; }

        [BsonElement("bc_archivo")]
        public string sBc_archivo { get; set; }

        [BsonElement("bc_formato")]
        public string sBc_formato { get; set; }

        [BsonElement("bc_tipo")]
        public string sBc_tipo { get; set; }

        [BsonElement("bc_config")]
        public string sBc_config { get; set; }

        [BsonElement("bc_sucursa")]
        public string sBc_sucursa { get; set; }

        [BsonElement("bc_recep")]
        public string sBc_recep { get; set; }

        [BsonElement("bc_otorga")]
        public string sBc_otorga { get; set; }

        [BsonElement("bc_sentido")]
        public string sBc_sentido { get; set; }

        [BsonElement("bc_totcias")]
        public int iBc_totcias { get; set; }

        [BsonElement("bc_servici")]
        public int iBc_servici { get; set; }

        [BsonElement("bc_tipomov")]
        public string sBc_tipomov { get; set; }

        [BsonElement("bc_procede")]
        public int iBc_procede { get; set; }

        [BsonElement("bc_plaza")]
        public int iBc_plaza { get; set; }

        [BsonElement("bc_divisa")]
        public int iBc_divisa { get; set; }

        [BsonElement("bc_numemp")]
        public int iBc_numemp { get; set; }

        [BsonElement("bc_famili")]
        public int iBc_famili { get; set; }

        [BsonElement("bc_sucemp")]
        public string sBc_sucemp { get; set; }

        [BsonElement("bc_ctaemp")]
        public string sBc_ctaemp { get; set; }

        [BsonElement("bc_nempres")]
        public int iBc_nempres { get; set; }

        [BsonElement("bc_rutadkt")]
        public string sBc_rutadkt { get; set; }

        [BsonElement("bc_numban")]
        public int iBc_numban { get; set; }

        [BsonElement("bc_sr_recno")]
        public long iBc_sr_recno { get; set; }

        [BsonElement("bc_sr_deleted")]
        public string sBc_sr_deleted { get; set; }

        [BsonElement("bc_sr_fecha")]
        public DateTime dtBc_sr_fecha { get; set; }

        [BsonElement("bc_sr_usuario")]
        public string sBc_sr_usuario { get; set; }

        public mdl_Banco()
        {
            sBc_id = ObjectId.GenerateNewId().ToString();
            iBc_numero = 0;
            sBc_nombre = string.Empty;
            sBc_archivo = string.Empty;
            sBc_formato = string.Empty;
            sBc_tipo = string.Empty;
            sBc_config = string.Empty;
            sBc_sucursa = string.Empty;
            sBc_recep = string.Empty;
            sBc_otorga = string.Empty;
            sBc_sentido = string.Empty;
            iBc_totcias = 0;
            iBc_servici = 0;
            sBc_tipomov = string.Empty;
            iBc_procede = 0;
            iBc_plaza = 0;
            iBc_divisa = 0;
            iBc_numemp = 0;
            iBc_famili = 0;
            sBc_sucemp = string.Empty;
            sBc_ctaemp = string.Empty;
            iBc_nempres = 0;
            sBc_rutadkt = string.Empty;
            iBc_numban = 0;
            iBc_sr_recno = 0;
            sBc_sr_deleted = "0";
            dtBc_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sBc_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// definición de nnivel
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Nivel
    {
        [BsonElement("ni_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sNi_id { get; set; }

        [BsonElement("ni_numero")]
        public int iNi_numero { get; set; }

        [BsonElement("ni_nombre")]
        public string sNi_nombre { get; set; }

        [BsonElement("ni_sueldo"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fNi_sueldo { get; set; }

        [BsonElement("ni_tipemp")]
        public string sNi_tipemp { get; set; }

        [BsonElement("ni_contra"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fNi_contra { get; set; }

        [BsonElement("ni_q0min"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fNi_q0min { get; set; }

        [BsonElement("ni_q1min"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fNi_q1min { get; set; }

        [BsonElement("ni_q2med"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fNi_q2med { get; set; }

        [BsonElement("ni_q3pro"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fNi_q3pro { get; set; }

        [BsonElement("ni_q4max"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fNi_q4max { get; set; }

        [BsonElement("ni_sr_recno")]
        public long iNi_sr_recno { get; set; }

        [BsonElement("ni_sr_deleted")]
        public string sNi_sr_deleted { get; set; }

        [BsonElement("ni_sr_fecha")]
        public DateTime dtNi_sr_fecha { get; set; }

        [BsonElement("ni_sr_usuario")]
        public string sNi_sr_usuario { get; set; }

        public mdl_Nivel()
        {
            sNi_id = ObjectId.GenerateNewId().ToString();
            iNi_numero = 0;
            sNi_nombre = string.Empty;
            fNi_sueldo = 0.0m;
            sNi_tipemp = string.Empty;
            fNi_contra = 0.0m;
            fNi_q0min = 0.0m;
            fNi_q1min = 0.0m;
            fNi_q2med = 0.0m;
            fNi_q3pro = 0.0m;
            fNi_q4max = 0.0m;
            iNi_sr_recno = 0;
            sNi_sr_deleted = "0";
            dtNi_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sNi_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// definición de nperiodo
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Periodo
    {
        [BsonElement("pe_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sPe_id { get; set; }

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

        public mdl_Periodo()
        {
            sPe_id = ObjectId.GenerateNewId().ToString();
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
            sPe_sr_deleted = "0";
            dtPe_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sPe_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// definición de 
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Impuestos
    {
        [BsonElement("is_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sIs_id { get; set; }

        [BsonElement("tipo")]
        public string sTipo { get; set; }

        [BsonElement("renglon")]
        public int iRenglon { get; set; }

        [BsonElement("inferior"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fInferior { get; set; }

        [BsonElement("superior"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSuperior { get; set; }

        [BsonElement("fija"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fFija { get; set; }

        [BsonElement("porcentaje"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fPorcentaje { get; set; }

        [BsonElement("fecha_vig")]
        public DateTime? dtFecha_vig { get; set; }

        [BsonElement("is_fvigini")]
        public DateTime? dtIs_fvigini { get; set; }

        [BsonElement("is_fvigfin")]
        public DateTime? dtIs_fvigfin { get; set; }

        [BsonElement("is_sr_recno")]
        public long iIs_sr_recno { get; set; }

        [BsonElement("is_sr_deleted")]
        public string sIs_sr_deleted { get; set; }

        [BsonElement("is_sr_fecha")]
        public DateTime dtIs_sr_fecha { get; set; }

        [BsonElement("is_sr_usuario")]
        public string sIs_sr_usuario { get; set; }
        public mdl_Impuestos()
        {
            sIs_id = ObjectId.GenerateNewId().ToString();
            sTipo = string.Empty;
            iRenglon = 0;
            fInferior = 0.00m;
            fSuperior = 0.00m;
            fFija = 0.00m;
            fPorcentaje = 0.000000m;
            dtFecha_vig = new DateTime(1900, 1, 1, 0, 0, 0);
            dtIs_fvigini = new DateTime(1900, 1, 1, 0, 0, 0);
            dtIs_fvigfin = new DateTime(1900, 1, 1, 0, 0, 0);
            iIs_sr_recno = 0;
            sIs_sr_deleted = "0";
            dtIs_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sIs_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// definición de nminimos
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Minimos
    {
        [BsonElement("mi_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sMi_id { get; set; }

        [BsonElement("zona")]
        public int iZona { get; set; }

        [BsonElement("desde")]
        public DateTime? dtDesde { get; set; }

        [BsonElement("hasta")]
        public DateTime? dtHasta { get; set; }

        [BsonElement("diario"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fDiario { get; set; }

        [BsonElement("anual"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fAnual { get; set; }

        [BsonElement("tope"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fTope { get; set; }

        [BsonElement("mi_diaant"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fMi_diaant { get; set; }

        [BsonElement("mi_locali")]
        public string sMi_locali { get; set; }

        [BsonElement("mi_abc")]
        public string sMi_abc { get; set; }

        //Adicion

        [BsonElement("uma"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fUma { get; set; }

        [BsonElement("umainfona"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fUmainfona { get; set; }

        [BsonElement("uma_anterior"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fUma_anterior { get; set; }

        [BsonElement("umainfona_anterior"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fUmainfona_anterior { get; set; }

        [BsonElement("mi_sr_recno")]
        public long iMi_sr_recno { get; set; }

        [BsonElement("mi_sr_deleted")]
        public string sMi_sr_deleted { get; set; }

        [BsonElement("mi_sr_fecha")]
        public DateTime dtMi_sr_fecha { get; set; }

        [BsonElement("mi_sr_usuario")]
        public string sMi_sr_usuario { get; set; }

        public mdl_Minimos()
        {
            sMi_id = ObjectId.GenerateNewId().ToString();
            iZona = 0;
            dtDesde = new DateTime(1900, 1, 1, 0, 0, 0);
            dtHasta = new DateTime(1900, 1, 1, 0, 0, 0);
            fDiario = 0.00m;
            fAnual = 0.00m;
            fTope = 0.00m;
            fMi_diaant = 0.00m;
            sMi_locali = string.Empty;
            sMi_abc = string.Empty;
            fUma = 0.00m;
            fUmainfona = 0.00m;
            fUma_anterior = 0.00m;
            fUmainfona_anterior = 0.00m;
            iMi_sr_recno = 0;
            sMi_sr_deleted = "0";
            dtMi_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sMi_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// definción de ncuotasimss
    /// </summary>

    [BsonIgnoreExtraElements]
    public class mdl_CuotasImss
    {
        [BsonElement("ss_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sSs_id { get; set; }

        [BsonElement("ss_prt"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_prt { get; set; }

        [BsonElement("ss_peymcf"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_peymcf { get; set; }

        [BsonElement("ss_peyme3s"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_peyme3s { get; set; }

        [BsonElement("ss_peympd"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_peympd { get; set; }

        [BsonElement("ss_peymgm"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_peymgm { get; set; }

        [BsonElement("ss_piv"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_piv { get; set; }

        [BsonElement("ss_psar"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_psar { get; set; }

        [BsonElement("ss_pcyv"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_pcyv { get; set; }

        [BsonElement("ss_pguar"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_pguar { get; set; }

        [BsonElement("ss_pinfo"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_pinfo { get; set; }

        [BsonElement("ss_oeyme3s"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_oeyme3s { get; set; }

        [BsonElement("ss_oeympd"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_oeympd { get; set; }

        [BsonElement("ss_oeymgm"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_oeymgm { get; set; }

        [BsonElement("ss_oiv"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_oiv { get; set; }

        [BsonElement("ss_ocyv"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_ocyv { get; set; }

        [BsonElement("ss_penfmat"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_penfmat { get; set; }

        [BsonElement("ss_pinvali"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_pinvali { get; set; }

        [BsonElement("ss_guarde"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_guarde { get; set; }

        [BsonElement("ss_riesgo"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_riesgo { get; set; }

        [BsonElement("ss_pretiro"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_pretiro { get; set; }

        [BsonElement("ss_pcesant"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_pcesant { get; set; }

        [BsonElement("ss_oenfmat"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_oenfmat { get; set; }

        [BsonElement("ss_oinvali"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_oinvali { get; set; }

        [BsonElement("ss_oretiro"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_oretiro { get; set; }

        [BsonElement("ss_ocesant"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_ocesant { get; set; }

        [BsonElement("ss_lem"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_lem { get; set; }

        [BsonElement("ss_livcm"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_livcm { get; set; }

        [BsonElement("ss_lgu"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_lgu { get; set; }

        [BsonElement("ss_lrt"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_lrt { get; set; }

        [BsonElement("ss_lsar"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_lsar { get; set; }

        [BsonElement("ss_linfona"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_linfona { get; set; }

        [BsonElement("ss_bimi1")]
        public DateTime dtSs_bimi1 { get; set; }

        [BsonElement("ss_bimf1")]
        public DateTime dtSs_bimf1 { get; set; }

        [BsonElement("ss_bimi2")]
        public DateTime dtSs_bimi2 { get; set; }

        [BsonElement("ss_bimf2")]
        public DateTime dtSs_bimf2 { get; set; }

        [BsonElement("ss_bimi3")]
        public DateTime dtSs_bimi3 { get; set; }

        [BsonElement("ss_bimf3")]
        public DateTime dtSs_bimf3 { get; set; }

        [BsonElement("ss_bimi4")]
        public DateTime dtSs_bimi4 { get; set; }

        [BsonElement("ss_bimf4")]
        public DateTime dtSs_bimf4 { get; set; }

        [BsonElement("ss_bimi5")]
        public DateTime dtSs_bimi5 { get; set; }

        [BsonElement("ss_bimf5")]
        public DateTime dtSs_bimf5 { get; set; }

        [BsonElement("ss_bimi6")]
        public DateTime dtSs_bimi6 { get; set; }

        [BsonElement("ss_bimf6")]
        public DateTime dtSs_bimf6 { get; set; }

        [BsonElement("ss_diabim1")]
        public int iSs_diabim1 { get; set; }

        [BsonElement("ss_diabim2")]
        public int iSs_diabim2 { get; set; }

        [BsonElement("ss_diabim3")]
        public int iSs_diabim3 { get; set; }

        [BsonElement("ss_diabim4")]
        public int iSs_diabim4 { get; set; }

        [BsonElement("ss_diabim5")]
        public int iSs_diabim5 { get; set; }

        [BsonElement("ss_diabim6")]
        public int iSs_diabim6 { get; set; }

        [BsonElement("ss_sdimin"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_sdimin { get; set; }

        [BsonElement("ss_cvanio")]
        public int iSs_cvanio { get; set; }

        [BsonElement("ss_cv1sm"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_cv1sm { get; set; }

        [BsonElement("ss_cv101um"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_cv101um { get; set; }

        [BsonElement("ss_cv15uma"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_cv15uma { get; set; }

        [BsonElement("ss_cv2uma"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_cv2uma { get; set; }

        [BsonElement("ss_cv25uma"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_cv25uma { get; set; }

        [BsonElement("ss_cv3uma"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_cv3uma { get; set; }

        [BsonElement("ss_cv35uma"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_cv35uma { get; set; }

        [BsonElement("ss_cv4uma"), BsonRepresentation(BsonType.Decimal128)]
        public decimal fSs_cv4uma { get; set; }

        [BsonElement("ss_sr_recno")]
        public long iSs_sr_recno { get; set; }

        [BsonElement("ss_sr_deleted")]
        public string sSs_sr_deleted { get; set; }

        [BsonElement("ss_sr_fecha")]
        public DateTime dtSs_sr_fecha { get; set; }

        [BsonElement("ss_sr_usuario")]
        public string sSs_sr_usuario { get; set; }

        public mdl_CuotasImss()
        {
            sSs_id = ObjectId.GenerateNewId().ToString();
            fSs_prt = 0.0m;
            fSs_peymcf = 0.0m;
            fSs_peyme3s = 0.0m;
            fSs_peympd = 0.0m;
            fSs_peymgm = 0.0m;
            fSs_piv = 0.0m;
            fSs_psar = 0.0m;
            fSs_pcyv = 0.0m;
            fSs_pguar = 0.0m;
            fSs_pinfo = 0.0m;
            fSs_oeyme3s = 0.0m;
            fSs_oeympd = 0.0m;
            fSs_oeymgm = 0.0m;
            fSs_oiv = 0.0m;
            fSs_ocyv = 0.0m;
            fSs_penfmat = 0.0m;
            fSs_pinvali = 0.0m;
            fSs_guarde = 0.0m;
            fSs_riesgo = 0.0m;
            fSs_pretiro = 0.0m;
            fSs_pcesant = 0.0m;
            fSs_oenfmat = 0.0m;
            fSs_oinvali = 0.0m;
            fSs_oretiro = 0.0m;
            fSs_ocesant = 0.0m;
            fSs_lem = 0.0m;
            fSs_livcm = 0.0m;
            fSs_lgu = 0.0m;
            fSs_lrt = 0.0m;
            fSs_lsar = 0.0m;
            fSs_linfona = 0.0m;
            dtSs_bimi1 = DateTime.MinValue;
            dtSs_bimf1 = DateTime.MinValue;
            dtSs_bimi2 = DateTime.MinValue;
            dtSs_bimf2 = DateTime.MinValue;
            dtSs_bimi3 = DateTime.MinValue;
            dtSs_bimf3 = DateTime.MinValue;
            dtSs_bimi4 = DateTime.MinValue;
            dtSs_bimf4 = DateTime.MinValue;
            dtSs_bimi5 = DateTime.MinValue;
            dtSs_bimf5 = DateTime.MinValue;
            dtSs_bimi6 = DateTime.MinValue;
            dtSs_bimf6 = DateTime.MinValue;
            iSs_diabim1 = 0;
            iSs_diabim2 = 0;
            iSs_diabim3 = 0;
            iSs_diabim4 = 0;
            iSs_diabim5 = 0;
            iSs_diabim6 = 0;
            fSs_sdimin = 0.0m;
            iSs_cvanio = 0;
            fSs_cv1sm = 0.0m;
            fSs_cv101um = 0.0m;
            fSs_cv15uma = 0.0m;
            fSs_cv2uma = 0.0m;
            fSs_cv25uma = 0.0m;
            fSs_cv3uma = 0.0m;
            fSs_cv35uma = 0.0m;
            fSs_cv4uma = 0.0m;
            iSs_sr_recno = 0;
            sSs_sr_deleted = "0";
            dtSs_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sSs_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// definción de nbcausasimss
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_CausaBajaImss
    {
        [BsonElement("nb_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sNb_id { get; set; }

        [BsonElement("nb_causai")]
        public string sNb_causai { get; set; }

        [BsonElement("nb_descim")]
        public string sNb_descim { get; set; }

        [BsonElement("nb_sr_recno")]
        public long iNb_sr_recno { get; set; }

        [BsonElement("nb_sr_deleted")]
        public string sNb_sr_deleted { get; set; }

        [BsonElement("nb_sr_fecha")]
        public DateTime dtNb_sr_fecha { get; set; }

        [BsonElement("nb_sr_usuario")]
        public string sNb_sr_usuario { get; set; }

        public mdl_CausaBajaImss()
        {
            sNb_id = ObjectId.GenerateNewId().ToString();
            sNb_causai = string.Empty;
            sNb_descim = string.Empty;
            iNb_sr_recno = 0;
            sNb_sr_deleted = "0";
            dtNb_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sNb_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// definción de nbcausas
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_CausaBaja
    {
        [BsonElement("nb_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sNb_id { get; set; }

        [BsonElement("nb_causa")]
        public string sNb_causa { get; set; }

        [BsonElement("nb_descrip")]
        public string sNb_descrip { get; set; }

        [BsonElement("nb_sr_recno")]
        public long iNb_sr_recno { get; set; }

        [BsonElement("nb_sr_deleted")]
        public string sNb_sr_deleted { get; set; }

        [BsonElement("nb_sr_fecha")]
        public DateTime dtNb_sr_fecha { get; set; }

        [BsonElement("nb_sr_usuario")]
        public string sNb_sr_usuario { get; set; }
        public mdl_CausaBaja()
        {
            sNb_id = ObjectId.GenerateNewId().ToString();
            sNb_causa = string.Empty;
            sNb_descrip = string.Empty;
            iNb_sr_recno = 0;
            sNb_sr_deleted = "0";
            dtNb_sr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sNb_sr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// Variables globales
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_SadperIni
    {
        [BsonElement("ini_parametro")]
        public string sIni_parametro { get; set; }

        [BsonElement("ini_valor")]
        public dynamic sIni_valor { get; set; }

        [BsonElement("ini_descripcion")]
        public string sIni_descripcion { get; set; }

        [BsonElement("ini_uso")]
        public string sIni_uso { get; set; }

        [BsonElement("ini_valores")]
        public dynamic sIni_valores { get; set; }

        public mdl_SadperIni()
        {
            sIni_parametro = string.Empty;
            sIni_valor = string.Empty;
            sIni_descripcion = string.Empty;
            sIni_uso = string.Empty;
            sIni_valores = string.Empty;
        }
    }

    [BsonIgnoreExtraElements]
    public class mdl_Autorizaciones
    {
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; } = string.Empty;
        [BsonElement("em_numero")]
        public int iEm_numero { get; set; }
        [BsonElement("em_depto")]
        public int iEm_depto { get; set; }
        [BsonElement("em_sucursa")]
        public int iEm_sucursa { get; set; }
        [BsonElement("em_numniveljefe")]
        public int iEm_numniveljefe { get; set; }
        [BsonElement("em_autprimniv")]
        public string sEm_autprimniv { get; set; } = string.Empty;
        [BsonElement("em_autseguniv")]
        public string sEm_autseguniv { get; set; } = string.Empty;
        [BsonElement("em_tipogrupoexcept")]
        public string sEm_tipogrupoexcept { get; set; } = string.Empty;
        [BsonElement("em_numexcept")]
        public int iEm_numexcept { get; set; }
        [BsonElement("em_nomexcept")]
        public string sEm_nomexcept { get; set; } = string.Empty;

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; } = string.Empty;

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }
        public mdl_Autorizaciones()
        {
            _id = ObjectId.GenerateNewId().ToString();
            iEm_numero = 0;
            iEm_depto = 0;
            iEm_sucursa = 0;
            iEm_numniveljefe = 0;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sSr_usuario = string.Empty;
        }
    }

    [BsonIgnoreExtraElements]
    public class mdl_AutorizacionesAux : mdl_Autorizaciones
    {
        public string sNombreColab { get; set; } = string.Empty;
    }

    /// <summary>
    /// definicion ncertifica
    /// </summary>
    public class mdl_Certifica
    {
        [BsonElement("empresa")]
        public int iEmpresa { get; set; }

        [BsonElement("sucursal")]
        public int iSucursal { get; set; }

        [BsonElement("fielclave")]
        public string sFielClave { get; set; }

        [BsonElement("filecer")]
        public string sFilecer { get; set; }

        [BsonElement("fcerkey")]
        public string sFcerkey { get; set; }

        [BsonElement("fimgrfc")]
        public string sFimgrfc { get; set; }

        [BsonElement("fimglogo")]
        public string sFimglogo { get; set; }

        [BsonElement("cerpass")]
        public string sCerpass { get; set; }

        [BsonElement("numcer")]
        public string sNumcer { get; set; }

        [BsonElement("fecauto")]
        public DateTime? dtFecauto { get; set; }

        [BsonElement("fecsataut")]
        public string sFecsataut { get; set; }

        [BsonElement("donataria")]
        public bool bDonataria { get; set; }

        [BsonElement("retail")]
        public bool bRetail { get; set; }

        [BsonElement("combustibl")]
        public bool bCombustibl { get; set; }

        [BsonElement("impulocale")]
        public bool bImpulocale { get; set; }

        [BsonElement("terceros")]
        public bool bTerceros { get; set; }

        [BsonElement("divisas")]
        public bool bDivisas { get; set; }

        [BsonElement("pacfd")]
        public bool bPacfd { get; set; }

        [BsonElement("rvoe")]
        public bool bRvoe { get; set; }

        [BsonElement("donafech")]
        public DateTime? dtDonafech { get; set; }

        [BsonElement("actualizar")]
        public bool bActualizar { get; set; }

        [BsonElement("usuario")]
        public string sUsuario { get; set; }

        [BsonElement("fecha")]
        public DateTime? dtFecha { get; set; }

        [BsonElement("hora")]
        public string sHora { get; set; }


        public mdl_Certifica()
        {
            iEmpresa = 0;
            iSucursal = 0;
            sFielClave = string.Empty;
            sFilecer = string.Empty;
            sFcerkey = string.Empty;
            sFimgrfc = string.Empty;
            sFimglogo = string.Empty;
            sCerpass = string.Empty;
            sNumcer = string.Empty;
            dtFecauto = new DateTime(1900, 1, 1, 0, 0, 0);
            sFecsataut = string.Empty;
            bDonataria = false;
            bRetail = false;
            bCombustibl = false;
            bImpulocale = false;
            bTerceros = false;
            bDivisas = false;
            bPacfd = false;
            bRvoe = false;
            dtDonafech = new DateTime(1900, 1, 1, 0, 0, 0);
            bActualizar = false;
            sUsuario = string.Empty;
            dtFecha = new DateTime(1900, 1, 1, 0, 0, 0);
            sHora = string.Empty;
        }

    }
}
