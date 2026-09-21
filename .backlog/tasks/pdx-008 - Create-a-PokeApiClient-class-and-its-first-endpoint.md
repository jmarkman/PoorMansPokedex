---
id: PDX-008
title: Create a PokeApiClient class and its first endpoint
status: To Do
assignee: []
created_date: '2026-09-21 20:53'
labels: []
dependencies: []
ordinal: 8000
---

## Description

<!-- SECTION:DESCRIPTION:BEGIN -->
Create a new folder in `PoorMansPokedex.Core` called `Endpoints`. In the `Endpoints` folder, add a new interface, `IPokedexEndpoint`. The interface should have the following method signatures:

```cs
Task<Pokemon> GetEntryAsync(string name);

Task<Pokemon> GetEntryAsync(int id);
```

Create a new class in `Endpoints` called `PokedexEndpoint` that implements those interfaces by throwing a NotImplementedException. The class should accept the custom Http client as a constructor parameter.

Create a new interface in `PoorMansPokedex.Core` called IPokeApiClient. The interface should have one property:

```csharp
IPokedexEndpoint Pokedex { get; }
```

Create a new class in `PoorMansPokedex.Core` called PokeApiClient. It should implement the `IPokeApiClient` interface. In its constructor, it should new up a custom Http client, then new up a PokedexEndpoint on the implemented property, passing along the custom Http client.
<!-- SECTION:DESCRIPTION:END -->
