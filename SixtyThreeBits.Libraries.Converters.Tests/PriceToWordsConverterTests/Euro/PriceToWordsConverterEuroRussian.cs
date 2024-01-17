using System.Text.RegularExpressions;
using SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries.Converters.Tests.PriceToWordsConverterTests.GeorgianLari
{
    [TestClass]
    public class PriceToWordsConverterEuroRussianWithZero
    {
        [DataTestMethod]
        #region Test Price In Words Russian - Euro - with zero
        [DataRow("0", "ноль эвро и ноль центов")]
        [DataRow("0.01", "ноль эвро и один цент")]
        [DataRow("0.02", "ноль эвро и два цента")]
        [DataRow("0.03", "ноль эвро и три цента")]
        [DataRow("0.04", "ноль эвро и четыре цента")]
        [DataRow("0.07", "ноль эвро и семь центов")]
        [DataRow("0.15", "ноль эвро и пятнадцать центов")]
        [DataRow("0.31", "ноль эвро и тридцать один цент")]
        [DataRow("0.42", "ноль эвро и сорок два цента")]
        [DataRow("1", "один эвро и ноль центов")]
        [DataRow("1.01", "один эвро и один цент")]
        [DataRow("1.10", "один эвро и десять центов")]
        [DataRow("2.03", "два эвро и три цента")]
        [DataRow("4.05", "четыре эвро и пять центов")]
        [DataRow("10.01", "десять эвро и один цент")]        
        [DataRow("21.22", "двадцать один эвро и двадцать два цента")]
        [DataRow("31", "тридцать один эвро и ноль центов")]
        [DataRow("32.22", "тридцать два эвро и двадцать два цента")]
        [DataRow("43", "сорок три эвро и ноль центов")]
        [DataRow("467.63", "четыреста шестьдесят семь эвро и шестьдесят три цента")]
        [DataRow("1 000", "одна тысяча эвро и ноль центов")]
        [DataRow("2 758.6", "две тысячи семьсот пятьдесят восемь эвро и шестьдесят центов")]
        [DataRow("13 817.03", "тринадцать тысяч восемьсот семнадцать эвро и три цента")]
        [DataRow("198 407.07", "сто девяносто восемь тысяч четыреста семь эвро и семь центов")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.Russian, currency: Currency.Euro, shouldConvertToWordsWhenZero: true);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }

    public class PriceToWordsConverterEuroRussianWithoutZero
    {
        [DataTestMethod]
        #region Test Price In Words Russian - Euro - without zero
        [DataRow("0", "ноль эвро")]
        [DataRow("0.01", "один эвро цент")]
        [DataRow("0.02", "два эвро цента")]
        [DataRow("0.03", "три эвро цента")]
        [DataRow("0.04", "четыре эвро цента")]
        [DataRow("0.07", "семь эвро центов")]
        [DataRow("0.15", "пятнадцать эвро центов")]
        [DataRow("0.31", "тридцать один эвро цент")]
        [DataRow("0.42", "сорок два эвро цента")]
        [DataRow("1", "один эвро")]
        [DataRow("1.01", "один эвро и один цент")]
        [DataRow("1.10", "один эвро и десять центов")]
        [DataRow("2.03", "два эвро и три цента")]
        [DataRow("4.05", "четыре эвро и пять центов")]
        [DataRow("10.01", "десять эвро и один цент")]
        [DataRow("21.22", "двадцать один эвро и двадцать два цента")]
        [DataRow("31", "тридцать один эвро")]
        [DataRow("32.22", "тридцать два эвро и двадцать два цента")]
        [DataRow("43", "сорок три эвро")]
        [DataRow("467.63", "четыреста шестьдесят семь эвро и шестьдесят три цента")]
        [DataRow("1 000", "одна тысяча эвро")]
        [DataRow("2 758.6", "две тысячи семьсот пятьдесят восемь эвро и шестьдесят центов")]
        [DataRow("13 817.03", "тринадцать тысяч восемьсот семнадцать эвро и три цента")]
        [DataRow("198 407.07", "сто девяносто восемь тысяч четыреста семь эвро и семь центов")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.Russian, currency: Currency.Euro, shouldConvertToWordsWhenZero: false);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }
}