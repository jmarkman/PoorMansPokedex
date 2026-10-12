using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PoorMansPokedex.Core;

namespace PoorMansPokedex.ViewModels;

public partial class PokedexViewModel : ObservableObject
{
    private readonly IPokeApiService pokeApiService;

    [ObservableProperty]
    private int id;

    [ObservableProperty]
    private string name = string.Empty;

    [ObservableProperty]
    private string types = string.Empty;

    [ObservableProperty]
    private int baseExperience;

    [ObservableProperty]
    private int hp;

    [ObservableProperty]
    private int attack;

    [ObservableProperty]
    private int defense;

    [ObservableProperty]
    private int specialAttack;

    [ObservableProperty]
    private int specialDefense;

    [ObservableProperty]
    private int speed;

    [ObservableProperty]
    private BitmapImage? officialArtwork;

    [ObservableProperty]
    private string searchText = string.Empty;

    public PokedexViewModel(IPokeApiService pokeApiService)
    {
        ArgumentNullException.ThrowIfNull(pokeApiService);
        this.pokeApiService = pokeApiService;
    }

    [RelayCommand]
    private async Task SearchAsync()
    {
        var entry = int.TryParse(this.SearchText, out var id)
            ? await this.pokeApiService.PokedexEndpoint.GetEntryAsync(id)
            : await this.pokeApiService.PokedexEndpoint.GetEntryAsync(this.SearchText);

        var stats = entry.Stats.ToDictionary(statEntry => statEntry.Stat.Name, statEntry => statEntry.BaseStat);
        var hp = stats["hp"];
        var attack = stats["attack"];
        var defense = stats["defense"];
        var specialAttack = stats["special-attack"];
        var specialDefense = stats["special-defense"];
        var speed = stats["speed"];
        var artworkUrl = entry.Sprites.Other.OfficialArtwork.FrontDefault;
        var officialArtwork = string.IsNullOrWhiteSpace(artworkUrl)
            ? null
            : new BitmapImage(new Uri(artworkUrl, UriKind.Absolute));

        this.Id = entry.Id;
        this.Name = entry.Name;
        this.Types = string.Join("/", entry.Types.OrderBy(typeSlot => typeSlot.Slot).Select(typeSlot => typeSlot.Type.Name));
        this.BaseExperience = entry.BaseExperience;
        this.Hp = hp;
        this.Attack = attack;
        this.Defense = defense;
        this.SpecialAttack = specialAttack;
        this.SpecialDefense = specialDefense;
        this.Speed = speed;
        this.OfficialArtwork = officialArtwork;
    }
}
