﻿using System.Text.RegularExpressions;
using SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries.Converters.Tests.NumberToWordsConverterTests
{
    [TestClass]
    public class NumberInWordsConverterTestsGeorgian
    {
        [DataTestMethod]
        #region Test Number In Words Georgian
        [DataRow("0", "ნული")]
        [DataRow("1", "ერთი")]
        [DataRow("2", "ორი")]
        [DataRow("3", "სამი")]
        [DataRow("4", "ოთხი")]
        [DataRow("5", "ხუთი")]
        [DataRow("6", "ექვსი")]
        [DataRow("7", "შვიდი")]
        [DataRow("8", "რვა")]
        [DataRow("9", "ცხრა")]
        [DataRow("10", "ათი")]
        [DataRow("11", "თერთმეტი")]
        [DataRow("12", "თორმეტი")]
        [DataRow("13", "ცამეტი")]
        [DataRow("14", "თოთხმეტი")]
        [DataRow("15", "თხუთმეტი")]
        [DataRow("16", "თექვსმეტი")]
        [DataRow("17", "ჩვიდმეტი")]
        [DataRow("18", "თვრამეტი")]
        [DataRow("19", "ცხრამეტი")]
        [DataRow("20", "ოცი")]
        [DataRow("21", "ოცდაერთი")]
        [DataRow("22", "ოცდაორი")]
        [DataRow("23", "ოცდასამი")]
        [DataRow("24", "ოცდაოთხი")]
        [DataRow("25", "ოცდახუთი")]
        [DataRow("26", "ოცდაექვსი")]
        [DataRow("27", "ოცდაშვიდი")]
        [DataRow("28", "ოცდარვა")]
        [DataRow("29", "ოცდაცხრა")]
        [DataRow("30", "ოცდაათი")]
        [DataRow("31", "ოცდათერთმეტი")]
        [DataRow("32", "ოცდათორმეტი")]
        [DataRow("33", "ოცდაცამეტი")]
        [DataRow("34", "ოცდათოთხმეტი")]
        [DataRow("35", "ოცდათხუთმეტი")]
        [DataRow("36", "ოცდათექვსმეტი")]
        [DataRow("37", "ოცდაჩვიდმეტი")]
        [DataRow("38", "ოცდათვრამეტი")]
        [DataRow("39", "ოცდაცხრამეტი")]
        [DataRow("40", "ორმოცი")]
        [DataRow("41", "ორმოცდაერთი")]
        [DataRow("42", "ორმოცდაორი")]
        [DataRow("43", "ორმოცდასამი")]
        [DataRow("44", "ორმოცდაოთხი")]
        [DataRow("45", "ორმოცდახუთი")]
        [DataRow("46", "ორმოცდაექვსი")]
        [DataRow("47", "ორმოცდაშვიდი")]
        [DataRow("48", "ორმოცდარვა")]
        [DataRow("49", "ორმოცდაცხრა")]
        [DataRow("50", "ორმოცდაათი")]
        [DataRow("51", "ორმოცდათერთმეტი")]
        [DataRow("52", "ორმოცდათორმეტი")]
        [DataRow("53", "ორმოცდაცამეტი")]
        [DataRow("54", "ორმოცდათოთხმეტი")]
        [DataRow("55", "ორმოცდათხუთმეტი")]
        [DataRow("56", "ორმოცდათექვსმეტი")]
        [DataRow("57", "ორმოცდაჩვიდმეტი")]
        [DataRow("58", "ორმოცდათვრამეტი")]
        [DataRow("59", "ორმოცდაცხრამეტი")]
        [DataRow("60", "სამოცი")]
        [DataRow("61", "სამოცდაერთი")]
        [DataRow("62", "სამოცდაორი")]
        [DataRow("63", "სამოცდასამი")]
        [DataRow("64", "სამოცდაოთხი")]
        [DataRow("65", "სამოცდახუთი")]
        [DataRow("66", "სამოცდაექვსი")]
        [DataRow("67", "სამოცდაშვიდი")]
        [DataRow("68", "სამოცდარვა")]
        [DataRow("69", "სამოცდაცხრა")]
        [DataRow("70", "სამოცდაათი")]
        [DataRow("71", "სამოცდათერთმეტი")]
        [DataRow("72", "სამოცდათორმეტი")]
        [DataRow("73", "სამოცდაცამეტი")]
        [DataRow("74", "სამოცდათოთხმეტი")]
        [DataRow("75", "სამოცდათხუთმეტი")]
        [DataRow("76", "სამოცდათექვსმეტი")]
        [DataRow("77", "სამოცდაჩვიდმეტი")]
        [DataRow("78", "სამოცდათვრამეტი")]
        [DataRow("79", "სამოცდაცხრამეტი")]
        [DataRow("80", "ოთხმოცი")]
        [DataRow("81", "ოთხმოცდაერთი")]
        [DataRow("82", "ოთხმოცდაორი")]
        [DataRow("83", "ოთხმოცდასამი")]
        [DataRow("84", "ოთხმოცდაოთხი")]
        [DataRow("85", "ოთხმოცდახუთი")]
        [DataRow("86", "ოთხმოცდაექვსი")]
        [DataRow("87", "ოთხმოცდაშვიდი")]
        [DataRow("88", "ოთხმოცდარვა")]
        [DataRow("89", "ოთხმოცდაცხრა")]
        [DataRow("90", "ოთხმოცდაათი")]
        [DataRow("91", "ოთხმოცდათერთმეტი")]
        [DataRow("92", "ოთხმოცდათორმეტი")]
        [DataRow("93", "ოთხმოცდაცამეტი")]
        [DataRow("94", "ოთხმოცდათოთხმეტი")]
        [DataRow("95", "ოთხმოცდათხუთმეტი")]
        [DataRow("96", "ოთხმოცდათექვსმეტი")]
        [DataRow("97", "ოთხმოცდაჩვიდმეტი")]
        [DataRow("98", "ოთხმოცდათვრამეტი")]
        [DataRow("99", "ოთხმოცდაცხრამეტი")]
        [DataRow("100", "ასი")]
        [DataRow("101", "ას ერთი")]
        [DataRow("112", "ას თორმეტი")]
        [DataRow("123", "ას ოცდასამი")]
        [DataRow("200", "ორასი")]
        [DataRow("245", "ორას ორმოცდახუთი")]
        [DataRow("300", "სამასი")]
        [DataRow("356", "სამას ორმოცდათექვსმეტი")]
        [DataRow("400", "ოთხასი")]
        [DataRow("467", "ოთხას სამოცდაშვიდი")]
        [DataRow("500", "ხუთასი")]
        [DataRow("578", "ხუთას სამოცდათვრამეტი")]
        [DataRow("600", "ექვსასი")]
        [DataRow("689", "ექვსას ოთხმოცდაცხრა")]
        [DataRow("700", "შვიდასი")]
        [DataRow("723", "შვიდას ოცდასამი")]
        [DataRow("800", "რვაასი")]
        [DataRow("833", "რვაას ოცდაცამეტი")]
        [DataRow("900", "ცხრაასი")]
        [DataRow("900", "ცხრაასი")]
        [DataRow("991", "ცხრაას ოთხმოცდათერთმეტი")]
        [DataRow("1 000", "ერთი ათასი")]
        [DataRow("1 123", "ერთი ათას ას ოცდასამი")]
        [DataRow("2 004", "ორი ათას ოთხი")]
        [DataRow("3 300", "სამი ათას სამასი")]
        [DataRow("4 530", "ოთხი ათას ხუთას ოცდაათი")]
        [DataRow("15 728", "თხუთმეტი ათას შვიდას ოცდარვა")]
        [DataRow("37 018", "ოცდაჩვიდმეტი ათას თვრამეტი")]
        [DataRow("50 000", "ორმოცდაათი ათასი")]
        [DataRow("150 706", "ას ორმოცდაათი ათას შვიდას ექვსი")]
        [DataRow("400 009", "ოთხასი ათას ცხრა")]
        [DataRow("580 023", "ხუთას ოთხმოცი ათას ოცდასამი")]
        [DataRow("704 596", "შვიდას ოთხი ათას ხუთას ოთხმოცდათექვსმეტი")]
        [DataRow("800 604", "რვაასი ათას ექვსას ოთხი")]
        [DataRow("1 000 000", "ერთი მილიონი")]
        [DataRow("3 070 008", "სამი მილიონ სამოცდაათი ათას რვა")]
        [DataRow("8 001 012", "რვა მილიონ ერთი ათას თორმეტი")]
        [DataRow("9 000 343", "ცხრა მილიონ სამას ორმოცდასამი")]
        [DataRow("12 002 860", "თორმეტი მილიონ ორი ათას რვაას სამოცი")]
        [DataRow("357 035 792", "სამას ორმოცდაჩვიდმეტი მილიონ ოცდათხუთმეტი ათას შვიდას ოთხმოცდათორმეტი")]
        [DataRow("1 000 000 000", "ერთი მილიარდი")]
        [DataRow("1 851 742 178", "ერთი მილიარდ რვაას ორმოცდათერთმეტი მილიონ შვიდას ორმოცდაორი ათას ას სამოცდათვრამეტი")]
        [DataRow("27 000 800 007", "ოცდაშვიდი მილიარდ რვაასი ათას შვიდი")]
        [DataRow("358 005 801 028", "სამას ორმოცდათვრამეტი მილიარდ ხუთი მილიონ რვაას ერთი ათას ოცდარვა")]
        [DataRow("1 000 000 000 000", "ერთი ტრილიონი")]
        [DataRow("1 007 049 017 563", "ერთი ტრილიონ შვიდი მილიარდ ორმოცდაცხრა მილიონ ჩვიდმეტი ათას ხუთას სამოცდასამი")]
        [DataRow("1 053 000 000 000", "ერთი ტრილიონ ორმოცდაცამეტი მილიარდი")]
        [DataRow("706 815 105 603 150", "შვიდას ექვსი ტრილიონ რვაას თხუთმეტი მილიარდ ას ხუთი მილიონ ექვსას სამი ათას ას ორმოცდაათი")]
        [DataRow("1 000 000 000 000 000", "ერთი კვადრილიონი")]
        [DataRow("1 041 063 008 227 705", "ერთი კვადრილიონ ორმოცდაერთი ტრილიონ სამოცდასამი მილიარდ რვა მილიონ ორას ოცდაშვიდი ათას შვიდას ხუთი")]
        [DataRow("951 705 000 344 085 969", "ცხრაას ორმოცდათერთმეტი კვადრილიონ შვიდას ხუთი ტრილიონ სამას ორმოცდაოთხი მილიონ ოთხმოცდახუთი ათას ცხრაას სამოცდაცხრა")]
        [DataRow("-1970","მინუს ერთი ათას ცხრაას სამოცდაათი")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            var result = NumberToWordsConverter.ConvertNumberToWords(inputNumber: inputString, language: Language.Georgian);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }
}