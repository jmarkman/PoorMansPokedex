using PoorMansPokedex.Core.Models;
using PokeApiVersion = PoorMansPokedex.Core.Models.Version;

namespace PoorMansPokedex.Test.MockingTools;

public static class PokedexEntryBuilder
{
    public static PokedexEntry CreateMinimal()
    {
        return new PokedexEntry
        {
            Id = 1,
            Name = "bulbasaur",
            Species = new Species { Name = "bulbasaur" }
        };
    }

    public static PokedexEntry CreateFullyPopulated()
    {
        return new PokedexEntry
        {
            Id = 25,
            Name = "pikachu",
            BaseExperience = 112,
            Height = 4,
            IsDefault = true,
            Order = 35,
            Weight = 60,
            LocationAreaEncounters = "https://pokeapi.co/api/v2/pokemon/25/encounters",
            Abilities =
            [
                new PokemonAbility
                {
                    IsHidden = true,
                    Slot = 1,
                    Ability = new Ability { Name = "static", Url = "https://pokeapi.co/api/v2/ability/9/" }
                }
            ],
            PastAbilities =
            [
                new PastAbility
                {
                    Generation = new Generation { Name = "generation-iii" },
                    Abilities =
                    [
                        new PokemonAbility { IsHidden = false, Slot = 1, Ability = null }
                    ]
                }
            ],
            Forms =
            [
                new Form { Name = "pikachu", Url = "https://pokeapi.co/api/v2/pokemon-form/25/" }
            ],
            GameIndices =
            [
                new GameIndex { Index = 25, Version = new PokeApiVersion { Name = "red" } }
            ],
            HeldItems =
            [
                new HeldItem
                {
                    Item = new Item { Name = "light-ball" },
                    VersionDetails =
                    [
                        new ItemVersionDetail { Rarity = 5, Version = new PokeApiVersion { Name = "sword" } }
                    ]
                }
            ],
            Moves =
            [
                new PokemonMove
                {
                    Move = new Move { Name = "thunder-shock" },
                    VersionGroupDetails =
                    [
                        new PokemonMoveVersionGroupDetail
                        {
                            LevelLearnedAt = 1,
                            VersionGroup = new VersionGroup { Name = "red-blue" },
                            MoveLearnMethod = new MoveLearnMethod { Name = "level-up" },
                            Order = 1
                        }
                    ]
                }
            ],
            Species = new Species
            {
                Name = "pikachu",
                Url = "https://pokeapi.co/api/v2/pokemon-species/25/"
            },
            Sprites = new Sprites { FrontDefault = "pikachu.png" },
            Cries = new Cries { Latest = "pikachu.ogg", Legacy = "pikachu-old.ogg" },
            Stats =
            [
                new PokemonStat
                {
                    BaseStat = 35,
                    Effort = 0,
                    Stat = new Stat { Name = "hp" }
                }
            ],
            PastStats =
            [
                new PastStat
                {
                    Generation = new Generation { Name = "generation-i" },
                    Stats =
                    [
                        new PokemonStat { BaseStat = 90, Stat = new Stat { Name = "special" } }
                    ]
                }
            ],
            Types =
            [
                new PokemonTypeSlot { Slot = 1, Type = new ElementType { Name = "electric" } }
            ],
            PastTypes =
            [
                new PastType
                {
                    Generation = new Generation { Name = "generation-i" },
                    Types =
                    [
                        new PokemonTypeSlot { Slot = 1, Type = new ElementType { Name = "normal" } }
                    ]
                }
            ]
        };
    }

    public static PokedexEntry CreateWithEmptyCollections()
    {
        return new PokedexEntry
        {
            Abilities = [],
            PastAbilities = [],
            Forms = [],
            GameIndices = [],
            HeldItems = [],
            Moves = [],
            Stats = [],
            PastStats = [],
            Types = [],
            PastTypes = []
        };
    }

    public static PokedexEntry CreateWithNullableNestedData()
    {
        return new PokedexEntry
        {
            Abilities = [new PokemonAbility { Ability = null }],
            Sprites = new Sprites
            {
                FrontDefault = null,
                Other = null,
                Versions = null
            },
            Cries = new Cries { Latest = null, Legacy = null }
        };
    }
}
