using System.Text.RegularExpressions;
using static SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries.Converters.Tests.PriceToWordsConverterTests.GeorgianLari
{
    [TestClass]
    public class PriceToWordsConverterGeorgianLariRussianWithZero
    {
        [DataTestMethod]
        #region Test Price In Words Russian - Lari - with zero
        [DataRow("0", "ноль лари и ноль тетри")]
        [DataRow("0.07", "ноль лари и семь тетри")]
        [DataRow("0.15", "ноль лари и пятнадцать тетри")]
        [DataRow("0.31", "ноль лари и тридцать один тетри")]
        [DataRow("1", "один лари и ноль тетри")]
        [DataRow("1.01", "один лари и один тетри")]
        [DataRow("1.10", "один лари и десять тетри")]
        [DataRow("10.01", "десять лари и один тетри")]
        [DataRow("21.22", "двадцать один лари и двадцать два тетри")]
        [DataRow("43", "сорок три лари и ноль тетри")]
        [DataRow("467.63", "четыреста шестьдесят семь лари и шестьдесят три тетри")]
        [DataRow("1 000", "одна тысяча лари и ноль тетри")]
        [DataRow("2 758.6", "две тысячи семьсот пятьдесят восемь лари и шестьдесят тетри")]
        [DataRow("13 817.03", "тринадцать тысяч восемьсот семнадцать лари и три тетри")]
        [DataRow("198 407.07", "сто девяносто восемь тысяч четыреста семь лари и семь тетри")]
        #endregion
        public void TestPriceToWordsConverterGeorgianLari(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.Russian, currency: Currency.Lari, shouldConvertToWordsWhenZero: true);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }

    public class PriceToWordsConverterGeorgianLariRussianWithoutZero
    {
        [DataTestMethod]
        #region Test Price In Words Russian - Lari - without zero
        [DataRow("0", "ноль лари")]
        [DataRow("0.07", "семь тетри")]
        [DataRow("0.15", "пятнадцать тетри")]
        [DataRow("0.31", "тридцать один тетри")]
        [DataRow("1", "один лари и ноль тетри")]
        [DataRow("1.01", "один лари и один тетри")]
        [DataRow("1.10", "один лари и десять тетри")]
        [DataRow("10.01", "десять лари и один тетри")]
        [DataRow("21.22", "двадцать один лари и двадцать два тетри")]
        [DataRow("43", "сорок три лари")]
        [DataRow("467.63", "четыреста шестьдесят семь лари и шестьдесят три тетри")]
        [DataRow("1 000", "одна тысяча лари")]
        [DataRow("2 758.6", "две тысячи семьсот пятьдесят восемь лари и шестьдесят тетри")]
        [DataRow("13 817.03", "тринадцать тысяч восемьсот семнадцать лари и три тетри")]
        [DataRow("198 407.07", "сто девяносто восемь тысяч четыреста семь лари и семь тетри")]
        #endregion
        public void TestPriceToWordsConverterGeorgianLari(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.Russian, currency: Currency.Lari, shouldConvertToWordsWhenZero: false);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }
}