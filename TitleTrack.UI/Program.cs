using System;
using Avalonia;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TitleTrack.Application.Services;
using TitleTrack.Domain.Interfaces;
using TitleTrack.Infrastructure.Data;
using TitleTrack.Infrastructure.Repositories;
using TitleTrack.UI.ViewModels;
using TitleTrack.UI.Views;

namespace TitleTrack.UI
{
    internal sealed class Program
    {
        public static IServiceProvider Services;
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>();
            services.AddScoped<ITitleAbstractRepository, TitleAbstractRepository>();
            services.AddScoped<TitleAbstractService>();

            services.AddTransient<MainWindowViewModel>();
            services.AddTransient<MainWindow>();

            Services = services.BuildServiceProvider();

            using (var scope = Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                db.Database.Migrate();
            }

            BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);
        }

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .WithInterFont()
                .LogToTrace();
    }
}
