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
            var screamClient = serviceProvider.GetService<IScreamClient>();
            var screamCalculator = serviceProvider.GetService<IScreamCalculator>();
            var mainFlow = serviceProvider.GetService<IMainFlow>();
            mainFlow.BeginApp();


        }

        public static void ConfigureServices(IServiceCollection services)
        {

            services
                .AddScoped<ITaxCalculator, Calculator>()
                .AddScoped<IAliquot, Aliquot>()
                .AddScoped<IDeduction, Deduction>()
                .AddScoped<IClient, Client>()
                .AddScoped<IScreamClient, ScreamClient>()
                .AddScoped<IScreamCalculator, ScreamCalculator>()
                .AddScoped<IMainFlow, MainFlow>();


        }
    }
}
