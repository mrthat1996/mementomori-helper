using System.Globalization;
using MementoMori;
using MementoMori.Common;
using MementoMori.Jobs;
using MementoMori.Option;
using MementoMori.WebUI.ViewModels;
using MudBlazor.Services;
using MementoMori.WebUI.Extensions;
using Quartz;
using ReactiveUI;
using MementoMori.WebUI;
using MementoMori.WebUI.Pages;

internal class Program
{
    public static void Main(string[] args)
    {
        PlatformRegistrationManager.SetRegistrationNamespaces(RegistrationNamespace.Blazor);
        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration.AddJsonFile("appsettings.other.json", true, true);
        builder.Configuration.AddJsonFile("appsettings.user.json", true, true);

        builder.Services.AddMudServices();

        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        //builder.Services.AddRazorPages();
        //builder.Services.AddServerSideBlazor();
        builder.Services.AddSingleton<TimeManager>();
        builder.Services.AddSingleton<MementoNetworkManager>();
        builder.Services.AddSingleton<MementoMoriFuncs>();
        builder.Services.AddSingleton<TimeZoneAwareJobRegister>();

        builder.Services.AddOptions();
        builder.Services.ConfigureWritable<AuthOption>(builder.Configuration.GetSection("AuthOption"), "appsettings.user.json");
        builder.Services.ConfigureWritable<GameConfig>(builder.Configuration.GetSection("GameConfig"), "appsettings.user.json");

        builder.Services.AddQuartz();
        builder.Services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);

        var app = builder.Build();
        Services.Setup(app.Services);

        app.Services.GetService<MementoNetworkManager>().DownloadMasterCatalog(CultureInfo.CurrentCulture).ConfigureAwait(false).GetAwaiter().GetResult();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment()) app.UseExceptionHandler("/Error");

        app.UseStaticFiles();
        app.UseAntiforgery();
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        //app.UseRouting();

        //app.MapBlazorHub();
        //app.MapFallbackToPage("/_Host");

        app.Services.GetService<MementoMoriFuncs>().AutoLogin().ConfigureAwait(false).GetAwaiter().GetResult();

        app.Run();
    }
}