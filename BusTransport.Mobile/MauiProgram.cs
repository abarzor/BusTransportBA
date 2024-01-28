using BusTransport.Mobile.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls;
using System.Runtime.Intrinsics.X86;
using BusTransport.Mobile.Views;

namespace BusTransport.Mobile
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
            builder.Services.AddSingleton<IAuthenticationService, AuthenticationService>();
            builder.Services.AddTransient<LoginPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

//Step 4: Setup MainPage with Tabs

//Step 5: Navigation from Login to MainPage