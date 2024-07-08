using Microsoft.Extensions.Logging;
using ProyectoFinal.Models;
using ProyectoFinal.ViewModels.Agente;
using ProyectoFinal.ViewModels.Camara;
using ProyectoFinal.ViewModels.Logics;
using ProyectoFinal.ViewModels.Persona;
using ProyectoFinal.ViewModels.Rol;
using ProyectoFinal.ViewModels.Siniestro;
using ProyectoFinal.ViewModels.Zona;
using ProyectoFinal.Views.Agente;
using ProyectoFinal.Views.Camara;
using ProyectoFinal.Views.Main;
using ProyectoFinal.Views.Persona;
using ProyectoFinal.Views.Role;
using ProyectoFinal.Views.Siniestro;
using ProyectoFinal.Views.Zona;

namespace ProyectoFinal
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("FAsomeSolid.otf", "AwesomeSolid");
                });
            /*carga paginas-funcionalidad*/
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<LoginPageViewModel>();
            /*carga paginas-vista-persona*/
            builder.Services.AddSingleton<PersonaViewModel>();
            builder.Services.AddSingleton<AddPersonsaPage>();
            /*carga paginas-vista-roles*/
            builder.Services.AddSingleton<RolViewModel>();
            builder.Services.AddSingleton<AddRolePage>();
            /*carga paginas-vista-zona*/
            builder.Services.AddSingleton<ZonaViewModel>();
            builder.Services.AddSingleton<AddZonaPage>();
            /*carga paginas-vista-camaras-ecu911*/
            builder.Services.AddSingleton<CamaraViewModel>();
            builder.Services.AddSingleton<AddCamaraPage>();
            /*carga paginas-vista-agente*/
            builder.Services.AddSingleton<AgenteViewModel>();
            builder.Services.AddSingleton<AddAgentePage>();
            /*carga paginas-vista-siniestro*/
            builder.Services.AddSingleton<SiniestroViewModel>();
            builder.Services.AddSingleton<AddSiniestroPage>();




#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
