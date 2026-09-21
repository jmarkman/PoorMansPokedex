---
id: PDX-007
title: >-
  Add autoproperties to the `Stat` and `ElementalType` models and their
  associated subtypes
status: To Do
assignee: []
created_date: '2026-09-21 19:39'
updated_date: '2026-09-21 19:40'
labels: []
dependencies: []
ordinal: 7000
---

## Description

<!-- SECTION:DESCRIPTION:BEGIN -->
Add autoproperties to the following subtypes:

- `Stat`
- `StatMetadata`
- `PastStat`
- `ElementalType`
- `PastElementalType`

The Stat model should consist of the following properties:

- JSON: `base_stat`, Property: `BaseValue`, Type: `int`
- JSON: `effort`, Property: `Bonus`, Type: `int`
- JSON: `stat`, Property: `Metadata`, Type: `StatMetadata`

The StatMetadata model should consist of the following properties:

- JSON: `name`, Property: `Name`, Type: `string`
- JSON: `url`, Property: `Url`, Type: `string`

The PastStat model should consist of the following properties:

- JSON: `generation`, Property: `Generation`, Type: `Generation`
- JSON: `stats`, Property: `Stats`, Type: `IEnumerable<Stat>`

The ElementalType model should consist of the following properties:

- JSON: `slot`, Property: `PrecedenceLevel`, Type: `int`
- JSON: `type`, Property: `Metadata`, Type: `ElementalTypeMetadata`

The ElementalTypeMetadata model should consist of the following properties:

- JSON: `name`, Property: `Name`, Type: `string`
- JSON: `url`, Property: `Url`, Type: `string`

The PastElementalType model should consist of the following properties:

- JSON: `generation`, Property: `Generation`, Type: `Generation`
- JSON: `types`, Property: `Types`, Type: `IEnumerable<ElementalType>`
<!-- SECTION:DESCRIPTION:END -->
