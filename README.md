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
- HashTagCase
- ConstantCase
- CobolCase
- InverseCase
- TrainCase

It's possible to count in the text:
- number of characters
- number of words
- number of letters
- number of sentences

## Usage:

```cscharp
// YOU TALKING TO ME?
TextCase.Convert("You talking to me?", Case.UpperCase);
"You talking to me?".ToUpperCase();

// you talking to me?
TextCase.Convert("You talking to me?", Case.LowerCase);
"You talking to me?".ToLowerCase();

// You Talking To Me?
TextCase.Convert("You talking to me?", Case.TitleCase);
"You talking to me?".ToTitleCase();

// You talking to me?
TextCase.Convert("You talking to me?", Case.CapitaliseCase);   
"You talking to me?".ToCapitaliseCase();

// You Talking To Me?
TextCase.Convert("You talking to me?", Case.CapitaliseWordsCase); 
"You talking to me?".ToCapitaliseWordsCase();

// ?em ot gniklat uoY
TextCase.Convert("You talking to me?", Case.ReverseCase);         
"You talking to me?".ToReverseCase();

// YoU TaLkInG To mE?
TextCase.Convert("You talking to me?", Case.AlternateCase);       
"You talking to me?".ToAlternateCase();

// youTalkingToMe?
TextCase.Convert("You talking to me?", Case.CamelCase);           
"You talking to me?".ToCamelCase();

// YouTalkingToMe?
TextCase.Convert("You talking to me?", Case.PascalCase);          
"You talking to me?".ToPascalCase();

// you-talking-to-me?
TextCase.Convert("You talking to me?", Case.KebabCase);           
"You talking to me?".ToKebabCase();

// you_talking_to_me?
TextCase.Convert("You talking to me?", Case.SnackCase);           
"You talking to me?".ToSnackCase();

// #You #talking #to #me?
TextCase.Convert("You talking to me?", Case.HashTagCase);   
"You talking to me?".ToHashTagCase();

// YOU_TALKING_TO_ME
TextCase.Convert("You talking to me?", Case.ConstantCase);   
"You talking to me?".ToConstantCase();

// YOU-TALKING-TO-ME
TextCase.Convert("You talking to me?", Case.CobolCase);   
"You talking to me?".ToCobolCase();

// yOu TaLkInG tO mE?
TextCase.Convert("You talking to me?", Case.InverseCase);   
"You talking to me?".ToInverseCase();

// You-Talking-To-Me
TextCase.Convert("You talking to me?", Case.TrainCase);   
"You talking to me?".ToTrainCase();

// Text Count
TextCase.GetTextCount("You talking to me?");  
"You talking to me?".GetTextCount();  

// Words Count
TextCase.GetWordsCount("You talking to me?");
"You talking to me?".GetWordsCount();

// Letters Count
TextCase.GetLettersCount("You talking to me?");
"You talking to me?".GetLettersCount();

// Sentences Count
TextCase.GetSentencesCount("You talking to me?");
"You talking to me?".GetSentencesCount();
```

## Get it on NuGet:

```cscharp
PM> Install-Package TextCase
```

## Feedback and Contribution
Please feel free to send in a Pull Request, or drop me an email. Cheers!
