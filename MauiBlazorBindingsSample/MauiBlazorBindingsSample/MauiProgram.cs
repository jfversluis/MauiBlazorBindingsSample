﻿using BlazorBindings.Maui;

namespace MauiBlazorBindingsSample {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<BlazorBindingsApplication<AppShell>>()
                .UseMauiBlazorBindings()
                .ConfigureFonts(fonts => {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            return builder.Build();
        }
    }
}