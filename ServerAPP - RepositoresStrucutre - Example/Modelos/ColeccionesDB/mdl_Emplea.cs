
using certinom_sadper_v1.Helper;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace certinom_sadper_v1.Modelos.ColeccionesDB
{
    /*  Title: NEmplea
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
    public class mdl_Emplea
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string sId { get; set; }

        #region nemplea
        [BsonElement("em_numant")]
        public int iEm_numant { get; set; }

        [BsonElement("em_numero")]
        public int iEm_numero { get; set; }

        [BsonElement("em_cia")]
        public int iEm_cia { get; set; }

        [BsonElement("em_nombre")]
        public string sEm_nombre { get; set; }

        [BsonElement("em_apellidop")]
        public string sEm_apellidop { get; set; }

        [BsonElement("em_apellidom")]
        public string sEm_apellidom { get; set; }

        [BsonElement("em_nombres")]
        public string sEm_nombres { get; set; }



        [BsonElement("em_fechai")]
        public DateTime dtEm_fechai { get; set; }

        [BsonElement("em_imfecha")]
        public DateTime dtEm_imfecha { get; set; }

        [BsonElement("em_fechab")]
        public DateTime dtEm_fechab { get; set; }

        [BsonElement("em_fecnac")]
        public DateTime dtEm_fecnac { get; set; }

        [BsonElement("em_fechcam")]
        public DateTime dtEm_fechcam { get; set; }

        [BsonElement("em_fecplan")]
        public DateTime dtEm_fecplan { get; set; }

        [BsonElement("em_feculco")]
        public DateTime dtEm_feculco { get; set; }

        [BsonElement("em_estciv")]
        public string sEm_estciv { get; set; }

        [BsonElement("em_rfc")]
        public string sEm_rfc { get; set; }

        [BsonElement("em_sar")]
        public string sEm_sar { get; set; }

        [BsonElement("em_imss")]
        public string sEm_imss { get; set; }


        [BsonElement("em_gruimss")]
        public string sEm_gruimss { get; set; }

        [BsonElement("em_tipoemp")]
        public string sEm_tipoemp { get; set; }

        [BsonElement("em_tiponom")]
        public string sEm_tiponom { get; set; }

        [BsonElement("em_puesto")]
        public int iEm_puesto { get; set; }


        [BsonElement("em_divisio")]
        public int iEm_divisio { get; set; }

        [BsonElement("em_depto")]
        public int iEm_depto { get; set; }

        [BsonElement("em_turno")]
        public string sEm_turno { get; set; }

        [BsonElement("em_salario")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_salario { get; set; }

        [BsonElement("em_saldia")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_saldia { get; set; }

        [BsonElement("em_salprop")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_salprop { get; set; }

        [BsonElement("em_salprom")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_salprom { get; set; }

        [BsonElement("em_salppro")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_salppro { get; set; }



        [BsonElement("em_tiposal")]
        public string sEm_tiposal { get; set; }

        [BsonElement("em_salinte")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_salinte { get; set; }

        [BsonElement("em_sdivar")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdivar { get; set; }

        [BsonElement("em_asalint")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_asalint { get; set; }

        [BsonElement("em_avarant")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_avarant { get; set; }

        [BsonElement("em_cambios")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_cambios { get; set; }


        [BsonElement("em_sexo")]
        public string sEm_sexo { get; set; }

        [BsonElement("em_fechnac")]
        public DateTime dtEm_fechnac { get; set; }

        [BsonElement("em_ubzona")]
        public int iEm_ubzona { get; set; }

        [BsonElement("em_sucursa")]
        public int iEm_sucursa { get; set; }

        [BsonElement("em_manobra")]
        public string sEm_manobra { get; set; }

        [BsonElement("em_tiposan")]
        public string sEm_tiposan { get; set; }

        [BsonElement("em_contra")]
        public string sEm_contra { get; set; }

        [BsonElement("em_tiposnc")]
        public string sEm_tiposnc { get; set; }


        [BsonElement("em_grupoim")]
        public string sEm_grupoim { get; set; }

        [BsonElement("em_nivel")]
        public int iEm_nivel { get; set; }

        [BsonElement("em_sdifij1")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdifij1 { get; set; }

        [BsonElement("em_sdifij2")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdifij2 { get; set; }

        [BsonElement("em_sdifij3")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdifij3 { get; set; }

        [BsonElement("em_sdifij4")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdifij4 { get; set; }

        [BsonElement("em_sdifij5")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdifij5 { get; set; }

        [BsonElement("em_sdifij6")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdifij6 { get; set; }

        [BsonElement("em_sdibim1")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdibim1 { get; set; }

        [BsonElement("em_sdibim2")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdibim2 { get; set; }

        [BsonElement("em_sdibim3")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdibim3 { get; set; }

        [BsonElement("em_sdibim4")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdibim4 { get; set; }

        [BsonElement("em_sdibim5")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdibim5 { get; set; }

        [BsonElement("em_sdibim6")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdibim6 { get; set; }


        /// <summary>
        /// actualización
        /// </summary>
        [BsonElement("em_status")]
        public string sEm_status { get; set; }

        [BsonElement("em_reingre")]
        public string sEm_reingre { get; set; }

        [BsonElement("em_tabula")]
        public int iEm_tabula { get; set; }

        [BsonElement("em_super")]
        public int iEm_super { get; set; }

        [BsonElement("em_area")]
        public int iEm_area { get; set; }

        [BsonElement("em_sdinfo1")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdinfo1 { get; set; }

        [BsonElement("em_sdinfo2")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdinfo2 { get; set; }

        [BsonElement("em_sdinfo3")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdinfo3 { get; set; }

        [BsonElement("em_sdinfo4")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdinfo4 { get; set; }

        [BsonElement("em_sdinfo5")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdinfo5 { get; set; }

        [BsonElement("em_sdinfo6")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdinfo6 { get; set; }

        [BsonElement("em_salgara")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_salgara { get; set; }



        [BsonElement("em_curp")]
        public string sEm_curp { get; set; }

        [BsonElement("em_celula")]
        public string sEm_celula { get; set; }

        [BsonElement("em_grupo")]
        public string sEm_grupo { get; set; }

        [BsonElement("em_subgrp")]
        public string sEm_subgrp { get; set; }


        [BsonElement("em_saltab")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_saltab { get; set; }

        [BsonElement("em_incenti")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_incenti { get; set; }

        [BsonElement("em_diaeco")]
        public int iEm_diaeco { get; set; }

        [BsonElement("em_tempant")]
        public string sEm_tempant { get; set; }

        [BsonElement("em_tnomant")]
        public string sEm_tnomant { get; set; }


        [BsonElement("em_fnewemp")]
        public DateTime dtEm_fnewemp { get; set; }

        [BsonElement("em_fnewnom")]
        public DateTime dtEm_fnewnom { get; set; }

        [BsonElement("em_fecmatr")]
        public DateTime dtEm_fecmatr { get; set; }

        [BsonElement("em_fechori")]
        public DateTime dtEm_fechori { get; set; }

        [BsonElement("em_fecimss")]
        public DateTime dtEm_fecimss { get; set; }


        [BsonElement("em_salxhor")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_salxhor { get; set; }

        [BsonElement("em_tipojor")]
        public string sEm_tipojor { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_asimila")]
        public string sEm_asimila { get; set; }

        [BsonElement("em_sede")]
        public string sEm_sede { get; set; }

        [BsonElement("em_lugar")]
        public string sEm_lugar { get; set; }

        [BsonElement("em_pasport")]
        public string sEm_pasport { get; set; }


        [BsonElement("em_fecpass")]
        public DateTime dtEm_fecpass { get; set; }

        [BsonElement("em_certifi")]
        public string sEm_certifi { get; set; }

        [BsonElement("em_ciudad")]
        public string sEm_ciudad { get; set; }

        [BsonElement("em_usuario")]
        public string sEm_usuario { get; set; }


        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_autom")]
        public bool bEm_autom { get; set; }

        [BsonElement("em_email")]
        public string sEm_email { get; set; }

        [BsonElement("em_fechant")]
        public DateTime dtEm_fechant { get; set; }

        [BsonElement("em_observa")]
        public string sEm_observa { get; set; }


        [BsonElement("em_horasxp")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_horasxp { get; set; }

        [BsonElement("em_sneto")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sneto { get; set; }

        [BsonElement("em_diasvac")]
        public int iEm_diasvac { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_porprim")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_porprim { get; set; }

        [BsonElement("em_tipoasi")]
        public int iEm_tipoasi { get; set; }



        /// <summary>
        /// Adición
        /// </summary>
        [BsonElement("em_tcontra")]
        public string sEm_tcontra { get; set; }

        /// <summary>
        /// Adición
        /// </summary>
        [BsonElement("em_bonoanu")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_bonoanu { get; set; }

        [BsonElement("em_nomsat")]
        public string sEm_nomsat { get; set; }

        /// <summary>
        /// Adición
        /// </summary>
        [BsonElement("em_regfis")]
        public string sEm_regfis { get; set; }

        [BsonElement("em_cpsat")]
        public string sEm_cpsat { get; set; }

        [BsonElement("em_tcambio")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_tcambio { get; set; }

        /// <summary>
        /// Adición
        /// </summary>
        [BsonElement("em_moneda")]
        public string sEm_moneda { get; set; }

        #endregion

        #region nemppar
        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_cispt")]
        public string sEm_cispt { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_cajuste")]
        public string sEm_cajuste { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_cimss")]
        public string sEm_cimss { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_cinfona")]
        public string sEm_cinfona { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_cparti")]
        public string sEm_cparti { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_caguina")]
        public string sEm_caguina { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_cdias")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_cdias { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_cfisica")]
        public string sEm_cfisica { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_cconsta")]
        public string sEm_cconsta { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_cfahorr")]
        public string sEm_cfahorr { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_iforma")]
        public string sEm_iforma { get; set; }

        [BsonElement("em_cuenta")]
        public string sEm_cuenta { get; set; }

        [BsonElement("em_cuenta2")]
        public string sEm_cuenta2 { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_irecibo")]
        public string sEm_irecibo { get; set; }


        [BsonElement("em_pvacaci")]
        public string sEm_pvacaci { get; set; }

        [BsonElement("em_propor")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_propor { get; set; }

        [BsonElement("em_minimom")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_minimom { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_valesde")]
        public string sEm_valesde { get; set; }

        [BsonElement("em_intdes")]
        public string sEm_intdes { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_valesco")]
        public string sEm_valesco { get; set; }

        [BsonElement("em_banco")]
        public string sEm_banco { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_abonar")]
        public string sEm_abonar { get; set; }

        [BsonElement("em_reloj")]
        public string sEm_reloj { get; set; }


        [BsonElement("em_infocre")]
        public string sEm_infocre { get; set; }

        [BsonElement("em_infopor")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_infopor { get; set; }

        [BsonElement("em_infoman")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_infoman { get; set; }

        [BsonElement("em_sucurba")]
        public string sEm_sucurba { get; set; }

        [BsonElement("em_plaza")]
        public string sEm_plaza { get; set; }

        [BsonElement("em_plaza2")]
        public string sEm_plaza2 { get; set; }

        [BsonElement("em_porbco1")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_porbco1 { get; set; }

        [BsonElement("em_porbco2")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_porbco2 { get; set; }

        [BsonElement("em_penspor")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_penspor { get; set; }

        [BsonElement("em_pensimp")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_pensimp { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_pentipo")]
        public int iEm_pentipo { get; set; }

        [BsonElement("em_movfij")]
        public string sEm_movfij { get; set; }

        [BsonElement("em_envaca")]
        public string sEm_envaca { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_pereva")]
        public int iEm_pereva { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_inpeva")]
        public int iEm_inpeva { get; set; }

        [BsonElement("em_anticip")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_anticip { get; set; }

        [BsonElement("em_sdia29")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdia29 { get; set; }

        [BsonElement("em_sdib29")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdib29 { get; set; }


        [BsonElement("em_activi")]
        public string sEm_activi { get; set; }

        [BsonElement("em_cpago")]
        public int iEm_cpago { get; set; }

        [BsonElement("em_penxinv")]
        public string sEm_penxinv { get; set; }

        [BsonElement("em_nocredi")]
        public string sEm_nocredi { get; set; }

        [BsonElement("em_ificha")]
        public string sEm_ificha { get; set; }

        [BsonElement("em_antisem")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_antisem { get; set; }

        [BsonElement("em_facsm")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_facsm { get; set; }

        [BsonElement("em_ctacont")]
        public string sEm_ctacont { get; set; }


        [BsonElement("em_fechaiv")]
        public DateTime dtEm_fechaiv { get; set; }

        [BsonElement("em_retvac")]
        public DateTime dtEm_retvac { get; set; }

        [BsonElement("em_fcreinf")]
        public DateTime dtEm_fcreinf { get; set; }

        [BsonElement("em_porbono")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_porbono { get; set; }

        [BsonElement("em_moncre")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_moncre { get; set; }


        [BsonElement("em_tipocta")]
        public string sEm_tipocta { get; set; }

        [BsonElement("em_tipoinf")]
        public string sEm_tipoinf { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_imssumf")]
        public int iEm_imssumf { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_deconom")]
        public int iEm_deconom { get; set; }


        [BsonElement("em_tabisr")]
        public string sEm_tabisr { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_ahdoble")]
        public bool bEm_ahdoble { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_ahtrip")]
        public bool bEm_ahtrip { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_adomica")]
        public bool bEm_adomica { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_asabati")]
        public bool bEm_asabati { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_aprod")]
        public bool bEm_aprod { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_apuntal")]
        public bool bEm_apuntal { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_ancalif")]
        public bool bEm_ancalif { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_asisten")]
        public bool bEm_asisten { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_turflot")]
        public bool bEm_turflot { get; set; }

        /// <summary>
        /// Adición
        /// </summary>
        [BsonElement("em_ctavale")]
        public string sEm_ctavale { get; set; }

        [BsonElement("em_diasvaca")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_diasvaca { get; set; }

        [BsonElement("em_porprima")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_porprima { get; set; }

        /// <summary>
        /// Adición
        /// </summary>
        [BsonElement("em_siroc")]
        public string sEm_siroc { get; set; }

        /// <summary>
        /// Adición
        /// </summary>
        [BsonElement("em_valegas")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_valegas { get; set; }
        #endregion

        #region nhumanos
        [BsonElement("rh_telefo")]
        public string sRh_telefo { get; set; }

        [BsonElement("rh_escolar")]
        public string sRh_escolar { get; set; }

        [BsonElement("rh_nciudad")]
        public string sRh_nciudad { get; set; }

        [BsonElement("rh_nestado")]
        public string sRh_nestado { get; set; }

        [BsonElement("rh_dcalle")]
        public string sRh_dcalle { get; set; }

        [BsonElement("rh_dcolon")]
        public string sRh_dcolon { get; set; }

        [BsonElement("rh_dciudad")]
        public string sRh_dciudad { get; set; }

        [BsonElement("rh_destado")]
        public string sRh_destado { get; set; }

        [BsonElement("rh_dmunici")]
        public string sRh_dmunici { get; set; }

        [BsonElement("rh_dcp")]
        public string sRh_dcp { get; set; }

        [BsonElement("rh_npadre")]
        public string sRh_npadre { get; set; }

        [BsonElement("rh_nmadre")]
        public string sRh_nmadre { get; set; }


        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("rh_fpadre")]
        public bool bRh_fpadre { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("rh_fmadre")]
        public bool bRh_fmadre { get; set; }


        [BsonElement("rh_nacion")]
        public string sRh_nacion { get; set; }

        [BsonElement("rh_gmmaseg")]
        public string sRh_gmmaseg { get; set; }

        [BsonElement("rh_gmmfnac")]
        public DateTime dtRh_gmmfnac { get; set; }

        [BsonElement("rh_gmmsexo")]
        public string sRh_gmmsexo { get; set; }

        [BsonElement("rh_gmmpare")]
        public string sRh_gmmpare { get; set; }

        [BsonElement("rh_gmmpor")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fRh_gmmpor { get; set; }


        [BsonElement("rh_noavis1")]
        public string sRh_noavis1 { get; set; }

        [BsonElement("rh_teavis1")]
        public string sRh_teavis1 { get; set; }

        [BsonElement("rh_paavis1")]
        public string sRh_paavis1 { get; set; }

        [BsonElement("rh_noavis2")]
        public string sRh_noavis2 { get; set; }

        [BsonElement("rh_teavis2")]
        public string sRh_teavis2 { get; set; }

        [BsonElement("rh_paavis2")]
        public string sRh_paavis2 { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("rh_dpenvac")]
        public int iRh_dpenvac { get; set; }

        [BsonElement("rh_picture")]
        public string sRh_picture { get; set; }

        [BsonElement("rh_gmmpcve")]
        public string sRh_gmmpcve { get; set; }

        [BsonElement("rh_gmpcve")]
        public string sRh_gmpcve { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("rh_area")]
        public int iRh_area { get; set; }

        [BsonElement("rh_oficio")]
        public string sRh_oficio { get; set; }

        [BsonElement("rh_gmmesta")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fRh_gmmesta { get; set; }

        [BsonElement("rh_gmmpeso")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fRh_gmmpeso { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("rh_plangmm")]
        public bool bRh_plangmm { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("rh_plansv")]
        public bool bRh_plansv { get; set; }

        [BsonElement("rh_gmmsuma")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fRh_gmmsuma { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("rh_aplansv")]
        public bool bRh_aplansv { get; set; }


        [BsonElement("rh_psvsuma")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fRh_psvsuma { get; set; }

        [BsonElement("rh_ubicado")]
        public string sRh_ubicado { get; set; }

        [BsonElement("rh_estatu")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fRh_estatu { get; set; }

        [BsonElement("rh_peso")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fRh_peso { get; set; }

        [BsonElement("rh_tallac")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fRh_tallac { get; set; }

        [BsonElement("rh_tallap")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fRh_tallap { get; set; }

        [BsonElement("rh_calzado")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fRh_calzado { get; set; }

        [BsonElement("rh_coloroj")]
        public string sRh_coloroj { get; set; }

        [BsonElement("rh_colorca")]
        public string sRh_colorca { get; set; }

        [BsonElement("rh_piel")]
        public string sRh_piel { get; set; }

        [BsonElement("rh_separt")]
        public string sRh_separt { get; set; }

        [BsonElement("rh_svplane")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fRh_svplane { get; set; }

        [BsonElement("rh_deporte")]
        public string sRh_deporte { get; set; }

        [BsonElement("rh_hobbies")]
        public string sRh_hobbies { get; set; }

        [BsonElement("rh_lvacaci")]
        public string sRh_lvacaci { get; set; }


        [BsonElement("rh_numsmm")]
        public string sRh_numsmm { get; set; }

        [BsonElement("rh_numvisa")]
        public string sRh_numvisa { get; set; }

        [BsonElement("rh_numlic")]
        public string sRh_numlic { get; set; }

        [BsonElement("rh_benpens")]
        public string sRh_benpens { get; set; }

        [BsonElement("rh_piso")]
        public string sRh_piso { get; set; }

        [BsonElement("rh_teltra")]
        public string sRh_teltra { get; set; }

        [BsonElement("rh_exttrab")]
        public string sRh_exttrab { get; set; }

        [BsonElement("rh_extcerc")]
        public string sRh_extcerc { get; set; }

        [BsonElement("rh_secre")]
        public string sRh_secre { get; set; }

        [BsonElement("rh_telsec")]
        public string sRh_telsec { get; set; }

        [BsonElement("rh_extsec")]
        public string sRh_extsec { get; set; }

        [BsonElement("rh_mail")]
        public string sRh_mail { get; set; }

        [BsonElement("rh_benpen2")]
        public string sRh_benpen2 { get; set; }


        [BsonElement("rh_fecapti")]
        public DateTime dtRh_fecapti { get; set; }

        [BsonElement("rh_fecflot")]
        public DateTime dtRh_fecflot { get; set; }

        [BsonElement("rh_fecind")]
        public DateTime dtRh_fecind { get; set; }

        [BsonElement("rh_svcosto")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fRh_svcosto { get; set; }

        [BsonElement("rh_gmcosto")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fRh_gmcosto { get; set; }

        [BsonElement("rh_soceco")]
        public DateTime dtRh_soceco { get; set; }

        [BsonElement("rh_segpub")]
        public DateTime dtRh_segpub { get; set; }

        [BsonElement("rh_antidop")]
        public DateTime dtRh_antidop { get; set; }

        [BsonElement("rh_cartila")]
        public string sRh_cartila { get; set; }
        #endregion


        #region Nuevos campos en la coleccion NEmplea
        [BsonElement("rh_valdesmonto")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal dRh_valdesmonto { get; set; }

        [BsonElement("rh_valdeseisr")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal dRh_valdeseisr { get; set; }

        [BsonElement("rh_valdeseimss")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal dRh_valdeseimss { get; set; }

        [BsonElement("rh_valresmonto")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal dRh_valresmonto { get; set; }

        [BsonElement("rh_valreseisr")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal dRh_valreseisr { get; set; }

        [BsonElement("rh_valreseimss")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal dRh_valreseimss { get; set; }

        [BsonElement("rh_avaldesmonto")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal dRh_avaldesmonto { get; set; }

        [BsonElement("rh_avaldeseisr")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal dRh_avaldeseisr { get; set; }

        [BsonElement("rh_avaldeseimss")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal dRh_avaldeseimss { get; set; }

        [BsonElement("rh_pervales")]
        public string sRh_pervales { get; set; }


        [BsonElement("rh_retvales")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal dRh_retvales { get; set; }

        //Valores: 
        //P
        //M
        [BsonElement("rh_valperiodo")]
        public string sRh_valperiodo { get; set; }


        #endregion

        [BsonElement("em_fotografias")]
        public mdl_Fotografias[] aFotografias { get; set; }

        [BsonElement("em_estudio")]
        public mdl_Estudio[] aEstudio { get; set; }

        //Tabla nbenefi
        [BsonElement("em_beneficiarios")]
        public mdl_Beneficiario[] aBeneficiarios { get; set; }

        //Tabla nbajas 
        [BsonElement("em_bajas")]
        public mdl_Baja[] aBajas { get; set; }

        //Tabla activos fijos
        [BsonElement("em_activosfijos")]
        public mdl_ActivosFijos[] aActivosFijos { get; set; }

        //Tabla nemprein
        [BsonElement("em_reingresos")]
        public mdl_Reingreso[] aReingreso { get; set; }

        //Tabla nempsdi
        [BsonElement("em_integrados")]
        public mdl_SDI[] aIntegrado { get; set; }

        //Tabla nemphist
        [BsonElement("em_historico")]
        public mdl_Historico[] aHistorico { get; set; }

        //Tabla nsalario
        [BsonElement("em_incrementos")]
        public mdl_Salario[] aIncremento { get; set; }

        [BsonElement("em_antiguedad")]
        public mdl_Antiguedad[] aAntiguedad { get; set; }

        //Tabla hvacthis
        [BsonElement("em_vacaciones")]
        public mdl_Vacaciones[] aVacaciones { get; set; }

        //tabla nemplepd
        [BsonElement("em_conceptos")]
        public mdl_Conceptos[] aConceptos { get; set; }

        /// <summary>
        /// Adicion
        /// </summary>
        [BsonElement("em_speech")]
        public string sEm_speech { get; set; }

        /// <summary>
        /// Adicion
        /// </summary>
        [BsonElement("em_speechAI")]
        public string sEm_speechAI { get; }

        /// <summary>
        /// Adicion
        /// </summary>
        [BsonElement("em_fechaspeech")]
        public string sEm_fechaspeech { get; set; }

        /// <summary>
        /// Adicion
        /// </summary>
        [BsonElement("em_voz")]
        public string sEm_voz { get; set; }

        /// <summary>
        /// Adicion
        /// </summary>
        [BsonElement("em_firma")]
        public string sEm_firma { get; set; }

        /// <summary>
        /// Adicion
        /// </summary>
        [BsonElement("em_fotografia")]
        public string sEm_fotografia { get; set; }

        /// <summary>
        /// Adicion
        /// </summary>
        [BsonElement("em_documentos")]
        public mdl_DocumentosColaborador[] aDocumentos { get; set; }

        /// <summary>
        /// Adicion
        /// </summary>
        [BsonElement("em_lineatiempo")]
        public mdl_LineaTiempo[] aLineaTiempo { get; set; }


        [BsonElement("em_password")]
        public string sEm_password { get; set; }

        [BsonElement("em_codigoverifica")]
        public string sEm_codigoverfica { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        /// <summary>
        /// Adicion
        /// </summary>
        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        /// <summary>
        /// Adicion
        /// </summary>
        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }


        public mdl_Emplea()
        {
            iEm_numant = 0;
            iEm_numero = 0;
            iEm_cia = 0;
            sEm_nombre = string.Empty;
            dtEm_fechai = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtEm_imfecha = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtEm_fechab = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtEm_fecnac = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtEm_fechcam = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtEm_fecplan = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtEm_feculco = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sEm_estciv = string.Empty;
            sEm_rfc = string.Empty;
            sEm_sar = string.Empty;
            sEm_imss = string.Empty;
            sEm_gruimss = string.Empty;
            sEm_tipoemp = string.Empty;
            sEm_tiponom = string.Empty;
            iEm_puesto = 0;
            iEm_divisio = 0;
            iEm_depto = 0;
            sEm_turno = string.Empty;
            fEm_salario = 0.0m;
            fEm_saldia = 0.0m;
            fEm_salprop = 0.0m;
            fEm_salprom = 0.0m;
            fEm_salppro = 0.0m;
            sEm_tiposal = string.Empty;
            fEm_salinte = 0.0m;
            fEm_sdivar = 0.0m;
            fEm_asalint = 0.0m;
            fEm_avarant = 0.0m;
            fEm_cambios = 0.0m;
            sEm_sexo = string.Empty;
            dtEm_fechnac = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            iEm_ubzona = 0;
            iEm_sucursa = 0;
            sEm_manobra = string.Empty;
            sEm_tiposan = string.Empty;
            sEm_contra = string.Empty;
            sEm_tiposnc = string.Empty;
            sEm_grupoim = string.Empty;
            iEm_nivel = 0;
            fEm_sdifij1 = 0.0m;
            fEm_sdifij2 = 0.0m;
            fEm_sdifij3 = 0.0m;
            fEm_sdifij4 = 0.0m;
            fEm_sdifij5 = 0.0m;
            fEm_sdifij6 = 0.0m;
            fEm_sdibim1 = 0.0m;
            fEm_sdibim2 = 0.0m;
            fEm_sdibim3 = 0.0m;
            fEm_sdibim4 = 0.0m;
            fEm_sdibim5 = 0.0m;
            fEm_sdibim6 = 0.0m;
            sEm_status = string.Empty;
            sEm_reingre = string.Empty;
            iEm_tabula = 0;
            iEm_super = 0;
            iEm_area = 0;
            fEm_sdinfo1 = 0.0m;
            fEm_sdinfo2 = 0.0m;
            fEm_sdinfo3 = 0.0m;
            fEm_sdinfo4 = 0.0m;
            fEm_sdinfo5 = 0.0m;
            fEm_sdinfo6 = 0.0m;
            fEm_salgara = 0.0m;
            sEm_curp = string.Empty;
            sEm_celula = string.Empty;
            sEm_grupo = string.Empty;
            sEm_subgrp = string.Empty;
            fEm_saltab = 0.0m;
            fEm_incenti = 0.0m;
            iEm_diaeco = 0;
            sEm_tempant = string.Empty;
            sEm_tnomant = string.Empty;
            dtEm_fnewemp = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtEm_fnewnom = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtEm_fecmatr = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtEm_fechori = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtEm_fecimss = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            fEm_salxhor = 0.0m;
            sEm_tipojor = string.Empty;
            sEm_asimila = string.Empty;
            sEm_sede = string.Empty;
            sEm_lugar = string.Empty;
            sEm_pasport = string.Empty;
            dtEm_fecpass = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sEm_certifi = string.Empty;
            sEm_ciudad = string.Empty;
            sEm_usuario = string.Empty;
            bEm_autom = false;
            sEm_email = string.Empty;
            dtEm_fechant = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sEm_observa = string.Empty;
            fEm_horasxp = 0.0m;
            fEm_sneto = 0.0m;
            iEm_diasvac = 0;
            fEm_porprim = 0.0m;
            iEm_tipoasi = 0;
            sEm_tcontra = string.Empty;
            fEm_bonoanu = 0.0m;
            sEm_nomsat = string.Empty;
            sEm_regfis = string.Empty;
            sEm_cpsat = string.Empty;
            fEm_tcambio = 0.0m;
            sEm_moneda = string.Empty;
            sEm_cispt = string.Empty;
            sEm_cajuste = string.Empty;
            sEm_cimss = string.Empty;
            sEm_cinfona = string.Empty;
            sEm_cparti = string.Empty;
            sEm_caguina = string.Empty;
            fEm_cdias = 0.0m;
            sEm_cfisica = string.Empty;
            sEm_cconsta = string.Empty;
            sEm_cfahorr = string.Empty;
            sEm_iforma = string.Empty;
            sEm_cuenta = string.Empty;
            sEm_cuenta2 = string.Empty;
            sEm_irecibo = string.Empty;
            sEm_pvacaci = string.Empty;
            fEm_propor = 0.0m;
            fEm_minimom = 0.0m;
            sEm_valesde = string.Empty;
            sEm_intdes = string.Empty;
            sEm_valesco = string.Empty;
            sEm_banco = string.Empty;
            sEm_abonar = string.Empty;
            sEm_reloj = string.Empty;
            sEm_infocre = string.Empty;
            fEm_infopor = 0.0m;
            fEm_infoman = 0.0m;
            sEm_sucurba = string.Empty;
            sEm_plaza = string.Empty;
            sEm_plaza2 = string.Empty;
            fEm_porbco1 = 0.0m;
            fEm_porbco2 = 0.0m;
            fEm_penspor = 0.0m;
            fEm_pensimp = 0.0m;
            iEm_pentipo = 0;
            sEm_movfij = string.Empty;
            sEm_envaca = string.Empty;
            iEm_pereva = 0;
            iEm_inpeva = 0;
            fEm_anticip = 0.0m;
            fEm_sdia29 = 0.0m;
            fEm_sdib29 = 0.0m;
            sEm_activi = string.Empty;
            iEm_cpago = 0;
            sEm_penxinv = string.Empty;
            sEm_nocredi = string.Empty;
            sEm_ificha = string.Empty;
            fEm_antisem = 0.0m;
            fEm_facsm = 0.0m;
            sEm_ctacont = string.Empty;
            dtEm_fechaiv = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtEm_retvac = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtEm_fcreinf = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            fEm_porbono = 0.0m;
            fEm_moncre = 0.0m;
            sEm_tipocta = string.Empty;
            sEm_tipoinf = string.Empty;
            iEm_imssumf = 0;
            iEm_deconom = 0;
            sEm_tabisr = string.Empty;
            bEm_ahdoble = false;
            bEm_ahtrip = false;
            bEm_adomica = false;
            bEm_asabati = false;
            bEm_aprod = false;
            bEm_apuntal = false;
            bEm_ancalif = false;
            bEm_asisten = false;
            bEm_turflot = false;
            sEm_ctavale = string.Empty;
            fEm_diasvaca = 0.0m;
            fEm_porprima = 0.0m;
            sEm_siroc = string.Empty;
            fEm_valegas = 0.0m;
            sRh_telefo = string.Empty;
            sRh_escolar = string.Empty;
            sRh_nciudad = string.Empty;
            sRh_nestado = string.Empty;
            sRh_dcalle = string.Empty;
            sRh_dcolon = string.Empty;
            sRh_dciudad = string.Empty;
            sRh_destado = string.Empty;
            sRh_dmunici = string.Empty;
            sRh_dcp = string.Empty;
            sRh_npadre = string.Empty;
            sRh_nmadre = string.Empty;
            bRh_fpadre = false;
            bRh_fmadre = false;
            sRh_nacion = string.Empty;
            sRh_gmmaseg = string.Empty;
            dtRh_gmmfnac = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sRh_gmmsexo = string.Empty;
            sRh_gmmpare = string.Empty;
            fRh_gmmpor = 0.0m;
            sRh_noavis1 = string.Empty;
            sRh_teavis1 = string.Empty;
            sRh_paavis1 = string.Empty;
            sRh_noavis2 = string.Empty;
            sRh_teavis2 = string.Empty;
            sRh_paavis2 = string.Empty;
            iRh_dpenvac = 0;
            sRh_picture = string.Empty;
            sRh_gmmpcve = string.Empty;
            iRh_area = 0;
            sRh_oficio = string.Empty;
            fRh_gmmesta = 0.0m;
            fRh_gmmpeso = 0.0m;
            bRh_plangmm = false;
            bRh_plansv = false;
            fRh_gmmsuma = 0.0m;
            bRh_aplansv = false;
            fRh_psvsuma = 0.0m;
            sRh_ubicado = string.Empty;
            fRh_estatu = 0.0m;
            fRh_peso = 0.0m;
            fRh_tallac = 0.0m;
            fRh_tallap = 0.0m;
            fRh_calzado = 0.0m;
            sRh_coloroj = string.Empty;
            sRh_colorca = string.Empty;
            sRh_piel = string.Empty;
            sRh_separt = string.Empty;
            fRh_svplane = 0.0m;
            sRh_deporte = string.Empty;
            sRh_hobbies = string.Empty;
            sRh_lvacaci = string.Empty;
            sRh_numsmm = string.Empty;
            sRh_numvisa = string.Empty;
            sRh_numlic = string.Empty;
            sRh_benpens = string.Empty;
            sRh_piso = string.Empty;
            sRh_teltra = string.Empty;
            sRh_exttrab = string.Empty;
            sRh_extcerc = string.Empty;
            sRh_secre = string.Empty;
            sRh_telsec = string.Empty;
            sRh_extsec = string.Empty;
            sRh_mail = string.Empty;
            sRh_benpen2 = string.Empty;
            dtRh_fecapti = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtRh_fecflot = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtRh_fecind = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            fRh_svcosto = 0.0m;
            fRh_gmcosto = 0.0m;
            dtRh_soceco = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtRh_segpub = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtRh_antidop = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sRh_cartila = string.Empty;

            #region Nuevos campos en la coleccion NEmplea
            dRh_valdesmonto = 0.0m;
            dRh_valdeseisr = 0.0m;
            dRh_valdeseimss = 0.0m;
            dRh_valresmonto = 0.0m;
            dRh_valreseisr = 0.0m;
            dRh_valreseimss = 0.0m;
            dRh_avaldesmonto = 0.0m;
            dRh_avaldeseisr = 0.0m;
            dRh_avaldeseimss = 0.0m;
            sRh_pervales = string.Empty;
            dRh_retvales = 0.0m;
            sRh_valperiodo = string.Empty;
            #endregion


            sEm_speech = string.Empty;
            sEm_speechAI = string.Empty;
            sEm_fechaspeech = string.Empty;
            sEm_voz = string.Empty;
            sEm_firma = string.Empty;
            sEm_fotografia = string.Empty;
            sEm_password = string.Empty;
            sEm_codigoverfica = string.Empty;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sSr_usuario = string.Empty;
            aFotografias = new mdl_Fotografias[1] { new mdl_Fotografias() };

        }

        public static mdl_Emplea CrearDefault()
        {
            return new mdl_Emplea
            {
                sEm_tipoemp = "N",
                sEm_tiposal = "S",
                sEm_tiponom = "S",
                //sEm_tipojor = "C",
                sEm_contra = "E",
                sEm_gruimss = "M",
                sEm_manobra = "I",
                sEm_activi = "E",
                sEm_tipojor = "01 Diurna",
                sEm_moneda = "MXN",

                fEm_propor = 1.0m,
                sEm_tipoinf = "C",
                sEm_tipocta = "T",
                sEm_pvacaci = "C",
                sEm_cispt = "S",
                sEm_cimss = "S",
                sEm_cparti = "S",
                sEm_valesde = "N",
                sEm_irecibo = "S",
                sEm_iforma = "N",
                sEm_abonar = "S",
                sEm_cajuste = "S",
                sEm_cfisica = "S",
                sEm_caguina = "S",
                sEm_valesco = "N",
                sEm_cfahorr = "S",
                sEm_cconsta = "N",
                sEm_asimila = "N",
                sEm_status = "S",
                fEm_minimom = 7.00m,
                dtEm_fcreinf = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0)),
            };
        }

    }
    [BsonIgnoreExtraElements]
    public class mdl_Fotografias
    {

        [BsonElement("ft_imagen")]
        public string sFt_imagen { get; set; }

        [BsonElement("ft_dimensiones")]
        public string sFt_dimensiones { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        public mdl_Fotografias()
        {
            sFt_imagen = string.Empty;
            sFt_dimensiones = string.Empty;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sSr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// Clase que contiene los elementos del arreglo beneficiarios, correspondiente a la tabla nbenefi (Clase NEmplea)
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Beneficiario
    {
        [BsonElement("be_tipo")]
        public string sBe_tipo { get; set; }

        [BsonElement("be_clavep")]
        public string sBe_clavep { get; set; }

        [BsonElement("be_nombre")]
        public string sBe_nombre { get; set; }

        [BsonElement("be_parient")]
        public string sBe_parient { get; set; }

        [BsonElement("be_porcent")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fBe_porcent { get; set; }

        [BsonElement("be_fecnac")]
        public DateTime? dtBe_fecnac { get; set; }

        [BsonElement("be_sexo")]
        public string sBe_sexo { get; set; }

        [BsonElement("be_telefo")]
        public string sBe_telefo { get; set; }

        [BsonElement("be_peso")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fBe_peso { get; set; }

        [BsonElement("be_estatur")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fBe_estatur { get; set; }

        [BsonElement("be_estudio")]
        public string sBe_estudio { get; set; }

        [BsonElement("be_deporte")]
        public string sBe_deporte { get; set; }

        [BsonElement("be_hobbies")]
        public string sBe_hobbies { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        public mdl_Beneficiario()
        {
            sBe_tipo = string.Empty;
            sBe_clavep = string.Empty;
            sBe_nombre = string.Empty;
            sBe_parient = string.Empty;
            fBe_porcent = 0.0m;
            dtBe_fecnac = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sBe_sexo = string.Empty;
            sBe_telefo = string.Empty;
            fBe_peso = 0.0m;
            fBe_estatur = 0.0m;
            sBe_estudio = string.Empty;
            sBe_deporte = string.Empty;
            sBe_hobbies = string.Empty;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sSr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// Clase que contiene el arreglo de vacaciones (NUEVO)
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Vacaciones
    {
        [BsonElement("va_diasvac")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fVa_diasvac { get; set; }

        [BsonElement("va_diaspri")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fVa_diaspri { get; set; }

        [BsonElement("va_disfrut")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fVa_disfrut { get; set; }

        [BsonElement("va_festivo")]
        public int iVa_festivo { get; set; }

        [BsonElement("va_sabado")]
        public int iVa_sabado { get; set; }

        [BsonElement("va_domingo")]
        public int iVa_domingo { get; set; }

        [BsonElement("va_fecivac")]
        public DateTime dtVa_fecivac { get; set; }

        [BsonElement("va_feccap")]
        public DateTime dtVa_feccap { get; set; }

        [BsonElement("va_fechare")]
        public DateTime dtVa_fechare { get; set; }

        [BsonElement("va_peranua")]
        public int iVa_peranua { get; set; }

        [BsonElement("va_pernom")]
        public int iVa_pernom { get; set; }

        [BsonElement("va_tiponom")]
        public string sVa_tiponom { get; set; }

        [BsonElement("va_tiposnc")]
        public string sVa_tiposnc { get; set; }

        [BsonElement("va_centcos")]
        public int iVa_centcos { get; set; }

        [BsonElement("va_sucursa")]
        public int iVa_sucursa { get; set; }

        [BsonElement("va_fvimp")]
        public bool bVa_fvimp { get; set; }

        [BsonElement("va_refer")]
        public string sVa_refer { get; set; }

        [BsonElement("va_prima01")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fVa_prima01 { get; set; }

        [BsonElement("va_primaok")]
        public string sVa_primaok { get; set; }

        [BsonElement("va_vpagada")]
        public bool bVa_vpagada { get; set; }

        [BsonElement("va_ciclo")]
        public string sVa_ciclo { get; set; }

        [BsonElement("va_porprim")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fVa_porprim { get; set; }

        [BsonElement("va_montova")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fVa_montova { get; set; }

        [BsonElement("va_montopr")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fVa_montopr { get; set; }

        [BsonElement("va_montove")]
        public int iVa_montove { get; set; }

        [BsonElement("va_diastra")]
        public int iVa_diastra { get; set; }

        [BsonElement("va_diasims")]
        public int iVa_diasims { get; set; }

        [BsonElement("va_salario")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fVa_salario { get; set; }

        [BsonElement("va_nantici")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fVa_nantici { get; set; }

        [BsonElement("va_fahorro")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fVa_fahorro { get; set; }

        [BsonElement("va_ispt")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fVa_ispt { get; set; }

        [BsonElement("va_eym")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fVa_eym { get; set; }

        [BsonElement("va_iv")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fVa_iv { get; set; }

        [BsonElement("va_cv")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fVa_cv { get; set; }

        [BsonElement("va_infona")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fVa_infona { get; set; }

        [BsonElement("va_pagado")]
        public bool bVa_pagado { get; set; }

        [BsonElement("va_aplicar")]
        public bool bVa_aplicar { get; set; }

        [BsonElement("va_lvacpag")]
        public bool bVa_lvacpag { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        public mdl_Vacaciones()
        {
            // Inicializaciones según tipos de datos
            fVa_diasvac = 0.00m;
            fVa_diaspri = 0.00m;
            fVa_disfrut = 0.00m;
            iVa_festivo = 0;
            iVa_sabado = 0;
            iVa_domingo = 0;
            dtVa_fecivac = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtVa_feccap = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtVa_fechare = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            iVa_peranua = 0;
            iVa_pernom = 0;
            sVa_tiponom = string.Empty;
            sVa_tiposnc = string.Empty;
            iVa_centcos = 0;
            iVa_sucursa = 0;
            bVa_fvimp = false;
            sVa_refer = string.Empty;
            fVa_prima01 = 0.00m;
            sVa_primaok = string.Empty;
            bVa_vpagada = false;
            sVa_ciclo = string.Empty;
            fVa_porprim = 0.00m;
            fVa_montova = 0.00m;
            fVa_montopr = 0.00m;
            iVa_montove = 0;
            iVa_diastra = 0;
            iVa_diasims = 0;
            fVa_salario = 0.00m;
            fVa_nantici = 0.00m;
            fVa_fahorro = 0.00m;
            fVa_ispt = 0.00m;
            fVa_eym = 0.00m;
            fVa_iv = 0.00m;
            fVa_cv = 0.00m;
            fVa_infona = 0.00m;
            bVa_pagado = false;
            bVa_aplicar = false;
            bVa_lvacpag = false;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sSr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// Clase que contiene los elementos del arreglo de bajas, correspondiente a la tabla nbajas (Clase NEmplea)
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Baja
    {
        /// <summary>
        /// Actualización: em_bfechai
        /// </summary>
        [BsonElement("em_fechai")]
        public DateTime dtEm_fechai { get; set; }

        /// <summary>
        /// Actualización: em_bfechab
        /// </summary>
        [BsonElement("em_fechab")]
        public DateTime dtEm_fechab { get; set; }

        /// <summary>
        /// Actualización: em_bcausa
        /// </summary>
        [BsonElement("em_causa")]
        public string sEm_causa { get; set; }

        [BsonElement("em_comenta")]
        public string sEm_comenta { get; set; }

        /// <summary>
        /// Actualización: em_salariob
        /// </summary>
        [BsonElement("em_salario")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_salario { get; set; }

        [BsonElement("em_salinte")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_salinte { get; set; }

        [BsonElement("em_sdivar")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdivar { get; set; }

        [BsonElement("em_bajaim")]
        public DateTime dtEm_bajaim { get; set; }

        /// <summary>
        /// Actualización: em_bstatimp int
        /// </summary>
        [BsonElement("em_statimp")]
        public bool bEm_statimp { get; set; }

        [BsonElement("em_baimss")]
        public string sEm_baimss { get; set; }

        [BsonElement("em_norecon")]
        public int iEm_norecon { get; set; }

        /// <summary>
        /// Actualización: em_bdepto
        /// </summary>
        [BsonElement("em_depto")]
        public int iEm_depto { get; set; }

        /// <summary>
        /// Actualización: em_bpuesto
        /// </summary>
        [BsonElement("em_puesto")]
        public int iEm_puesto { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        public mdl_Baja()
        {
            dtEm_fechai = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtEm_fechab = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sEm_causa = string.Empty;
            sEm_comenta = string.Empty;
            fEm_salario = 0.0m;
            fEm_salinte = 0.0m;
            fEm_sdivar = 0.0m;
            dtEm_bajaim = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            ;
            bEm_statimp = false;
            sEm_baimss = string.Empty;
            iEm_norecon = 0;
            iEm_depto = 0;
            iEm_puesto = 0;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sSr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// Clase que contiene los elementos del arreglo antiguedad
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Antiguedad
    {
        [BsonElement("ta_peranu")]
        public int iTa_peranu { get; set; }

        [BsonElement("ta_derecho")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fTa_derecho { get; set; }

        [BsonElement("ta_disfrut")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fTa_disfrut { get; set; }

        [BsonElement("ta_disfrutaux")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fTa_disfrutaux { get; set; }

        [BsonElement("ta_saldia")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fTa_saldia { get; set; }

        [BsonElement("ta_saldiaaux")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fTa_saldiaaux { get; set; }

        [BsonElement("ta_pagprim")]
        public bool bTa_pagprim { get; set; }

        [BsonElement("ta_dprimav")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fTa_dprimav { get; set; }

        [BsonElement("ta_derxant")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fTa_derxant { get; set; }

        [BsonElement("ta_Salxant")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fTa_Salxant { get; set; }

        [BsonElement("ta_esregistroplaneacion")]
        public bool bTa_esregistroplaneacion { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        public mdl_Antiguedad()
        {
            iTa_peranu = 0;
            fTa_derecho = 0.00m;
            fTa_disfrut = 0.00m;
            fTa_saldia = 0.00m;
            bTa_pagprim = false;
            fTa_dprimav = 0.00m;
            fTa_derxant = 0.00m;
            fTa_Salxant = 0.00m;
            bTa_esregistroplaneacion = false;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sSr_usuario = string.Empty;
        }
    }


    /// <summary>
    /// Pendiente de descripción (NUEVO)
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_ActivosFijos
    {
        [BsonElement("ef_clave")]
        public string sEf_Clave { get; set; }

        [BsonElement("ef_descrip")]
        public string sEf_descrip { get; set; }

        [BsonElement("ef_fechaas")]
        public DateTime? dtEf_fechaas { get; set; }

        [BsonElement("ef_fechare")]
        public DateTime? dtEf_fechare { get; set; }

        [BsonElement("ef_valor")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEf_valor { get; set; }

        [BsonElement("ef_serie")]
        public string sEf_serie { get; set; }

        [BsonElement("ef_motor")]
        public string sEf_motor { get; set; }

        [BsonElement("ef_marcave")]
        public string sEf_marcave { get; set; }

        [BsonElement("ef_modelo")]
        public string sEf_modelo { get; set; }

        [BsonElement("ef_placas")]
        public string sEf_placas { get; set; }

        [BsonElement("ef_numcel")]
        public string sEf_numcel { get; set; }

        [BsonElement("ef_marcace")]
        public string sEf_marcace { get; set; }

        [BsonElement("ef_radio")]
        public string sEf_radio { get; set; }

        [BsonElement("ef_numrad")]
        public string sEf_numrad { get; set; }

        [BsonElement("ef_numtar")]
        public string sEf_numtar { get; set; }

        [BsonElement("ef_observ")]
        public string sEf_observ { get; set; }

        [BsonElement("ef_numfac1")]
        public string sEf_numfac1 { get; set; }

        [BsonElement("ef_numfac2")]
        public string sEf_numfac2 { get; set; }

        [BsonElement("ef_numfac3")]
        public string sEf_numfac3 { get; set; }

        [BsonElement("ef_numfac4")]
        public string sEf_numfac4 { get; set; }

        [BsonElement("ef_tipo")]
        public int iEf_tipo { get; set; }

        [BsonElement("ef_tipoal")]
        public string sEf_tipoal { get; set; }

        [BsonElement("ef_kminici")]
        public int iEf_kminici { get; set; }

        [BsonElement("ef_kmrecor")]
        public int iEf_kmrecor { get; set; }

        [BsonElement("ef_kmfecle")]
        public DateTime? dtEf_kmfecle { get; set; }

        [BsonElement("ef_apoliza")]
        public string sEf_apoliza { get; set; }

        [BsonElement("ef_polvenc")]
        public DateTime? dtEf_polvenc { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        public mdl_ActivosFijos()
        {
            sEf_Clave = string.Empty;
            sEf_descrip = string.Empty;
            dtEf_fechaas = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            dtEf_fechare = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            fEf_valor = 0.00m;
            sEf_serie = string.Empty;
            sEf_motor = string.Empty;
            sEf_marcave = string.Empty;
            sEf_modelo = string.Empty;
            sEf_placas = string.Empty;
            sEf_numcel = string.Empty;
            sEf_marcace = string.Empty;
            sEf_radio = string.Empty;
            sEf_numrad = string.Empty;
            sEf_numtar = string.Empty;
            sEf_observ = string.Empty;
            sEf_numfac1 = string.Empty;
            sEf_numfac2 = string.Empty;
            sEf_numfac3 = string.Empty;
            sEf_numfac4 = string.Empty;
            iEf_tipo = 0;
            sEf_tipoal = string.Empty;
            iEf_kminici = 0;
            iEf_kmrecor = 0;
            dtEf_kmfecle = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sEf_apoliza = string.Empty;
            dtEf_polvenc = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sSr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// Clase que contiene los elementos del arreglo reingresos, correspondiente a la tabla nbreingre (Clase NEmplea)
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Reingreso
    {
        /// <summary>
        /// Actualización: em_rfecha
        /// </summary>
        [BsonElement("em_fechar")]
        public DateTime dtEm_fechar { get; set; }

        [BsonElement("em_sdifijo")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdifijo { get; set; }

        /// <summary>
        /// Actualizacion: em_rsdivar
        /// </summary>
        [BsonElement("em_sdivar")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdivar { get; set; }

        /// <summary>
        /// Actualización: em_rcausa
        /// </summary>
        [BsonElement("em_causa")]
        public string sEm_causa { get; set; }

        [BsonElement("em_fechaba")]
        public DateTime dtEm_fechaba { get; set; }

        /// <summary>
        /// Actualización: em_rsalario
        /// </summary>
        [BsonElement("em_salario")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_salario { get; set; }

        /// <summary>
        /// Actualización: em_rfecna
        /// </summary>
        [BsonElement("em_fecnac")]
        public DateTime dtEm_fecnac { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        public mdl_Reingreso()
        {
            dtEm_fechar = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            fEm_sdifijo = 0.0m;
            fEm_sdivar = 0.0m;
            sEm_causa = string.Empty;
            dtEm_fechaba = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            fEm_salario = 0.0m;
            dtEm_fecnac = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sSr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// Clase que contiene los elementos del arreglo historico, correspondiente a la tabla nemphist (Clase NEmplea)
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Historico
    {
        // [BsonElement("em_campo")]
        // public string sEm_campo { get; set; }

        [BsonElement("em_cambio")]
        public DateTime dtEm_cambio { get; set; }

        [BsonElement("em_tipomov")]
        public string sEm_tipomov { get; set; }

        [BsonElement("em_quecam")]
        public string sEm_quecam { get; set; }

        [BsonElement("em_valant")]
        public string sEm_valant { get; set; }

        [BsonElement("em_valnew")]
        public string sEm_valnew { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        public mdl_Historico()
        {
            dtEm_cambio = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sEm_tipomov = string.Empty;
            sEm_quecam = string.Empty;
            sEm_valant = string.Empty;
            sEm_valnew = string.Empty;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sSr_usuario = string.Empty;
        }
    }
    /// <summary>
    /// Clase que contiene la informacion de los estudios del colaborador. (NUEVO)
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Estudio
    {
        [BsonElement("em_ulgrado")]
        public string sEm_ulgrado { get; set; }

        [BsonElement("em_uinsti")]
        public string sEm_uinsti { get; set; }

        [BsonElement("em_genera")]
        public string sEm_genera { get; set; }

        [BsonElement("em_utitulo")]
        public string sEm_utitulo { get; set; }

        [BsonElement("em_maestri")]
        public string sEm_maestri { get; set; }

        [BsonElement("em_minsti")]
        public string sEm_minsti { get; set; }

        [BsonElement("em_docto")]
        public string sEm_docto { get; set; }

        [BsonElement("em_dinsti")]
        public string sEm_dinsti { get; set; }

        [BsonElement("em_especia")]
        public string sEm_especia { get; set; }

        [BsonElement("em_einsti")]
        public string sEm_einsti { get; set; }

        [BsonElement("em_cedula")]
        public string sEm_cedula { get; set; }

        [BsonElement("em_titsn")]
        public string sEm_titsn { get; set; }

        //[BsonElement("em_diplomado")]
        //public string sEm_diplomado { get; set; }

        [BsonElement("em_observ")]
        public string sEm_observ { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        public mdl_Estudio()
        {
            sEm_ulgrado = string.Empty;
            sEm_uinsti = string.Empty;
            sEm_genera = string.Empty;
            sEm_utitulo = string.Empty;
            sEm_maestri = string.Empty;
            sEm_minsti = string.Empty;
            sEm_docto = string.Empty;
            sEm_dinsti = string.Empty;
            sEm_especia = string.Empty;
            sEm_einsti = string.Empty;
            sEm_cedula = string.Empty;
            sEm_titsn = string.Empty;
            sEm_observ = string.Empty;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sSr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// Clase que contiene los elementos del arreglo incrementos, correspondiente a la tabla nsalarios (Clase NEmplea)
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Salario
    {
        [BsonElement("em_salant")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_salant { get; set; }

        [BsonElement("em_fecant")]
        public DateTime dtEm_fecant { get; set; }

        [BsonElement("em_salnew")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_salnew { get; set; }

        [BsonElement("em_feccam")]
        public DateTime dtEm_feccam { get; set; }

        [BsonElement("em_intant")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_intant { get; set; }

        [BsonElement("em_intnew")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_intnew { get; set; }

        [BsonElement("em_sdivant")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdivant { get; set; }

        [BsonElement("em_nivela")]
        public int iEm_nivela { get; set; }

        [BsonElement("em_puestoa")]
        public int iEm_puestoa { get; set; }

        /// <summary>
        /// Actualización
        /// </summary>
        [BsonElement("em_topes")]
        public bool bEm_topes { get; set; }

        [BsonElement("em_statimp")]
        public bool bEm_statimp { get; set; }

        [BsonElement("em_sdianiv")]
        public bool bEm_sdianiv { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        public mdl_Salario()
        {
            fEm_salant = 0.0m;
            dtEm_fecant = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            fEm_salnew = 0.0m;
            dtEm_feccam = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            fEm_intant = 0.0m;
            fEm_intnew = 0.0m;
            fEm_sdivant = 0.0m;
            iEm_nivela = 0;
            iEm_puestoa = 0;
            bEm_topes = false;
            bEm_statimp = false;
            bEm_sdianiv = false;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sSr_usuario = string.Empty;
        }
    }

    [BsonIgnoreExtraElements]
    public class mdl_DocumentosColaborador
    {
        [BsonElement("em_tipodoc")]
        public string sEm_tipodoc { get; set; }

        [BsonElement("em_iddocumento")]
        public string sEm_iddocumento { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        public mdl_DocumentosColaborador()
        {
            sEm_tipodoc = string.Empty;
            sEm_iddocumento = string.Empty;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sSr_usuario = string.Empty;
        }
    }

    [BsonIgnoreExtraElements]
    public class mdl_LineaTiempo
    {
        [BsonElement("em_fechaevento")]
        public DateTime dtEm_fechaevento { get; set; }

        [BsonElement("em_evento")]
        public string sEm_evento { get; set; }

        [BsonElement("em_datoevento")]
        public string sEm_datoevento { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        public mdl_LineaTiempo()
        {
            dtEm_fechaevento = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sEm_evento = string.Empty;
            sEm_datoevento = string.Empty;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sSr_usuario = string.Empty;
        }

    }

    /// <summary>
    /// Clase que contiene los elementos del arreglo conceptos, correspondiente a la tabla nemplepd (Clase NEmplea)
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_Conceptos
    {
        [BsonElement("pd_periodo")]
        public int iPd_periodo { get; set; }

        [BsonElement("pd_tiponom")]
        public string sPd_tiponom { get; set; }

        [BsonElement("pd_tipoemp")]
        public string sPd_tipoemp { get; set; }

        [BsonElement("pd_tipocon")]
        public string sPd_tipocon { get; set; }

        [BsonElement("pd_numero")]
        public int iPd_numero { get; set; }

        [BsonElement("pd_monto")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fPd_monto { get; set; }

        [BsonElement("pd_tiempo")]
        public string sPd_tiempo { get; set; }

        [BsonElement("pd_modelo")]
        public string sPd_modelo { get; set; }

        [BsonElement("pd_activi")]
        public string sPd_activi { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        public mdl_Conceptos()
        {
            iPd_periodo = 0;
            sPd_tiponom = string.Empty;
            sPd_tipoemp = string.Empty;
            sPd_tipocon = string.Empty;
            iPd_numero = 0;
            fPd_monto = 0.0m;
            sPd_tiempo = string.Empty;
            sPd_modelo = string.Empty;
            sPd_activi = string.Empty;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sSr_usuario = string.Empty;
        }
    }

    /// <summary>
    /// Definición de la tabla nempsdi
    /// </summary>
    [BsonIgnoreExtraElements]
    public class mdl_SDI
    {
        [BsonElement("em_intfec")]
        public DateTime dtEm_intfec { get; set; }

        [BsonElement("em_sdinew")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdinew { get; set; }

        [BsonElement("em_sdiant")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_sdiant { get; set; }

        [BsonElement("em_varnew")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_varnew { get; set; }

        [BsonElement("em_varant")]
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal fEm_varant { get; set; }

        [BsonElement("em_status")]
        public bool bEm_status { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        public mdl_SDI()
        {
            dtEm_intfec = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            fEm_sdinew = 0.0m;
            fEm_sdiant = 0.0m;
            fEm_varnew = 0.0m;
            fEm_varant = 0.0m;
            bEm_status = false;
            iSr_recno = 0;
            sSr_deleted = "0";
            dtSr_fecha = hlp_Formatos.ConvertirFechaUTC(new DateTime(1900, 1, 1, 0, 0, 0));
            sSr_usuario = string.Empty;
        }
    }
}
