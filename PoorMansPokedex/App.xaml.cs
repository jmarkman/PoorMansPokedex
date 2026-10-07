using System.Net.Http;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using PoorMansPokedex.Core;
using PoorMansPokedex.ViewModels;

namespace PoorMansPokedex;

public partial class App : Application
{
    public static IServiceProvider Services { get; private set; } = null!;

    public App()
    {
        var services = new ServiceCollection();

        services.AddHttpClient(nameof(PokeApiService), client =>
        {
            client.BaseAddress = new Uri("https://pokeapi.co/api/v2/");
        });

        services.AddScoped(provider => provider
            .GetRequiredService<IHttpClientFactory>()
            .CreateClient(nameof(PokeApiService)));

        services.AddScoped<IPokeApiService, PokeApiService>();
        services.AddScoped<PokedexViewModel>();
        services.AddScoped<MainWindow>();

        Services = services.BuildServiceProvider();
    }

    private void Application_Startup(object sender, StartupEventArgs e)
    {
        var window = Services.GetRequiredService<MainWindow>();
        window.Show();
    }
}
