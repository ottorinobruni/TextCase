# TextCase
[![.NET](https://github.com/ottorinobruni/TextCase/actions/workflows/textcase-tests.yml/badge.svg)](https://github.com/ottorinobruni/TextCase/actions/workflows/textcase-tests.yml)
[![NuGet](https://img.shields.io/nuget/v/TextCase.svg?style=flat-square)](https://www.nuget.org/packages/TextCase)
[![Nuget](https://img.shields.io/nuget/dt/TextCase)](https://www.nuget.org/packages/TextCase)

The TextCase library for .NET helps changing the cases of existing texts.

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

It's possible to count in the text:
- number of characters
- number of words
- number of letters
- number of sentences

## Usage:

```cscharp
// YOU TALKING TO ME?
TextCase.Convert("You talking to me?", Case.UpperCase);

// you talking to me?
TextCase.Convert("You talking to me?", Case.LowerCase);

// You Talking To Me?
TextCase.Convert("You talking to me?", Case.TitleCase);

// You talking to me?
TextCase.Convert("You talking to me?", Case.CapitaliseCase);   

// You Talking To Me?
TextCase.Convert("You talking to me?", Case.CapitaliseWordsCase); 

// ?em ot gniklat uoY
TextCase.Convert("You talking to me?", Case.ReverseCase);         

// YoU TaLkInG To mE?
TextCase.Convert("You talking to me?", Case.AlternateCase);       

// youTalkingToMe?
TextCase.Convert("You talking to me?", Case.CamelCase);           

// YouTalkingToMe?
TextCase.Convert("You talking to me?", Case.PascalCase);          

// you-talking-to-me?
TextCase.Convert("You talking to me?", Case.KebabCase);           

// you_talking_to_me?
TextCase.Convert("You talking to me?", Case.SnackCase);           

// #You #talking #to #me?
TextCase.Convert("You talking to me?", Case.HashtagCase);   

// Text, Words, Letters and Sentences Count
TextCase.GetTextCount("You talking to me?");  
TextCase.GetWordsCount("You talking to me?");  
TextCase.GetLettersCount("You talking to me?");  
TextCase.GetSentencesCount("You talking to me?");  
```

## Get it on NuGet:

```cscharp
PM> Install-Package TextCase
```

## Feedback and Contribution
Please feel free to send in a Pull Request, or drop me an email. Cheers!
