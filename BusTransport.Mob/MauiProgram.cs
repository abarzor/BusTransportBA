﻿using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;

namespace BusTransport.Mob
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

            // Add this line to configure lifecycle events
            builder.ConfigureLifecycleEvents(lifecycle =>
            {
#if ANDROID
            lifecycle.AddAndroid(android => android.OnCreate((activity, savedInstanceState) =>
            {
                HideStatusBar(activity);
            }));
#endif
            });

            return builder.Build();
        }

#if ANDROID
    private static void HideStatusBar(Android.App.Activity activity)
    {
        activity.Window.AddFlags(Android.Views.WindowManagerFlags.Fullscreen);
        activity.Window.ClearFlags(Android.Views.WindowManagerFlags.ForceNotFullscreen);
    }
#endif
    }
}