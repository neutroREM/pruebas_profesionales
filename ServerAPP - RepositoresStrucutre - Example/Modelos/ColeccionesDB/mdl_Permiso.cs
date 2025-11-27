using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace certinom_sadper_v1.Modelos.ColeccionesDB
{
    public class mdl_Permiso
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("RfcEmpresa")]
        public string sRfcEmpresa { get; set; }

        [BsonElement("RfcUsuario")]
        public string sRfcUsuario { get; set; }

        /// <summary>
        /// Nombre de la plataforma utilizada
        /// </summary>
        [BsonElement("Plataforma")]
        public string sPlataforma { get; set; }

        /// <summary>
        /// Tipo de usuario
        /// </summary>
        [BsonElement("TipoUser")]
        public string sTipoUser { get; set; }

        /// <summary>
        /// Lista de módulos permitidos
        /// </summary>
        [BsonElement("Modulos")]
        public List<Modulo>? lstModulo { get; set; }

        [BsonElement("sr_recno")]
        public long iSr_recno { get; set; }

        [BsonElement("sr_deleted")]
        public string sSr_deleted { get; set; }

        [BsonElement("sr_fecha")]
        public DateTime? dtSr_fecha { get; set; }

        [BsonElement("sr_usuario")]
        public string sSr_usuario { get; set; }

        public mdl_Permiso()
        {
            Id = ObjectId.GenerateNewId().ToString();
            sSr_deleted = "0";
            dtSr_fecha = new DateTime(1900, 01, 01);
            iSr_recno = 0;
            sSr_usuario = string.Empty;
            lstModulo = new List<Modulo>();
        }
    }

    public class mdl_PropiedadesModulo
    {
        [BsonElement("Numeracion")]
        public int iNumeracion { get; set; }

        /// <summary>
        /// Nombre del módulo con formato de búsqueda
        /// Sidebar: Titulo
        /// </summary>
        [BsonElement("Busqueda")]
        public string? sBusqueda { get; set; }

        /// <summary>
        /// Autorización del módulo
        /// </summary>
        [BsonElement("Autorizado")]
        public bool bAutorizado { get; set; }


        /// <summary>
        /// Es visible en la sidebar
        /// </summary>
        [BsonElement("EsVisible")]
        public bool bEsVisible { get; set; }

        /// <summary>
        /// Si la Opción tiene privilegios
        /// </summary>
        [BsonElement("TienePrivilegios")]
        public bool bTienePrivilegios { get; set; }

        [BsonElement("EsPorPago")]
        public bool bEsPorPago { get; set; }

        /// <summary>
        /// Privilegios
        /// 0. Todos
        /// 1. Lectura
        /// 2. Escritura
        /// </summary>
        [BsonElement("Privilegio")]
        public int iPrivilegio { get; set; }

        public mdl_PropiedadesModulo()
        {
            bEsPorPago = false;
        }
    }

    public class Modulo : mdl_PropiedadesModulo
    {
        /// <summary>
        /// Nombre del módulo
        /// Sidebar: Url
        /// </summary>
        [BsonElement("Modulo")]
        public string? sModulo { get; set; }

        /// <summary>
        /// Lista de submódulos
        /// </summary>
        [BsonElement("Submodulos")]
        public List<Submodulo>? lstSubmodulo { get; set; }

        public Modulo()
        {
            lstSubmodulo = new List<Submodulo>();
        }
    }
    public class Submodulo : mdl_PropiedadesModulo
    {
        /// <summary>
        /// Nombre del submódulo 
        /// </summary>
        [BsonElement("Submodulo")]
        public string? sSubmodulo { get; set; } = null!;

        /// <summary>
        /// Lista de opciones 
        /// </summary>
        [BsonElement("Opciones")]
        public List<Opcion>? lstOpcion { get; set; }

        public Submodulo()
        {
            lstOpcion = new List<Opcion>();
        }
    }
    public class Opcion : mdl_PropiedadesModulo
    {
        /// <summary>
        /// Nombre de la opción
        /// </summary>
        [BsonElement("Opcion")]
        public string? sOpcion { get; set; }
    }
}

