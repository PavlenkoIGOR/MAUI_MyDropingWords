using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using MyDropingWords.Data;
using MyDropingWords.Pages;
using MyDropingWords.Services;
using MyDropingWords.Services.SQLServices;
using MyDropingWords.ViewModels;

namespace MyDropingWords
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
            
            builder.Services.AddTransient<AddNewWordPage>();
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<DictionaryPage>();
            builder.Services.AddTransient<DictionaryPageVM>();
            builder.Services.AddScoped<Repository>();
            builder.Services.AddSingleton<DBService>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
