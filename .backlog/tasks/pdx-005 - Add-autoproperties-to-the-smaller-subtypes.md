---
id: PDX-005
title: Add autoproperties to the smaller subtypes
status: To Do
assignee: []
created_date: '2026-09-21 19:34'
updated_date: '2026-09-21 19:35'
labels: []
dependencies: []
ordinal: 5000
---

## Description

<!-- SECTION:DESCRIPTION:BEGIN -->
Add autoproperties to the following smaller subtypes:

- `Form`
- `Species`
- `Cries`
- `Ability`
- `AbilityData`
- `Generation`
- `PastAbility`
- `Version`
- `HeldItemData`
- `ItemVersionDetails`
- `GameIndex`
- `HeldItem`
- `Move`
- `MoveData`
- `MoveVersionGroup`
- `MoveLearnMethod`
- `MoveVersionDetails`

Form and Species should have two properties:

- JSON: `name`, Property: `Name`, Type: `string`
- JSON: `url`, Property: `Url`, Type: `string`

Cries should have two properties:

- JSON: `latest`, Property: `Latest`, Type: `string`
- JSON: `legacy`, Property: `Legacy`, Type: `string`
- 
- Ability should have three properties:

- JSON: `is_hidden`, Property: `IsHidden`, Type: `bool`
- JSON: `slot`, Property: `Slot`, Type: `int`
- JSON: `ability`, Property: `Ability`, Type: `AbilityData`

AbilityData should have two properties:

- JSON: `name`, Property: `Name`, Type: `string`
- JSON: `url`, Property: `Url`, Type: `string`

Generation should have two properties:

- JSON: `name`, Property: `Name`, Type: `string`
- JSON: `url`, Property: `Url`, Type: `string`

PastAbility should have two properties:

- JSON: `generation`, Property: `Generation`, Type: `Generation`
- JSON: `abilities`, Property: `Abilities`, Type: `IEnumerable<Ability>`

Version and HeldItemData should have two properties:

- JSON: `name`, Property: `Name`, Type: `string`
- JSON: `url`, Property: `Url`, Type: `string`

ItemVersionDetails should have two properties:

- JSON: `rarity`, Property: `Rarity`, Type: `int`
- JSON: `version`, Property: `GameVersion`, Type: `Version`

GameIndex should have two properties:

- JSON: `game_index`, Property: `Value`, Type: `int`
- JSON: `version`, Property: `Version`, Type: `Version`

HeldItem should have two properties:

- JSON: `item`, Property: `Data`, Type: `HeldItemData`
- JSON: `version_details`, Property: `VersionDetails`, Type: `ItemVersionDetails`

Move should have two properties:

- JSON: `move`, Property: `Data`, Type: `MoveData`
- JSON: `version_group_details`, Property: `MoveVersionDetails`, Type: `MoveVersionDetails`

MoveVersionDetails should have four properties:

- JSON: `level_learned_at`, Property: `LevelAtLevel`, Type: `int`
- JSON: `version_group`, Property: `VersionGroup`, Type: `MoveVersionGroup`
- JSON: `move_learn_method`, Property: `LearnMethod`, Type: `MoveLearnMethod`
- JSON: `order`, Property: `Order`, Type: `string`

MoveData, MoveLearnMethod, and MoveVersionGroup should have two properties:

- JSON: `name`, Property: `Name`, Type: `string`
- JSON: `url`, Property: `Url`, Type: `string`
<!-- SECTION:DESCRIPTION:END -->
