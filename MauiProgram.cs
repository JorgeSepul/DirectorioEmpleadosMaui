using DirectorioEmpleadosMawi.Models;
using DirectorioEmpleadosMawi.Service;
using DirectorioEmpleadosMawi.ViewModels;
using DirectorioEmpleadosMawi.Views;
using Microsoft.Extensions.Logging;

namespace DirectorioEmpleadosMawi
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
                    //Añadimos esta fuente para poder poner los iconos en el menu lateral y en las cards. En WPF era con SEGOE pero en MAUI no funciona, asi que he buscado una alternativa y es esta.
                    fonts.AddFont("fa-solid-900.ttf", "FontAwesome 6 Free Solid");
                });
          

            builder.Logging.AddDebug(); 
            builder.Services.AddSingleton<IRepositoryService<Sede>, SedeService>();
            builder.Services.AddTransient<SedeViewModel>();
            builder.Services.AddTransient<HeadQuartersPage>();

            builder.Services.AddSingleton<IRepositoryService<Departamento>, DepartamentoService>();
            builder.Services.AddTransient<DepartamentoViewModel>();
            builder.Services.AddTransient<DepartmentsPage>();

            builder.Services.AddSingleton<IRepositoryService<Empleado>, EmpleadoService>();
            builder.Services.AddTransient<EmployeeViewModel>();
            builder.Services.AddTransient<EmployeesPage>();

            builder.Services.AddTransient<EmpleadoDetalleViewModel>();
            builder.Services.AddTransient<EmployeeDetailPage>();

            return builder.Build();
        }

    }
}
