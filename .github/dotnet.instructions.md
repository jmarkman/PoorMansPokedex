---
applyTo: 'PoorMansPokedex/**/*.cs,PoorMansPokedex.Core/**/*.cs'
---

When writing foreach loops over dictionaries, use the KeyValuePair object:

```cs
foreach (var kvp in myDictionary)
{
  Console.WriteLine($"{kvp.Key}");
  Console.WriteLine($"{kvp.Value}");
}
```

If `async` is mentioned in a task or prompt, it always means that any methods related to that task or prompt will be asynchronous. A method that returns a `Task<T>` or `Task` will leverage the `async` and `await` keywords, and its callers will subsequently leverage the `async` and `await` keywords. The only time this will be untrue is when it's explicitly stated within the task or prompt that the desired code will not be asynchronous.

When working in a solution that contains a WPF project, do not use `ConfigureAwait()` with any async method. Using `await asyncTask.ConfigureAwait(false);` in a method poses a risk that if the WPF project is reliant on that async method, there's a chance the WPF project could run into an exception because the thread chosen by `ConfigureAwait(false)` wasn't the UI thread. Adding `ConfigureAwait(true)` to an awaited method call is redundant as that's the default behavior.

