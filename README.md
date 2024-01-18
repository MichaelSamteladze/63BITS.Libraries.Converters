# Number to Words Converter and Price to Words Converter
C# library **SixtyThreeBits.Libraries.Converters**  that currencly includes "Number to Words" and "Price to Words" converters. 
You can install it as nuget package **63BITS.Libraries.Converters**. This library is dependency free.

Number to Words Converter supports three languages:
1. English
1. Georgian
1. Russian

Price to Words Converter supports three languages (listed above) and four currencies:
1. US Dollar
1. Euro
1. Georgian Lari
1. Russian Ruble

Languages and Currencies are enums, registered in **SixtyThreeBits.Libraries.Converters.Enums** namespace.

## Number to Words Converter Usage: 
```
var result = NumberToWordsConverter.ConvertNumberToWords(inputNumber: "438", language: Language.English);

var result = NumberToWordsConverter.ConvertNumberToWords(inputNumber: 438, language: Language.English);

var result = 438.ConvertNumberToWords(language: Language.English);
```

**NumberToWordsConverter.ConvertNumberToWords** method accepts two parameters: 
1. **inputNumber** - Number that must be converted to the words.
1. **language** - Language that should be used for the conversation process.

* you provide **"438"** as an input number, **English** as a language and you get **"four hundred thirty-eight"** as a result.
* you provide **"1123"** as an input number, **Georgian** as a language and you get **"ერთი ათას ას ოცდასამი"** as a result.
* you provide **"1987"** as an input number, **Russian** as a laugnauge and you get **"одна тысяча девятьсот восемьдесят семь"** as a result.

## Price to Words Converter Usage:
```
var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: "467.63", language: Language.English, currency: Currency.USDollar, shouldConvertToWordsWhenZero: true);

var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: 467.63m, language: Language.English, currency: Currency.USDollar, shouldConvertToWordsWhenZero: true);

var result = 467.63m.ConvertPriceToWords(language: Language.English, currency: Currency.USDollar, shouldConvertFractionalUnitsToWords: true);
```

**PriceToWordsConverter.ConvertPriceToWords** method accepts four parameters: 
1. **inputPrice** - A decimal number that should be converted to the words.
1. **language** - Language that should be used for the conversation process.
1. **currency** - Currency that should be used for the conversation process.
1. **shouldConvertFractionalUnitsToWords** - An instruction for how to handle zero values. 
	* When **"true"** is provided for inputPrice **0.07**, conversion result will be: **zero us dollars and seven cents**
	* When **"false"** is provided for inputPrice **0.07**, conversion result will be: **seven cents**
	* When **"true"** is provided for inputPrice **1000**, conversion result will be: **one thousand us dollars and zero cents**
	* When **"false"** is provided for inputPrice **1000**, conversion result will be: **one thousand us dollars**

* you provide **"467.63"** as an input number, **Georgian** as a language, **Georgian Lari** as a currency and you get **"ოთხას სამოცდაშვიდი ლარი და სამოცდასამი თეთრი"** as a result.
* you provide **"2758.6"** as an input number, **English** as a language, **US Dollar** as a currency and you get **"two thousand seven hundred fifty-eight us dollars and sixty cents"** as a result.
* you provide **"3.01"** as an input number, **Russian** as a language, **Russian Ruble** as a currency and you get **"три рубля и одна копейка"** as a result.

## Limitations
Both libraries are limited to highest allowed number 999'999'999'999'999'999 (highest quadrillion). 

## Exceptions and Error Handling
* An **exception** will be thrown when input is provided as string and its not a numeric value.
* An **exception** will be thrown when input will exceed highest allowed number.
* **null** will be retured when null is provided as an input.