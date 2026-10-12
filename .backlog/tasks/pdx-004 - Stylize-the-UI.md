---
id: PDX-004
title: Stylize the UI
status: Done
assignee:
  - '@copilot'
created_date: '2026-10-12 01:13'
updated_date: '2026-10-12 06:08'
labels: []
dependencies:
  - PDX-003
references:
  - >-
    https://archives.bulbagarden.net/media/upload/thumb/3/37/RG_Pok%C3%A9dex.png/730px-RG_Pok%C3%A9dex.png
ordinal: 25000
---

## Description

<!-- SECTION:DESCRIPTION:BEGIN -->
Umbrella task for Feature 4: expand MainWindow to display the Pokemons type, base experience, and stats, and add the aesthetic Pokedex-device chrome (top lightbulb row, Pokemon artwork, bottom control row) referencing https://archives.bulbagarden.net/media/upload/thumb/3/37/RG_Pok%C3%A9dex.png/730px-RG_Pok%C3%A9dex.png as a visual guide. Implementation is tracked entirely via this tasks subtasks; this parent task itself has no direct code changes. Depends on Feature 3 (PDX-003) since it extends the existing MainWindow layout and PokedexViewModel.
<!-- SECTION:DESCRIPTION:END -->

## Acceptance Criteria
<!-- AC:BEGIN -->
- [x] #1 All child subtasks of this feature are completed
<!-- AC:END -->

## Implementation Plan

<!-- SECTION:PLAN:BEGIN -->
1. Complete PDX-004.01 first: extend the existing MainWindow grid with bound Type, Experience provided, HP, Attack, Defense, Special Attack, Special Defense, and Speed rows between Name and search. Add observable ViewModel values populated from PokedexEntry.Types, BaseExperience, and Stats matched by each Stat.Name rather than relying on list order. Verify Magnemite shows electric/steel, base experience 65, and its live API stat values. 2. Then complete PDX-004.02: finalize the combined grid layout with the four decorative top lights, a centered artwork Image row immediately below them, and the decorative bottom control row. Bind artwork to a ViewModel image-source property populated from PokedexEntry.Sprites.Other.OfficialArtwork.FrontDefault; keep chrome purely visual and noninteractive. 3. Build and run the WPF app; verify Magnemite lookup displays the data rows and official artwork, and confirm existing name and numeric searches still work. Run the existing solution tests. Record evidence and complete each child task only after its acceptance criteria are verified. 4. After both child tasks are Done, verify the parent acceptance criterion and finalize PDX-004. No parent-level code changes are in scope.
<!-- SECTION:PLAN:END -->

## Implementation Notes

<!-- SECTION:NOTES:BEGIN -->
Both implementation subtasks are Done. Verified the integrated UI with a live Magnemite search: electric/steel, base experience 65, stats HP 25, Attack 35, Defense 70, Special Attack 95, Special Defense 55, Speed 45, and rendered official artwork; numeric id 81 search still displays Magnemite. WPF project build passed with 0 warnings/errors and the existing solution suite passed 8/8 tests. No direct parent-level code changes were needed.
<!-- SECTION:NOTES:END -->

## Final Summary

<!-- SECTION:FINAL_SUMMARY:BEGIN -->
Completed the UI styling feature through its two subtasks: added the type, experience, and stat rows plus Pokedex chrome and official artwork. Verified Magnemite data and artwork in the running UI, preserved numeric search, built the WPF project successfully, and passed all 8 existing tests.
<!-- SECTION:FINAL_SUMMARY:END -->
