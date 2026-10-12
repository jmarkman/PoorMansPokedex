using System.Net.Http;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using PoorMansPokedex.Core;
using PoorMansPokedex.ViewModels;

namespace PoorMansPokedex;

public partial class App : Application
{
    private ServiceProvider? serviceProvider;

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        this.serviceProvider = new ServiceCollection()
            .AddSingleton(new HttpClient
            {
                BaseAddress = new Uri("https://pokeapi.co/api/v2/")
            })
            .AddSingleton<IPokeApiService, PokeApiService>()
            .AddSingleton<PokedexViewModel>()
            .AddSingleton<MainWindow>()
            .BuildServiceProvider();

        this.MainWindow = this.serviceProvider.GetRequiredService<MainWindow>();
        this.MainWindow.Show();
    }

    protected override void OnExit(ExitEventArgs e)
    {
        this.serviceProvider?.Dispose();
        base.OnExit(e);
    }
}
