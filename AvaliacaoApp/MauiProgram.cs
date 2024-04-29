
using AvaliacaoApp.Models;
using AvaliacaoApp.ViewModels;
using AvaliacaoApp.Views;
using Microsoft.Extensions.Logging;

namespace AvaliacaoApp
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);            
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<SobrePage>();
            builder.Services.AddSingleton<CadastroProdutorPage>();
            builder.Services.AddSingleton<CadastroProdutorModel>();
            builder.Services.AddSingleton<ListarProdutorPage>();
            builder.Services.AddTransient<DetalhesProdutor>();
            builder.Services.AddTransient<DetalhesProdutorModel>();


            return builder.Build();
        }
    }
}
