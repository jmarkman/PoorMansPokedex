---
applyTo: 'PoorMansPokedex/**/*.cs,PoorMansPokedex.Core/**/*.cs'
---

When creating data model classes or POCOs, always create a new file for that class instead of adding them all to one particular file.

Always create a separate file to contain the interface that a given class may implement. `Service` and `IService` should exist as separate modules.