---
id: PDX-006
title: Add autoproperties to the `Sprites` model and its associated nested types
status: To Do
assignee: []
created_date: '2026-09-21 19:38'
labels: []
dependencies: []
ordinal: 6000
---

## Description

<!-- SECTION:DESCRIPTION:BEGIN -->
The `Sprites` model should consist of the following properties:

- JSON: `other`, Property: `Other`, Type: `OtherSprites`
- JSON: `versions`, Property: `ByVersion`, Type: `SpriteVersion`
- JSON: `back_shiny`, Property: `ShinyBackView`, Type: `string`
- JSON: `back_female`, Property: `FemaleBackView`, Type: `string`
- JSON: `front_shiny`, Property: `ShinyFrontView`, Type: `string`
- JSON: `back_default`, Property: `DefaultBackView`, Type: `string`
- JSON: `front_female`, Property: `FemaleFrontView`, Type: `string`
- JSON: `front_default`, Property: `DefaultFrontView`, Type: `string`
- JSON: `back_female`, Property: `FemaleBackView`, Type: `string`
- JSON: `back_shiny_female`, Property: `ShinyFemaleBackView`, Type: `string`
- JSON: `front_shiny_female`, Property: `ShinyFemaleFrontView`, Type: `string`

The OtherSprites model should have four properties:

- JSON: `home`, Property: `PokemonHome`, Type: `PokemonHomeSprites`
- JSON: `showdown`, Property: `PokemonShowdown`, Type: `PokemonShowdownSprites`
- JSON: `dream_world`, Property: `PokemonDreamWorldSprites`, Type: `PokemonDreamWorldSprites`
- JSON: `official-artwork`, Property: `Order`, Type: `PokemonOfficialArtworkSprites`

The PokemonHomeSprites model should have four properties:

- JSON: `front_shiny`, Property: `ShinyFrontView`, Type: `string`
- JSON: `front_female`, Property: `FemaleFrontView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`
- JSON: `front_shiny_female`, Property: `Order`, Type: `string`

The PokemonShowdownSprites model should have eight properties:

- JSON: `back_shiny`, Property: `ShinyBackView`, Type: `string`
- JSON: `back_female`, Property: `FemaleBackView`, Type: `string`
- JSON: `front_shiny`, Property: `ShinyFrontView`, Type: `string`
- JSON: `back_default`, Property: `DefaultBackView`, Type: `string`
- JSON: `front_female`, Property: `FemaleFrontView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`
- JSON: `back_shiny_female`, Property: `ShinyFemaleBackView`, Type: `string`
- JSON: `front_shiny_female`, Property: `ShinyFemaleFrontView`, Type: `string`

The PokemonDreamWorldSprites model should have two properties:

- JSON: `front_female`, Property: `FemaleFrontView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`

The PokemonOfficialArtworkSprites model should have two properties:

- JSON: `front_shiny`, Property: `ShinyFrontView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`

The SpriteVersion model should consist of the following properties

- JSON: `generation_i`, Property: `GenerationOne`, Type: `GenerationOneSprites`
- JSON: `generation_ii`, Property: `GenerationTwo`, Type: `GenerationTwoSprites`
- JSON: `generation_iii`, Property: `GenerationThree`, Type: `GenerationThreeSprites`
- JSON: `generation_iv`, Property: `GenerationFour`, Type: `GenerationFourSprites`
- JSON: `generation_v`, Property: `GenerationFive`, Type: `GenerationFiveSprites`
- JSON: `generation_vi`, Property: `GenerationSix`, Type: `GenerationSixSprites`
- JSON: `generation_vii`, Property: `GenerationSeven`, Type: `GenerationSevenSprites`
- JSON: `generation_viii`, Property: `GenerationEight`, Type: `GenerationEightSprites`
- JSON: `generation_xi`, Property: `GenerationNine`, Type: `GenerationNineSprites`

The GenerationOneSprites model should consist of the following properties

- JSON: `yellow`, Property: `YellowVersion`, Type: `YellowVersionSprites`
- JSON: `red-blue`, Property: `RedBlueVersion`, Type: `RedBlueVersionSprites`

The YellowVersionSprites and RedBlueVersionSprites should consist of the following properties:

- JSON: `back_gray`, Property: `GrayBackView`, Type: `string`
- JSON: `front_gray`, Property: `GrayFrontView`, Type: `string`
- JSON: `back_default`, Property: `BackView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`
- JSON: `back_transparent`, Property: `TransparentBackView`, Type: `string`
- JSON: `front_transparent`, Property: `TransparentFrontView`, Type: `string`

The GenerationTwoSprites model should consist of the following properties:

- JSON: `gold`, Property: `GoldVersion`, Type: `GoldVersionSprites`
- JSON: `silver`, Property: `SilverVersion`, Type: `SilverVersionSprites`
- JSON: `crystal`, Property: `CrystalVersion`, Type: `CrystalVersionSprites`

The GoldVersionSprites and SilverVersionSprites models should consist of the following properties:

- JSON: `back_shiny`, Property: `ShinyBackView`, Type: `string`
- JSON: `front_shiny`, Property: `ShinyFrontView`, Type: `string`
- JSON: `back_default`, Property: `BackView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`
- JSON: `front_transparent`, Property: `TransparentFrontView`, Type: `string`

The CrystalVersionSprites model should consist of the following properties:

- JSON: `back_shiny`, Property: `ShinyBackView`, Type: `string`
- JSON: `front_shiny`, Property: `ShinyFrontView`, Type: `string`
- JSON: `back_default`, Property: `BackView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`
- JSON: `back_transparent`, Property: `TransparentBackView`, Type: `string`
- JSON: `front_transparent`, Property: `TransparentFrontView`, Type: `string`
- JSON: `back_shiny_transparent`, Property: `TransparentShinyBackView`, Type: `string`
- JSON: `front_shiny_transparent`, Property: `TransparentShinyFrontView`, Type: `string`

The GenerationThreeSprites model should consist of the following properties:

- JSON: `emerald`, Property: `EmeraldVersion`, Type: `EmeraldVersionSprites`
- JSON: `ruby-sapphire`, Property: `RubySapphireVersion`, Type: `RubySapphireVersionSprites`
- JSON: `firered-leafgreen`, Property: `FireRedLeafGreenVersion`, Type: `FireRedLeafGreenVersionSprites`

The EmeraldVersionSprites model should consist of the following properties:

- JSON: `front_shiny`, Property: `ShinyFrontView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`

The RubySapphireVersionSprites and FireRedLeafGreenVersionSprites models should consist of the following properties:

- JSON: `back_shiny`, Property: `ShinyBackView`, Type: `string`
- JSON: `front_shiny`, Property: `ShinyFrontView`, Type: `string`
- JSON: `back_default`, Property: `BackView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`

The GenerationFourSprites model should consist of the following properties:

- JSON: `platinum`, Property: `PlatinumVersion`, Type: `PlatinumVersionSprites`
- JSON: `diamond-pearl`, Property: `DiamondPearlVersion`, Type: `DiamondPearlVersionSprites`
- JSON: `heartgold-soulsilver`, Property: `HeartGoldSoulSilverVersion`, Type: `HeartGoldSoulSilverVersionSprites`

The DiamondPearlVersionSprites, HeartGoldSoulSilverVersion, and PlatinumVersionSprites models should consist of the following properties:

- JSON: `back_shiny`, Property: `ShinyBackView`, Type: `string`
- JSON: `back_female`, Property: `FemaleBackView`, Type: `string`
- JSON: `front_shiny`, Property: `ShinyFrontView`, Type: `string`
- JSON: `back_default`, Property: `BackView`, Type: `string`
- JSON: `front_female`, Property: `FemaleFrontView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`
- JSON: `back_shiny_female`, Property: `ShinyFemaleBackView`, Type: `string`
- JSON: `front_shiny_female`, Property: `ShinyFemaleFrontView`, Type: `string`

The GenerationFiveSprites model should consist of the following properties:

- JSON: `icons`, Property: `Icons`, Type: `GenerationFiveIcons`
- JSON: `black-white`, Property: `BlackWhiteVersion`, Type: `BlackWhiteVersionSprites`

The GenerationFiveIcons model should consist of the following properties:

- JSON: `animated`, Property: `Animated`, Type: `AnimatedIcon`
- JSON: `front_default`, Property: `Static`, Type: `string`

The AnimatedIcon model should consist of one property:

- JSON: `front_default`, Property: `Url`, Type: `string`

The BlackWhiteVersionSprites model should consist of the following properties:

- JSON: `animated`, Property: `AnimatedVersions`, Type: `BlackWhiteVersionAnimatedIcon`
- JSON: `back_shiny`, Property: `ShinyBackView`, Type: `string`
- JSON: `back_female`, Property: `FemaleBackView`, Type: `string`
- JSON: `front_shiny`, Property: `ShinyFrontView`, Type: `string`
- JSON: `back_default`, Property: `BackView`, Type: `string`
- JSON: `front_female`, Property: `FemaleFrontView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`
- JSON: `back_shiny_female`, Property: `ShinyFemaleBackView`, Type: `string`
- JSON: `front_shiny_female`, Property: `ShinyFemaleFrontView`, Type: `string`

The BlackWhiteVersionAnimatedIcon model should consist of the following properties

- JSON: `back_shiny`, Property: `ShinyBackView`, Type: `string`
- JSON: `back_female`, Property: `FemaleBackView`, Type: `string`
- JSON: `front_shiny`, Property: `ShinyFrontView`, Type: `string`
- JSON: `back_default`, Property: `BackView`, Type: `string`
- JSON: `front_female`, Property: `FemaleFrontView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`
- JSON: `back_shiny_female`, Property: `ShinyFemaleBackView`, Type: `string`
- JSON: `front_shiny_female`, Property: `ShinyFemaleFrontView`, Type: `string`

The GenerationSixSprites model should consist of the following properties:

- JSON: `x-y`, Property: `XYVersion`, Type: `XYVersionSprites`
- JSON: `omegaruby-alphasapphire`, Property: `OmegaRubyAlphaSapphireVersion`, Type: `OmegaRubyAlphaSapphireSprites`

The XYVersionSprites and OmegaRubyAlphaSapphireSprites models should consist of the following properties:

- JSON: `front_shiny`, Property: `ShinyFrontView`, Type: `string`
- JSON: `front_female`, Property: `FemaleFrontView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`
- JSON: `front_shiny_female`, Property: `ShinyFemaleFrontView`, Type: `string`

The GenerationSevenSprites model should consist of the following properties:

- JSON: `icons`, Property: `Icons`, Type: `GenerationSevenIcons`
- JSON: `ultra-sun-ultra-moon`, Property: `UltraSunUltraMoonVersion`, Type: `UltraSunUltraMoonSprites`

The GenerationSevenIcons model should consist of the following properties:

- JSON: `front_female`, Property: `FemaleFrontView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`

The UltraSunUltraMoonSprites should consist of the following properties:

- JSON: `front_shiny`, Property: `ShinyFrontView`, Type: `string`
- JSON: `front_female`, Property: `FemaleFrontView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`
- JSON: `front_shiny_female`, Property: `ShinyFemaleFrontView`, Type: `string`

The GenerationEightSprites model should consist of the following properties:

- JSON: `icons`, Property: `Icons`, Type: `GenerationEightIcons`
- JSON: `brilliant-diamond-shining-pearl`, Property: `BrilliantDiamondShiningPearlVersion`, Type: `BrilliantDiamondShiningPearlSprites`

The GenerationEightIcons model should consist of the following properties:

- JSON: `front_female`, Property: `FemaleFrontView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`

The BrilliantDiamondShiningPearlVersion model should consist of the following properties:

- JSON: `front_female`, Property: `FemaleFrontView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`

The GenerationNineSprites model should consist of the following properties:

- JSON: `scarlet-violet`, Property: `ScarletVioletVersion`, Type: `ScarletVioletSprites`

The ScarletVioletSprites model should consist of the following properties:

- JSON: `front_female`, Property: `FemaleFrontView`, Type: `string`
- JSON: `front_default`, Property: `FrontView`, Type: `string`

## Superflous notes

The Sprites model is possibly the deepest and most strangely-designed subtype given prior usage of JSON arrays. Make a note in the final summary that we may want to revisit the construction of the `Sprites` model.
<!-- SECTION:DESCRIPTION:END -->
