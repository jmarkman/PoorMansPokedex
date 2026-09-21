---
id: PDX-001
title: Create PokemonHttp class to encapsulate Http requests
status: To Do
assignee: []
created_date: '2026-09-21 19:24'
labels: []
dependencies: []
ordinal: 1000
---

## Description

<!-- SECTION:DESCRIPTION:BEGIN -->
Create a new class in PoorMansPokedex.Core called PokemonHttp and accompanying interface. This class will encapsulate the creation of a new HttpClient, calls to its SendAsync method, and calls to ReadAsStringAsync. The future endpoint classes will handle the deserialization into C# objects.

The base URL for all requests is `https://pokeapi.co/api/v2/`.

It should implement some basic caching, where we track the full request URL and its response, both as strings. If we've made the same request before, we'll return the prior response.

It should also have some basic error handling based on `HttpResponseMessage.IsSuccessStatusCode`
<!-- SECTION:DESCRIPTION:END -->
