using PoorMansPokedex.Core.Models;
using ApiVersion = PoorMansPokedex.Core.Models.Version;

namespace PoorMansPokedex.Test.MockingTools;

public static class PokedexEntryBuilder
{
    public static PokedexEntry CreateFullyPopulated()
    {
        return new PokedexEntry
        {
            Id = 1,
            Name = "bulbasaur",
            BaseExperience = 64,
            Height = 7,
            IsDefault = true,
            Order = 1,
            Weight = 69,
            LocationAreaEncounters = "https://pokeapi.co/api/v2/pokemon/1/encounters",
            Abilities =
            [
                new PokemonAbility
                {
                    IsHidden = false,
                    Slot = 1,
                    Ability = new Ability { Name = "overgrow", Url = "https://pokeapi.co/api/v2/ability/65/" }
                }
            ],
            PastAbilities =
            [
                new PastAbility
                {
                    Generation = new Generation { Name = "generation-iii", Url = "https://pokeapi.co/api/v2/generation/3/" },
                    Abilities = [new PokemonAbility { IsHidden = false, Slot = 1, Ability = new Ability { Name = "overgrow", Url = "https://pokeapi.co/api/v2/ability/65/" } }]
                }
            ],
            Forms = [new Form { Name = "bulbasaur", Url = "https://pokeapi.co/api/v2/pokemon-form/1/" }],
            GameIndices =
            [
                new GameIndexEntry
                {
                    GameIndexNumber = 1,
                    Version = new ApiVersion { Name = "red", Url = "https://pokeapi.co/api/v2/version/1/" }
                }
            ],
            HeldItems =
            [
                new HeldItem
                {
                    Item = new Item { Name = "oran-berry", Url = "https://pokeapi.co/api/v2/item/oran-berry/" },
                    VersionDetails = [new VersionDetail { Rarity = 5, Version = new ApiVersion { Name = "red", Url = "https://pokeapi.co/api/v2/version/1/" } }]
                }
            ],
            Moves =
            [
                new PokemonMove
                {
                    Move = new Move { Name = "tackle", Url = "https://pokeapi.co/api/v2/move/33/" },
                    VersionGroupDetails =
                    [
                        new VersionGroupDetail
                        {
                            LevelLearnedAt = 1,
                            VersionGroup = new VersionGroup { Name = "red-blue", Url = "https://pokeapi.co/api/v2/version-group/1/" },
                            MoveLearnMethod = new MoveLearnMethod { Name = "level-up", Url = "https://pokeapi.co/api/v2/move-learn-method/1/" },
                            Order = 1
                        }
                    ]
                }
            ],
            Species = new Species { Name = "bulbasaur", Url = "https://pokeapi.co/api/v2/pokemon-species/1/" },
            Sprites = new Sprites
            {
                BackDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/1.png",
                BackFemale = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/female/1.png",
                BackShiny = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/shiny/1.png",
                BackShinyFemale = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/shiny/female/1.png",
                FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png",
                FrontFemale = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/female/1.png",
                FrontShiny = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/shiny/1.png",
                FrontShinyFemale = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/shiny/female/1.png",
                Other = new OtherSprites
                {
                    Home = new Home { FrontDefault = "home.png", FrontFemale = "home-female.png", FrontShiny = "home-shiny.png", FrontShinyFemale = "home-shiny-female.png" },
                    Showdown = new Showdown { FrontDefault = "showdown.png", BackDefault = "showdown-back.png" },
                    DreamWorld = new DreamWorld { FrontDefault = "dream-world.png" },
                    OfficialArtwork = new OfficialArtwork { FrontDefault = "official-artwork.png", FrontShiny = "official-artwork-shiny.png" }
                },
                Versions = new SpritesVersions
                {
                    Generation1 = new Generation1
                    {
                        Yellow = new SpriteVariantGeneration1Yellow { FrontDefault = "yellow.png" }
                    }
                }
            },
            Cries = new Cries { Latest = "https://raw.githubusercontent.com/PokeAPI/cries/main/cries/pokemon/latest/1.ogg", Legacy = "https://raw.githubusercontent.com/PokeAPI/cries/main/cries/pokemon/legacy/1.ogg" },
            Stats =
            [
                new StatEntry { BaseStat = 45, Effort = 0, Stat = new Stat { Name = "hp", Url = "https://pokeapi.co/api/v2/stat/1/" } },
                new StatEntry { BaseStat = 49, Effort = 0, Stat = new Stat { Name = "attack", Url = "https://pokeapi.co/api/v2/stat/2/" } }
            ],
            PastStats =
            [
                new PastStatEntry
                {
                    Generation = new Generation { Name = "generation-i", Url = "https://pokeapi.co/api/v2/generation/1/" },
                    Stats = [new StatEntry { BaseStat = 45, Effort = 0, Stat = new Stat { Name = "hp", Url = "https://pokeapi.co/api/v2/stat/1/" } }]
                }
            ],
            Types =
            [
                new PokemonTypeSlot { Slot = 1, Type = new ElementalType { Name = "grass", Url = "https://pokeapi.co/api/v2/type/12/" } },
                new PokemonTypeSlot { Slot = 2, Type = new ElementalType { Name = "poison", Url = "https://pokeapi.co/api/v2/type/4/" } }
            ],
            PastTypes =
            [
                new PastType
                {
                    Generation = new Generation { Name = "generation-i", Url = "https://pokeapi.co/api/v2/generation/1/" },
                    Types = [new PokemonTypeSlot { Slot = 1, Type = new ElementalType { Name = "grass", Url = "https://pokeapi.co/api/v2/type/12/" } }]
                }
            ]
        };
    }

    public static PokedexEntry CreateMinimal()
    {
        return new PokedexEntry();
    }
}
