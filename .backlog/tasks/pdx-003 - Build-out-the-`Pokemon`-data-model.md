---
id: PDX-003
title: Build out the `Pokemon` data model
status: To Do
assignee: []
created_date: '2026-09-21 19:25'
labels: []
dependencies: []
ordinal: 3000
---

## Description

<!-- SECTION:DESCRIPTION:BEGIN -->
In `PoorMansPokedex.Core.Models.Pokemon`, add autoproperties to the class. Use the `[JsonPropertyName]` attribute from `System.Text.Json` to designate which C# property should receive the value from the JSON property. The JSON property, the C# property, and the type of the C# property are denoted below as bulletpoints, and the nested bulletpoint for each is the docstring for the property.

- JSON: `id`, Property: `Id`, Type: `int`
  - The creature's numeric identifier within the API which doubles as their numeric identifier in the official Pokemon roster
- JSON: `name`, Property: `Name`, Type `string`
  - The name of the creature
- JSON: `base_experience`, Property: `RewardedExperiencePoints`, Type: `int`
  - The base amount of experience points gained from beating this creature in battle
- JSON: `height`, Property: `Height`, Type: `int`
  - The height of the creature in decimeters (1 decimeter = 10 centimeters)
- JSON: `is_default`, Property: `IsDefault`, Type: `bool`
  - Pokemon can have different forms based on regions and other factors, but this field's usefulness is ambiguous because even more Pokemon now have extra forms: https://github.com/pokeapi/pokeapi/issues/1568
- JSON: `order`, Property: `FamilyOrder`, Type: `int`
  - Order used for sorting Pokemon by family
- JSON: `weight`, Property: `Weight`, Type: `int`
  - The weight of the creature
- JSON: `abilities`, Property: `Abilities`, Type: `IEnumerable<Ability>`
  - The possible abilities this creature could have
- JSON: `past_abilities`, Property: `PastAbilities`, Type: `IEnumerable<PastAbility>`
  - If the creature has had different abilities in other mainline Pokemon games, they will be recorded here
- JSON: `forms`, Property: `Forms`, Type: `IEnumerable<Form>`
  - The possible regional or alternative forms this creature could have
- JSON: `game_indices`, Property: `GameAppearances`, Type: `IEnumerable<GameIndex>`
  - The games this creature appears in
- JSON: `held_items`, Property: `HeldItems`, Type: `IEnumerable<HeldItem>`
  - The possible items this creature could hold and use during gameplay
- JSON: `location_area_encounters`, Property: `EncounterAreas`, Type: `string`
  - A POST request URL that, when used, returns a list of all areas & locations throughout the mainline series that this Pokemon can be encountered in
- JSON: `moves`, Property: `Moves`, Type: `IEnumerable<Move>`
  - A list of combat moves this creature could learn through experience or by TM/HM
- JSON: `species`, Property: `Species`, Type: `Species`
  - A species name and POST request URL that tracks the "biological" facets (gender differences, habitat) of a Pokemon. If there are multiple varieties or forms of a specific Pokemon (i.e., Wormadam has three varieties), the response from the provided URL is the shared biological facets between all variants/forms. This also includes the in-game flavor text/Pokedex entries for the creature in each mainline game. 
- JSON: `sprites`, Property: `Sprites`, Type: `Sprites`
  - Contains the URLs to the various sprites of the Pokemon throughout the generations, including back, front, shiny, and if applicable, gender differentiated sprites.
- JSON: `cries`, Property: `Cries`, Type: `Cries`
  - Contains the URLs to the sound files for the latest and oldest/legacy versions of the Pokemon's cry
- JSON: `stats`, Property: `Stats`, Type: `IEnumerable<Stat>`
  - List of the base values of all 6 stats that a Pokemon can have
- JSON: `past_stats`, Property: `PastStats`, Type: `IEnumerable<PastStat>`
  - If the creature has had different base stats in different mainline games, they will be recorded here
- JSON: `types`, Property: `ElementalTypes`, Type: `IEnumerable<ElementalType>`
  - The elemental type or types this creature has
- JSON: `past_types`, Property: `PastTypes`, Type: `IEnumerable<PastElementalType>`
  - Uncommon: if the creature has had its elemental typing changed, like how Magnemite became an Electic and Steel type from a purely Electric one after Generation 1, tracks its prior elemental typing
<!-- SECTION:DESCRIPTION:END -->
