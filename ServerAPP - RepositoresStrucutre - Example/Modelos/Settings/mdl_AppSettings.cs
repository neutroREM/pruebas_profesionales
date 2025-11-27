namespace certinom_sadper_v1.Modelos.Settings
{
    public class mdl_AppSettings
    {
        public string sTESTPASSWORD { get; set; } = string.Empty;
        public string sEncryptionKey { get; set; } = string.Empty;
        //public mdl_SignalRConnection oSignalRConnection { get; set; }
        //public mdl_RouteDirectories oRouteDirectories { get; set; }
        //public mdl_URLServices oURLServices { get; set; }   
        //public mdl_CredentialServices oCredentialServices { get; set; } 


        //public mdl_AppSettings()
        //{
            //sTESTPASSWORD = string.Empty;
            //sEncryptionKey = string.Empty;
            //oSignalRConnection = new mdl_SignalRConnection();
            //oRouteDirectories = new mdl_RouteDirectories();
            //oURLServices = new mdl_URLServices();
            //oCredentialServices = new mdl_CredentialServices(); 
        //}
    }


    public class mdl_SignalRConnection
    {
        public string sSignalRHub { get; set; } = string.Empty;
        public string sSignalRHubTimbrado { get; set; } = string.Empty;

    }


    public class mdl_RouteDirectories
    {
        public string sRutaArchivoTemp { get; set; } = string.Empty;
        public string sRutaArchivoTemp2 { get; set; } = string.Empty;
        public string sRutaFormatoTimbrado { get; set; } = string.Empty;
        public string sRutaFontsTimbrado { get; set; } = string.Empty;
        public string sRutaImagenCorreoNomina { get; set; } = string.Empty;

        //public mdl_RouteDirectories()
        //{
        //    sRutaArchivoTemp = string.Empty;
        //    sRutaArchivoTemp2 = string.Empty;
        //    sRutaFormatoTimbrado = string.Empty;
        //    sRutaFontsTimbrado = string.Empty;
        //    sRutaImagenCorreoNomina = string.Empty;
        //}
    }

    public class mdl_URLServices
    {
        public string sServicioPrimarioP { get; set; } = string.Empty;
        public string sServicioSecundarioP { get; set; } = string.Empty;
        public string sServicioPrimarioT { get; set; } = string.Empty;
        public string sServicioSecundarioT { get; set; } = string.Empty;

        //public mdl_URLServices()
        //{
        //    sServicioPrimarioP = string.Empty;
        //    sServicioSecundarioP = string.Empty;
        //    sServicioPrimarioT = string.Empty;
        //    sServicioSecundarioT = string.Empty;
        //}
    }

    public class mdl_CredentialServices
    {
        public string sCredentialServices { get; set; } = string.Empty;
        public string sPasswordTimbradoService { get; set; } = string.Empty;
        public string sClaveSOAPublicarNomina { get; set; } = string.Empty;
        public string sPasswordSOAPublicarNomina { get; set; } = string.Empty;
        public string sCorreoTimbrado { get; set; } = string.Empty;
        public string sPasswordTimbrado { get; set; } = string.Empty;

        //public mdl_CredentialServices()
        //{
        //    sCredentialServices = string.Empty;
        //    sPasswordTimbradoService = string.Empty;
        //    sClaveSOAPublicarNomina = string.Empty;
        //    sPasswordSOAPublicarNomina = string.Empty;
        //    sCorreoTimbrado = string.Empty;
        //    sPasswordTimbrado = string.Empty;
        //}


    }
}
