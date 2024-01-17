using System.Text.RegularExpressions;
using SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries.Converters.Tests.PriceToWordsConverterTests.GeorgianLari
{
    [TestClass]
    public class PriceToWordsConverterUSDollarRussianWithZero
    {
        [DataTestMethod]
        #region Test Price In Words Russian - US Dollar - with zero
        [DataRow("0", "ноль долларов сша и ноль центов")]
        [DataRow("0.01", "ноль долларов сша и один цент")]
        [DataRow("0.02", "ноль долларов сша и два цента")]
        [DataRow("0.03", "ноль долларов сша и три цента")]
        [DataRow("0.04", "ноль долларов сша и четыре цента")]
        [DataRow("0.07", "ноль долларов сша и семь центов")]
        [DataRow("0.15", "ноль долларов сша и пятнадцать центов")]
        [DataRow("0.31", "ноль долларов сша и тридцать один цент")]
        [DataRow("0.42", "ноль долларов сша и сорок два цента")]
        [DataRow("1", "один доллар сша и ноль центов")]
        [DataRow("1.01", "один доллар сша и один цент")]
        [DataRow("1.10", "один доллар сша и десять центов")]
        [DataRow("2.03", "два доллара сша и три цента")]
        [DataRow("4.05", "четыре доллара сша и пять центов")]
        [DataRow("10.01", "десять долларов сша и один цент")]        
        [DataRow("21.22", "двадцать один доллар сша и двадцать два цента")]
        [DataRow("31", "тридцать один доллар сша и ноль центов")]
        [DataRow("32.22", "тридцать два доллара сша и двадцать два цента")]
        [DataRow("43", "сорок три доллара сша и ноль центов")]
        [DataRow("467.63", "четыреста шестьдесят семь долларов сша и шестьдесят три цента")]
        [DataRow("1 000", "одна тысяча долларов сша и ноль центов")]
        [DataRow("2 758.6", "две тысячи семьсот пятьдесят восемь долларов сша и шестьдесят центов")]
        [DataRow("13 817.03", "тринадцать тысяч восемьсот семнадцать долларов сша и три цента")]
        [DataRow("198 407.07", "сто девяносто восемь тысяч четыреста семь долларов сша и семь центов")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.Russian, currency: Currency.USDollar, shouldConvertToWordsWhenZero: true);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }

    public class PriceToWordsConverterUSDollarRussianWithoutZero
    {
        [DataTestMethod]
        #region Test Price In Words Russian - US Dollar - without zero
        [DataRow("0", "ноль долларов сша")]
        [DataRow("0.01", "один цент")]
        [DataRow("0.02", "два цента")]
        [DataRow("0.03", "три цента")]
        [DataRow("0.04", "четыре цента")]
        [DataRow("0.07", "семь центов")]
        [DataRow("0.15", "пятнадцать центов")]
        [DataRow("0.31", "тридцать один цент")]
        [DataRow("0.42", "сорок два цента")]
        [DataRow("1", "один доллар сша")]
        [DataRow("1.01", "один доллар сша и один цент")]
        [DataRow("1.10", "один доллар сша и десять центов")]
        [DataRow("2.03", "два доллара сша и три цента")]
        [DataRow("4.05", "четыре доллара сша и пять центов")]
        [DataRow("10.01", "десять долларов сша и один цент")]
        [DataRow("21.22", "двадцать один доллар сша и двадцать два цента")]
        [DataRow("31", "тридцать один доллар сша")]
        [DataRow("32.22", "тридцать два доллара сша и двадцать два цента")]
        [DataRow("43", "сорок три доллара сша")]
        [DataRow("467.63", "четыреста шестьдесят семь долларов сша и шестьдесят три цента")]
        [DataRow("1 000", "одна тысяча долларов сша")]
        [DataRow("2 758.6", "две тысячи семьсот пятьдесят восемь долларов сша и шестьдесят центов")]
        [DataRow("13 817.03", "тринадцать тысяч восемьсот семнадцать долларов сша и три цента")]
        [DataRow("198 407.07", "сто девяносто восемь тысяч четыреста семь долларов сша и семь центов")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.Russian, currency: Currency.USDollar, shouldConvertToWordsWhenZero: false);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }
}