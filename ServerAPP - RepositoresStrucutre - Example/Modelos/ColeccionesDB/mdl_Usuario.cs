using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace certinom_sadper_v1.Modelos.ColeccionesDB
{
    [BsonIgnoreExtraElements]
    public class mdl_Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        /// <summary>
        /// Nombre real del usuario
        /// </summary>
        [BsonElement("Nombre")]
        public string sNombre { get; set; }

        /// <summary>
        /// Nombre de usuario
        /// </summary>
        [BsonElement("RfcUsuario")]
        [Required(ErrorMessage = "RFC de usuario obligatorio")]
        public string sRfcUsuario { get; set; }

        /// <summary>
        /// Email de usuario
        /// </summary>
        [BsonElement("EmailUsuario")]
        public string sEmailUsuario { get; set; }

        /// <summary>
        /// Telefono Usuario
        /// </summary>
        [BsonElement("TelefonoUsuario")]
        public string sTelefonoUsuario { get; set; }

        /// <summary>
        /// Celular Usuario
        /// </summary>
        [BsonElement("CelularUsuario")]
        public string sCelularUsuario { get; set; }

        /// <summary>
        /// Fecha de Alta del Usuario
        /// </summary>
        [BsonElement("FechaAlta")]
        public DateTime? dtFechaAlta { get; set; }

        /// <summary>
        /// Dias en los que expira la contraseña
        /// Este campo es para mostrar en la configuración
        /// </summary>
        [BsonElement("DiasExpiraPassword")]
        public int iDiasExpiraPassword { get; set; }

        /// <summary>
        /// Clave de acceso
        /// </summary>
        [BsonElement("Password")]
        [Required(ErrorMessage = "Contraseña obligatoria")]
        public string sPassword { get; set; }

        [BsonElement("FechaExpiracionPassword")]
        public DateTime? dtFechaExpiracionPassword { get; set; }

        /// <summary>
        /// Lista de empresas disponibles para el acceso
        /// </summary>
        [BsonElement("EmpresasAcceso")]
        public List<string> lstEmpresaAcceso { get; set; }

        /// <summary>
        /// Indica si la contraseña fue restablecida por el administrador.
        /// </summary>
        [BsonElement("CambioPasswordPorAdmin")]
        public bool bCambioPasswordPorAdmin { get; set; }

        /// <summary>
        /// Para saber si el usuario tiene activada la opcion de
        /// autentificacion por doble factor
        /// </summary>
        [BsonElement("AutentificacionDobleFactor")]
        public bool bAutentificacionDobleFactor { get; set; }

        /// <summary>
        /// Para saber si el usuario teine activada la opcion de
        /// Autentificacion por codigo QR
        /// </summary>
        [BsonElement("AutentificacionCodigoQR")]
        public bool bAutentificacionCodigoQR { get; set; }

        /// <summary>
        /// Indica si el usuario está suspendido.
        /// </summary>
        [BsonElement("sr_suspended")]
        public bool bSr_suspended { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime? dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }
        public string Token { get; set; } = null!;
        public mdl_Usuario()
        {
            iSr_recno = 0;
            sSr_deleted = "0";
            sSr_usuario = string.Empty;
            dtSr_fecha = new DateTime(1900, 01, 01);
            bSr_suspended = false;
        }
    }

    public class mdl_UsuarioAuth
    {
        public string NombreUsuario { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Token { get; set; } = null!;
        public string? EmpresaAcceso { get; set; }
        public string? EmpresaAccesoNombre { get; set; }
        public bool MultiEmpresa { get; set; }
        public mdl_Permiso Permisos { get; set; } = null!;
    }

    public class mdl_Bloqueo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        /// <summary>
        /// IP del usuario
        /// </summary>
        public string IpAcceso { get; set; }

        public string Plataforma { get; set; } = "Nomina";

        /// <summary>
        /// Desde qué aplicación viene el bloqueo
        /// </summary>
        public string Origen { get; set; } = "SADPERNomina-Login";

        /// <summary>
        /// Si el bloqueo es permanente o no
        /// Sólo aplican bloqueos desde el panel
        /// </summary>
        public bool EsPermanente { get; set; } = false;

        /// <summary>
        /// Cuando se genera un bloqueo permanente desde
        /// el panel especificar la razón de bloqueo
        /// </summary>
        public string RazonBloqueo { get; set; } = string.Empty;

        /// <summary>
        /// Nombre de usuario
        /// </summary>
        public string? Usuario { get; set; }

        /// <summary>
        /// Fecha y hora del bloqueo
        /// </summary>
        public DateTime FechaHora { get; set; }
    }
}
