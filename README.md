# TextCase

The TextCase library collection helps changing the cases of existing texts.
There are the cases currently available:
- UpperCase
- LowerCase
- TitleCase
- CapitaliseCase
- CapitaliseWordsCase
- ReverseCase
- AlternateCase
- CamelCase
- PascalCase
- KebabCase
- SnackCase
- HashtagCase

[![.NET](https://github.com/ottorinobruni/TextCase/actions/workflows/textcase-tests.yml/badge.svg)](https://github.com/ottorinobruni/TextCase/actions/workflows/textcase-tests.yml)

## Get it on NuGet:

```cscharp
PM> Install-Package TextCase
```
## Usage:

```cscharp
TextCase.Convert("You talking to me?", Case.UpperCase);           // YOU TALKING TO ME?
TextCase.Convert("You talking to me?", Case.LowerCase);           // you talking to me?
TextCase.Convert("You talking to me?", Case.TitleCase);           // You Talking To Me?
TextCase.Convert("You talking to me?", Case.CapitaliseCase);      // You talking to me?
TextCase.Convert("You talking to me?", Case.CapitaliseWordsCase); // You Talking To Me?
TextCase.Convert("You talking to me?", Case.ReverseCase);         // ?em ot gniklat uoY
TextCase.Convert("You talking to me?", Case.AlternateCase);       // YoU TaLkInG To mE?
TextCase.Convert("You talking to me?", Case.CamelCase);           // youTalkingToMe?
TextCase.Convert("You talking to me?", Case.PascalCase);          // YouTalkingToMe?
TextCase.Convert("You talking to me?", Case.KebabCase);           // you-talking-to-me?
TextCase.Convert("You talking to me?", Case.SnackCase);           // you_talking_to_me?
TextCase.Convert("You talking to me?", Case.HashtagCase);         // #You #talking #to #me?
```
