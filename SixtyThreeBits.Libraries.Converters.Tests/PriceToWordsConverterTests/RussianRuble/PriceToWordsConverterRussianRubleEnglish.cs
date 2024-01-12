using System.Text.RegularExpressions;
using static SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries.Converters.Tests.PriceToWordsConverterTests.Georgiandollar
{
    [TestClass]
    public class PriceToWordsConverterRussianRubleEnglishWithZero
    {
        [DataTestMethod]
        #region Test Price In Words English - Russian Ruble - with zero
        [DataRow("0", "zero rubles and zero kopeks")]
        [DataRow("0.01", "zero rubles and one kopek")]
        [DataRow("0.07", "zero rubles and seven kopeks")]
        [DataRow("0.15", "zero rubles and fifteen kopeks")]
        [DataRow("0.31", "zero rubles and thirty-one kopeks")]
        [DataRow("1", "one ruble and zero kopeks")]
        [DataRow("1.01", "one ruble and one kopek")]
        [DataRow("1.10", "one ruble and ten kopeks")]
        [DataRow("10.01", "ten rubles and one kopek")]
        [DataRow("21.22", "twenty-one rubles and twenty-two kopeks")]
        [DataRow("43", "forty-three rubles and zero kopeks")]
        [DataRow("63.01", "sixty-three rubles and one kopek")]
        [DataRow("467.63", "four hundred sixty-seven rubles and sixty-three kopeks")]
        [DataRow("1 000", "one thousand rubles and zero kopeks")]
        [DataRow("2 758.6", "two thousand seven hundred fifty-eight rubles and sixty kopeks")]
        [DataRow("13 817.03", "thirteen thousand eight hundred seventeen rubles and three kopeks")]
        [DataRow("198 407.07", "one hundred ninety-eight thousand four hundred seven rubles and seven kopeks")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.English, currency: Currency.RussianRuble, shouldConvertToWordsWhenZero: true);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }

    [TestClass]
    public class PriceToWordsConverterRussianRubleEnglishWithoutZero
    {
        [DataTestMethod]
        #region Test Price In Words English - Russian Ruble - with zero
        [DataRow("0", "zero rubles")]
        [DataRow("0.01", "one kopek")]
        [DataRow("0.07", "seven kopeks")]
        [DataRow("0.15", "fifteen kopeks")]
        [DataRow("0.31", "thirty-one kopeks")]
        [DataRow("1", "one ruble")]
        [DataRow("1.01", "one ruble and one kopek")]
        [DataRow("1.10", "one ruble and ten kopeks")]
        [DataRow("10.01", "ten rubles and one kopek")]
        [DataRow("21.22", "twenty-one rubles and twenty-two kopeks")]
        [DataRow("43", "forty-three rubles")]
        [DataRow("63.01", "sixty-three rubles and one kopek")]
        [DataRow("467.63", "four hundred sixty-seven rubles and sixty-three kopeks")]
        [DataRow("1 000", "one thousand rubles")]
        [DataRow("2 758.6", "two thousand seven hundred fifty-eight rubles and sixty kopeks")]
        [DataRow("13 817.03", "thirteen thousand eight hundred seventeen rubles and three kopeks")]
        [DataRow("198 407.07", "one hundred ninety-eight thousand four hundred seven rubles and seven kopeks")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.English, currency: Currency.RussianRuble, shouldConvertToWordsWhenZero: false);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }
}