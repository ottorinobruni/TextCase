# CLAUDE.md

TextCase is a .NET 8 NuGet library that converts text between 18 case formats and provides text-analysis helpers. Zero external dependencies.

## Build & Test

```bash
dotnet restore && dotnet build --no-restore
dotnet test --no-build
```

## Architecture

Strategy pattern: `ICaseConverter` interface → one converter class per case → `TextCaseFactory` (internal) maps `Case` enum → converter. Two public APIs:
- `TextCase.Convert(text, Case.X)`
- `"text".ToXCase()` extension methods

Key files:
- `TextCase/TextCase.cs` — `Case` enum + static facade
- `TextCase/TextCaseFactory.cs` — internal factory (switch expression)
- `TextCase/Converters/` — one `{Name}CaseConverter.cs` per case, all implement `ICaseConverter`
- `TextCase/Extensions/StringExtensions.cs` — fluent extensions + analysis helpers (`GetTextCount`, `GetWordsCount`, etc.)

## Adding a New Case Converter (6 steps, all required)

1. Add enum value to `Case` in `TextCase/TextCase.cs`
2. Create `TextCase/Converters/{Name}CaseConverter.cs` implementing `ICaseConverter` — return `string.Empty` for null/whitespace
3. Add `Case.{Name} => new {Name}CaseConverter()` in `TextCaseFactory.GetCaseConverter()`
4. Add `To{Name}Case()` extension in `TextCase/Extensions/StringExtensions.cs` with XML doc
5. If analysis helper: add static method in `TextCase.cs` delegating to the extension
6. Create `TextCase.UnitTests/{Name}CaseConverterTest.cs` with `[Theory]/[InlineData]` — two test methods: one via converter, one via extension

## Conventions

- Null guard: `string.IsNullOrWhiteSpace(text)` → return `string.Empty`
- Culture-invariant: `ToUpperInvariant()` / `ToLowerInvariant()` only
- Namespaces: `TextCase.Converters`, `TextCase.Extensions`, `TextCase`
- Naming: `{Name}CaseConverter`, `To{Name}Case()`, `{Name}CaseConverterTest`
- XML doc `<summary>/<param>/<returns>` on all public members
- Test naming: `MethodName_WhenCondition_ExpectedResult`
- Include multi-language test strings (German, Italian)
- No external NuGet dependencies allowed
