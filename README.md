# TextCase
[![.NET](https://github.com/ottorinobruni/TextCase/actions/workflows/textcase-tests.yml/badge.svg)](https://github.com/ottorinobruni/TextCase/actions/workflows/textcase-tests.yml)
[![NuGet](https://img.shields.io/nuget/v/TextCase.svg?style=flat-square)](https://www.nuget.org/packages/TextCase)
[![Nuget](https://img.shields.io/nuget/dt/TextCase)](https://www.nuget.org/packages/TextCase)

TextCase is a powerful .NET library designed to simplify text manipulation by providing a variety of case conversion methods.

Key Features
- Wide Range of Conversions: Transform text into 17 different cases including UpperCase, LowerCase, TitleCase, CamelCase, PascalCase, and more.
- Text Analysis: Easily count characters, words, letters, and sentences within your text.
- Easy Integration: Simple and intuitive API that integrates seamlessly with your .NET applications.

Available Conversions
- UpperCase: Converts text to uppercase.
- LowerCase: Converts text to lowercase.
- TitleCase: Capitalizes the first letter of each word.
- CamelCase: Converts text to camelCase.
- PascalCase: Converts text to PascalCase.
- KebabCase: Converts text to kebab-case.
- SnackCase: Converts text to snack_case.
- HashTagCase: Converts text to #HashTagCase.
- ConstantCase: Converts text to CONSTANT_CASE.
- CobolCase: Converts text to COBOL-CASE.
- InverseCase: Alternates case starting with lowercase.
- TrainCase: Converts text to Train-Case.
- CapitaliseCase: Capitalizes the first letter of the text.
- CapitaliseWordsCase: Capitalizes the first letter of each word.
- ReverseCase: Reverses the text.
- AlternateCase: Alternates case starting with uppercase.

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
