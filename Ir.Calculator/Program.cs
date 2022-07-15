using IrCalculator.Presentation.Screm;
using IrCalculator.Servies;
using IrCalculator.Servies.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace IrCalculator.Presentation
{
    public class Program
    {

        public static void Main()
        {
            ServiceCollection services = new();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            var calculator = serviceProvider.GetService<ITaxCalculator>();
            var aliquot = serviceProvider.GetService<IAliquot>();
            var deduction = serviceProvider.GetService<IDeduction>();
            var client = serviceProvider.GetService<IClient>();
            var screamClient = serviceProvider.GetService<IScreenClient>();
            var screamCalculator = serviceProvider.GetService<IScreenCalculator>();
            var mainFlow = serviceProvider.GetService<IMainFlow>();
            var screamMenu = serviceProvider.GetService<IScreenMenu>();
            mainFlow.BeginApp();


        }

        public static void ConfigureServices(IServiceCollection services)
        {

            services
                .AddScoped<ITaxCalculator, Calculator>()
                .AddScoped<IAliquot, Aliquot>()
                .AddScoped<IDeduction, Deduction>()
                .AddScoped<IClient, Client>()
                .AddScoped<IScreenClient, ScreenClient>()
                .AddScoped<IScreenCalculator, ScreenCalculator>()
                .AddScoped<IMainFlow, MainFlow>()
                .AddScoped<IScreenMenu, ScreenMenu>();


        }
    }
}
