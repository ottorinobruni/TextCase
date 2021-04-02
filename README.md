# TextCase
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

[![.NET](https://github.com/ottorinobruni/TextCase/actions/workflows/textcase-tests.yml/badge.svg)](https://github.com/ottorinobruni/TextCase/actions/workflows/textcase-tests.yml)

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
```

## Get it on NuGet:

```cscharp
PM> Install-Package TextCase
```

## Feedback and Contribution
Please feel free to send in a Pull Request, or drop me an email. Cheers!
