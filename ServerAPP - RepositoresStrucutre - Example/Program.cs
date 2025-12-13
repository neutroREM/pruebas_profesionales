using certinom_sadper_v1.Data.Factories;
using certinom_sadper_v1.Data.Repositories;
using certinom_sadper_v1.Data.Repositories.Interfaces;
using certinom_sadper_v1.Data.Services;
using certinom_sadper_v1.Helper;
using certinom_sadper_v1.Modelos.Settings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using ServerAPP___RepositoresStrucutre___Example.Components;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

#region .settings
builder.Services.Configure<mdl_MongoDBSettings>(
    builder.Configuration.GetSection("MongoConnectionStrings"));

builder.Services.Configure<mdl_JwtSettings>(
    builder.Configuration.GetSection("JwtSettings"));

builder.Services.Configure<mdl_RouteDirectories>(
    builder.Configuration.GetSection("RouteDirectories"));

builder.Services.Configure<mdl_URLServices>(
    builder.Configuration.GetSection("URLServices"));

builder.Services.Configure<mdl_CredentialServices>(
    builder.Configuration.GetSection("CredentialServices"));

builder.Services.Configure<mdl_AppSettings>(builder.Configuration);
#endregion

#region factories (DBContextAccess)
builder.Services.AddSingleton<IAccessDBContextFactory, AccessDBContextFactory>();
builder.Services.AddSingleton<IMongoDBContextFactory, MongoDBContextFactory>();
#endregion

#region helpers
builder.Services
    .AddScoped<hlp_Formatos>()
    .AddScoped<hlp_FormularioConsulta>();
#endregion

#region repositories
// Registra el repositorio de acceso, inyectando la fábrica de ACCESO.
builder.Services.AddScoped<IUserAccessRepository>(provider =>
    new UserAccessRepository(
        provider.GetRequiredService<IAccessDBContextFactory>(),
        provider.GetRequiredService<ILogger<UserAccessRepository>>()
    )
);

// Registra el repositorio de empresa, inyectando la fábrica del INQUILINO.
builder.Services.AddScoped<INEmpresaRepository>(provider =>
    new NEmpresaRepository(
        provider.GetRequiredService<IMongoDBContextFactory>(),
        provider.GetRequiredService<ILogger<NEmpresaRepository>>()
    )
);

builder.Services.AddScoped<INParcalRepository>(provider =>
    new NParcalRepository(
        provider.GetRequiredService<IMongoDBContextFactory>(),
        provider.GetRequiredService<ILogger<NParcalRepository>>()
    )
);
#endregion

#region services
// Services
builder.Services
    .AddScoped<IAccessService, AccessService>()
    .AddScoped<IAuthService, AuthService>()
    .AddScoped<INEmpresaService, NEmpresaService>()
    .AddScoped<INParcalService, NParcalService>()

    //.AddScoped<INReporteNominaService, NReporteNominaService>()
    .AddScoped<IAdicionarFoliosTimbrarService, AdicionarFoliosTimbrarService>()
    .AddScoped<ICambiarXMLTimbradoService, CambiarXMLTimbradoService>()
    .AddScoped<ICancelarXMLService, CancelarXMLService>()
    .AddScoped<ICierreAnualOperacionesService, CierreAnualOperacionesService>()
    .AddScoped<IConsultaRecibosService, ConsultaRecibosService>()
    .AddScoped<IConsultarTimbresDisponiblesService, ConsultarTimbresDisponiblesService>()
    .AddScoped<IConvertirXMLSFTPService, ConvertirXMLSFTPService>()
    .AddScoped<ICrearPDFNominaService, CrearPDFNominaService>()
    .AddScoped<IDefinirPeriodoService, DefinirPeriodoService>()
    .AddScoped<IEnviarCorreoElectronicoService, EnviarCorreoElectronicoService>()
    .AddScoped<IExportarResumenExcelService, ExportarResumenExcelService>()
    .AddScoped<IImportarFiniquitoIndemnizacionService, ImportarFiniquitoIndemnizacionService>()
    .AddScoped<IImportarPeriodoService, ImportarPeriodoService>()
    .AddScoped<IImportarTextoService, ImportarTextoService>()
    .AddScoped<IImportarValesService, ImportarValesService>()
    .AddScoped<IImportarViaticosService, ImportarViaticosService>()
    .AddScoped<IInformacionColaboradorService, InformacionColaboradorService>()
    .AddScoped<IManualSistemaService, ManualSistemaService>()
    .AddScoped<IReasignarConstraseniaService, ReasignarConstraseniaService>()
    .AddScoped<IRecibosNoTimbradosService, RecibosNoTimbradosService>()
    .AddScoped<IReportarProblemaService, ReportarProblemaService>()
    .AddScoped<ISucursalesService, SucursalesService>()
    .AddScoped<ITimbrarPeriodoService, TimbrarPeriodoService>()
    .AddScoped<IVerificarCodigosPostalesService, VerificarCodigosPostalesService>()
    .AddScoped<INotificacionService, NotificacionService>();

#endregion

#region jwt
var secretKey = Encoding.ASCII.GetBytes(builder.Configuration["JwtSettings:SecretKey"]!);
builder.Services.Configure<mdl_JwtSettings>(builder.Configuration.GetSection("JwtSettings"));

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(secretKey),
            ClockSkew = TimeSpan.Zero
        };
        // JWT para SignalR
        options.Events = new JwtBearerEvents
        {
            OnMessageReceived = context =>
            {
                var accessToken = context.Request.Query["access_token"];
                var path = context.HttpContext.Request.Path;
                if (!string.IsNullOrEmpty(accessToken) && path.StartsWithSegments("/usuariosHub"))
                {
                    context.Token = accessToken;
                }
                return Task.CompletedTask;
            }
        };
    });

#endregion

builder.Services.AddAuthorization();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//builder.Services.AddBlazoredSessionStorage();

builder.Services.AddHttpClient();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

if (!app.Environment.IsDevelopment())
{
    // Configure the HTTP request pipeline.
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
