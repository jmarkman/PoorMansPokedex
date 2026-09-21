---
id: PDX-004
title: Build out the nested data types used by the `Pokemon` model
status: To Do
assignee: []
created_date: '2026-09-21 19:29'
updated_date: '2026-09-21 19:40'
labels: []
dependencies:
  - PDX-005
  - PDX-006
  - PDX-007
ordinal: 4000
---

## Description

<!-- SECTION:DESCRIPTION:BEGIN -->
In `PoorMansPokedex.Core.Models`, build the nested data type models within each subtask by adding autoproperties to each model class. 

For each subtask, the description contents will denote the model, its JSON property names, the C# autoproperty name to use, and the associated C# type. Use the `[JsonPropertyName]` attribute from `System.Text.Json` to designate which C# property should receive the value from the JSON property.
<!-- SECTION:DESCRIPTION:END -->
