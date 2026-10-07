using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PoorMansPokedex.Core;

namespace PoorMansPokedex.ViewModels;

public partial class PokedexViewModel : ObservableObject
{
    private readonly IPokeApiService pokeApiService;

    public PokedexViewModel(IPokeApiService pokeApiService)
    {
        this.pokeApiService = pokeApiService;
    }

    [ObservableProperty]
    private string id = string.Empty;

    [ObservableProperty]
    private string name = string.Empty;

    [ObservableProperty]
    private string searchText = string.Empty;

    [RelayCommand]
    private async Task SearchAsync(string? query)
    {
        var trimmedQuery = (query ?? this.SearchText).Trim();
        if (string.IsNullOrWhiteSpace(trimmedQuery))
        {
            return;
        }

        var entry = int.TryParse(trimmedQuery, out var id)
            ? await this.pokeApiService.PokedexEndpoint.GetEntryAsync(id)
            : await this.pokeApiService.PokedexEndpoint.GetEntryAsync(trimmedQuery);

        this.Name = entry.Name;
        this.Id = entry.Id.ToString();
    }
}
