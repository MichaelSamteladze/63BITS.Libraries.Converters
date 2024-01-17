﻿using System.Text.RegularExpressions;
using SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries.Converters.Tests.NumberToWordsConverterTests
{
    [TestClass]
    public class NumberInWordsConverterTestsEnglish
    {
        [DataTestMethod]
        #region Test Number In Words English
        [DataRow("0", "zero")]
        [DataRow("1", "one")]
        [DataRow("2", "two")]
        [DataRow("3", "three")]
        [DataRow("4", "four")]
        [DataRow("5", "five")]
        [DataRow("6", "six")]
        [DataRow("7", "seven")]
        [DataRow("8", "eight")]
        [DataRow("9", "nine")]
        [DataRow("10", "ten")]
        [DataRow("11", "eleven")]
        [DataRow("12", "twelve")]
        [DataRow("13", "thirteen")]
        [DataRow("14", "fourteen")]
        [DataRow("15", "fifteen")]
        [DataRow("16", "sixteen")]
        [DataRow("17", "seventeen")]
        [DataRow("18", "eighteen")]
        [DataRow("19", "nineteen")]
        [DataRow("20", "twenty")]
        [DataRow("21", "twenty-one")]
        [DataRow("22", "twenty-two")]
        [DataRow("23", "twenty-three")]
        [DataRow("24", "twenty-four")]
        [DataRow("25", "twenty-five")]
        [DataRow("26", "twenty-six")]
        [DataRow("27", "twenty-seven")]
        [DataRow("28", "twenty-eight")]
        [DataRow("29", "twenty-nine")]
        [DataRow("30", "thirty")]
        [DataRow("31", "thirty-one")]
        [DataRow("32", "thirty-two")]
        [DataRow("33", "thirty-three")]
        [DataRow("34", "thirty-four")]
        [DataRow("35", "thirty-five")]
        [DataRow("36", "thirty-six")]
        [DataRow("37", "thirty-seven")]
        [DataRow("38", "thirty-eight")]
        [DataRow("39", "thirty-nine")]
        [DataRow("40", "forty")]
        [DataRow("41", "forty-one")]
        [DataRow("42", "forty-two")]
        [DataRow("43", "forty-three")]
        [DataRow("44", "forty-four")]
        [DataRow("45", "forty-five")]
        [DataRow("46", "forty-six")]
        [DataRow("47", "forty-seven")]
        [DataRow("48", "forty-eight")]
        [DataRow("49", "forty-nine")]
        [DataRow("50", "fifty")]
        [DataRow("51", "fifty-one")]
        [DataRow("52", "fifty-two")]
        [DataRow("53", "fifty-three")]
        [DataRow("54", "fifty-four")]
        [DataRow("55", "fifty-five")]
        [DataRow("56", "fifty-six")]
        [DataRow("57", "fifty-seven")]
        [DataRow("58", "fifty-eight")]
        [DataRow("59", "fifty-nine")]
        [DataRow("60", "sixty")]
        [DataRow("61", "sixty-one")]
        [DataRow("62", "sixty-two")]
        [DataRow("63", "sixty-three")]
        [DataRow("64", "sixty-four")]
        [DataRow("65", "sixty-five")]
        [DataRow("66", "sixty-six")]
        [DataRow("67", "sixty-seven")]
        [DataRow("68", "sixty-eight")]
        [DataRow("69", "sixty-nine")]
        [DataRow("70", "seventy")]
        [DataRow("71", "seventy-one")]
        [DataRow("72", "seventy-two")]
        [DataRow("73", "seventy-three")]
        [DataRow("74", "seventy-four")]
        [DataRow("75", "seventy-five")]
        [DataRow("76", "seventy-six")]
        [DataRow("77", "seventy-seven")]
        [DataRow("78", "seventy-eight")]
        [DataRow("79", "seventy-nine")]
        [DataRow("80", "eighty")]
        [DataRow("81", "eighty-one")]
        [DataRow("82", "eighty-two")]
        [DataRow("83", "eighty-three")]
        [DataRow("84", "eighty-four")]
        [DataRow("85", "eighty-five")]
        [DataRow("86", "eighty-six")]
        [DataRow("87", "eighty-seven")]
        [DataRow("88", "eighty-eight")]
        [DataRow("89", "eighty-nine")]
        [DataRow("90", "ninety")]
        [DataRow("91", "ninety-one")]
        [DataRow("92", "ninety-two")]
        [DataRow("93", "ninety-three")]
        [DataRow("94", "ninety-four")]
        [DataRow("95", "ninety-five")]
        [DataRow("96", "ninety-six")]
        [DataRow("97", "ninety-seven")]
        [DataRow("98", "ninety-eight")]
        [DataRow("99", "ninety-nine")]
        [DataRow("100", "one hundred")]
        [DataRow("104", "one hundred four")]
        [DataRow("212", "two hundred twelve")]
        [DataRow("327", "three hundred twenty-seven")]
        [DataRow("438", "four hundred thirty-eight")]
        [DataRow("549", "five hundred forty-nine")]
        [DataRow("651", "six hundred fifty-one")]
        [DataRow("762", "seven hundred sixty-two")]
        [DataRow("873", "eight hundred seventy-three")]
        [DataRow("984", "nine hundred eighty-four")]
        [DataRow("995", "nine hundred ninety-five")]
        [DataRow("1 000", "one thousand")]
        [DataRow("1 002", "one thousand two")]
        [DataRow("2 012", "two thousand twelve")]
        [DataRow("3 123", "three thousand one hundred twenty-three")]
        [DataRow("4 202", "four thousand two hundred two")]
        [DataRow("5 300", "five thousand three hundred")]
        [DataRow("10 000", "ten thousand")]
        [DataRow("16 003", "sixteen thousand three")]
        [DataRow("27 014", "twenty-seven thousand fourteen")]
        [DataRow("38 765", "thirty-eight thousand seven hundred sixty-five")]
        [DataRow("49 701", "forty-nine thousand seven hundred one")]
        [DataRow("100 000", "one hundred thousand")]
        [DataRow("258 814", "two hundred fifty-eight thousand eight hundred fourteen")]
        [DataRow("407 603", "four hundred seven thousand six hundred three")]
        [DataRow("500 063", "five hundred thousand sixty-three")]
        [DataRow("678 700", "six hundred seventy-eight thousand seven hundred")]
        [DataRow("1 000 000", "one million")]
        [DataRow("1 004 000", "one million four thousand")]
        [DataRow("2 403 201", "two million four hundred three thousand two hundred one")]
        [DataRow("4 543 785", "four million five hundred forty-three thousand seven hundred eighty-five")]
        [DataRow("10 000 000", "ten million")]
        [DataRow("13 057 086", "thirteen million fifty-seven thousand eighty-six")]
        [DataRow("46 703 600", "forty-six million seven hundred three thousand six hundred")]
        [DataRow("100 000 000", "one hundred million")]
        [DataRow("103 000 000", "one hundred three million")]
        [DataRow("215 050 817", "two hundred fifteen million fifty thousand eight hundred seventeen")]
        [DataRow("1 000 000 000", "one billion")]
        [DataRow("10 000 000 000", "ten billion")]
        [DataRow("17 300 200 100", "seventeen billion three hundred million two hundred thousand one hundred")]
        [DataRow("86 019 814 104", "eighty-six billion nineteen million eight hundred fourteen thousand one hundred four")]
        [DataRow("100 000 000 000", "one hundred billion")]
        [DataRow("323 415 020 003", "three hundred twenty-three billion four hundred fifteen million twenty thousand three")]
        [DataRow("1 000 000 000 000", "one trillion")]
        [DataRow("8 001 002 003 004", "eight trillion one billion two million three thousand four")]
        [DataRow("10 000 000 000 000", "ten trillion")]
        [DataRow("11 980 870 760 540", "eleven trillion nine hundred eighty billion eight hundred seventy million seven hundred sixty thousand five hundred forty")]
        [DataRow("36 090 080 070 060", "thirty-six trillion ninety billion eighty million seventy thousand sixty")]
        [DataRow("100 000 000 000 000", "one hundred trillion")]
        [DataRow("230 500 400 800 900", "two hundred thirty trillion five hundred billion four hundred million eight hundred thousand nine hundred")]
        [DataRow("477 856 001 010 491", "four hundred seventy-seven trillion eight hundred fifty-six billion one million ten thousand four hundred ninety-one")]
        [DataRow("1 000 000 000 000 000", "one quadrillion")]
        [DataRow("1 980 772 128 387 013", "one quadrillion nine hundred eighty trillion seven hundred seventy-two billion one hundred twenty-eight million three hundred eighty-seven thousand thirteen")]
        [DataRow("10 000 000 000 000 000", "ten quadrillion")]
        [DataRow("16 017 888 030 102 447", "sixteen quadrillion seventeen trillion eight hundred eighty-eight billion thirty million one hundred two thousand four hundred forty-seven")]
        [DataRow("100 000 000 000 000 000", "one hundred quadrillion")]
        [DataRow("987 654 321 012 345 678", "nine hundred eighty-seven quadrillion six hundred fifty-four trillion three hundred twenty-one billion twelve million three hundred forty-five thousand six hundred seventy-eight")]
        [DataRow("-1970", "minus one thousand seventy")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            var result = NumberToWordsConverter.ConvertNumberToWords(inputNumber: inputString, language: Language.English);
            Assert.AreEqual(expected: expectedResult, actual: result);            
        }
    }
}