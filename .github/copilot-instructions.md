# TextCase — Copilot Instructions

## Project Overview
TextCase is a .NET 8 NuGet library (`TextCase` package) that converts text between 18 case formats and provides text-analysis helpers (character/word/letter/sentence/paragraph counts). It exposes two public APIs: a static `TextCase.Convert()` method driven by the `Case` enum, and fluent `string` extension methods (e.g. `"hello".ToCamelCase()`).

## Architecture

```
TextCase/
  TextCase.cs            – Case enum + static TextCase class (public API facade)
  TextCaseFactory.cs     – internal switch mapping Case → ICaseConverter (Strategy pattern)
  Converters/
    ICaseConverter.cs     – single-method interface: string Convert(string text)
    *CaseConverter.cs     – one class per case, each implements ICaseConverter
  Extensions/
    StringExtensions.cs   – public extension methods that delegate to TextCase.Convert()
                           + text-analysis helpers (GetTextCount, GetWordsCount, …)
TextCase.UnitTests/
    *ConverterTest.cs     – one xUnit test class per converter
    StringExtensionsTest.cs – tests for analysis helpers and GetAllCases
```

**Key design decision:** Every converter is a standalone class behind `ICaseConverter`. The factory is `internal`; consumers only interact via `TextCase.Convert(text, Case.X)` or `"text".ToXCase()`.

## Adding a New Case Converter

Follow these five steps exactly — every existing converter follows this pattern:

1. **Add enum value** in `TextCase/TextCase.cs` → `Case` enum.
2. **Create converter** in `TextCase/Converters/` implementing `ICaseConverter`. Return `string.Empty` for null/whitespace input. Add XML doc comments.
3. **Register in factory** — add a `Case.YourCase => new YourCaseConverter()` arm in `TextCaseFactory.GetCaseConverter()`.
4. **Add extension method** in `TextCase/Extensions/StringExtensions.cs` following the existing pattern: `public static string ToYourCase(this string value) => TextCase.Convert(value, Case.YourCase);` with XML doc.
5. **Add static facade method** if the new feature is an analysis helper — add a static method in `TextCase.cs` that delegates to the extension (see `GetTextCount` pattern).
6. **Write tests** in `TextCase.UnitTests/` — create `YourCaseConverterTest.cs` with `[Theory]/[InlineData]` tests for both the converter directly and the extension method.

## Conventions & Patterns

- **Null/empty guard**: every converter returns `string.Empty` when input is `null` or whitespace — use `string.IsNullOrWhiteSpace(text)`.
- **Culture-invariant**: use `ToUpperInvariant()` / `ToLowerInvariant()`, not `ToUpper()` / `ToLower()`.
- **Namespace**: converters live in `TextCase.Converters`; extensions in `TextCase.Extensions`; the facade and enum in `TextCase`.
- **Naming**: converter class = `{Name}CaseConverter`; extension = `To{Name}Case()`; test class = `{Name}CaseConverterTest`.
- **XML doc comments** on all public members — follow the existing `<summary>` / `<param>` / `<returns>` style.
- **No external dependencies** — the library has zero NuGet package references.

## Build & Test Commands

```bash
dotnet restore              # restore packages
dotnet build --no-restore   # build solution
dotnet test --no-build      # run xUnit tests
dotnet pack                 # produce NuGet package (GeneratePackageOnBuild is on)
```

CI runs on GitHub Actions (`.github/workflows/textcase-tests.yml`) on push/PR to `main` using .NET 8.

## Test Patterns

- Framework: **xUnit** with `[Theory]` + `[InlineData]` for parameterized cases.
- Each converter test file has two test methods:
  - `Convert_When{Case}_TextShouldBe{Case}` — instantiates the converter directly.
  - `To{Case}_When{Case}_TextShouldBe{Case}` — uses the string extension method.
- Test naming: `MethodName_WhenCondition_ExpectedResult`.
- Tests include multi-language strings (German `glückLICH`, Italian `che ore sono?`) — preserve this practice.
- Analysis helpers are tested in `StringExtensionsTest.cs` with `[Theory]`/`[InlineData]` covering edge cases (`""`, `null`, multi-sentence, multi-paragraph).
