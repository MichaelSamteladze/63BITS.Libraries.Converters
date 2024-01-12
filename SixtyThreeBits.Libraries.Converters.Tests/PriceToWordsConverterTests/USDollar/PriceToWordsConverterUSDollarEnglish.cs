using System.Text.RegularExpressions;
using static SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries.Converters.Tests.PriceToWordsConverterTests.Georgiandollar
{
    [TestClass]
    public class PriceToWordsConverterUSDollarEnglishWithZero
    {
        [DataTestMethod]
        #region Test Price In Words English - US Dollar - with zero
        [DataRow("0", "zero us dollars and zero cents")]
        [DataRow("0.01", "zero us dollars and one cent")]
        [DataRow("0.07", "zero us dollars and seven cents")]
        [DataRow("0.15", "zero us dollars and fifteen cents")]
        [DataRow("0.31", "zero us dollars and thirty-one cents")]
        [DataRow("1", "one us dollar and zero cents")]
        [DataRow("1.01", "one us dollar and one cent")]
        [DataRow("1.10", "one us dollar and ten cents")]
        [DataRow("10.01", "ten us dollars and one cent")]
        [DataRow("21.22", "twenty-one us dollars and twenty-two cents")]
        [DataRow("43", "forty-three us dollars and zero cents")]
        [DataRow("63.01", "sixty-three us dollars and one cent")]
        [DataRow("467.63", "four hundred sixty-seven us dollars and sixty-three cents")]
        [DataRow("1 000", "one thousand us dollars and zero cents")]
        [DataRow("2 758.6", "two thousand seven hundred fifty-eight us dollars and sixty cents")]
        [DataRow("13 817.03", "thirteen thousand eight hundred seventeen us dollars and three cents")]
        [DataRow("198 407.07", "one hundred ninety-eight thousand four hundred seven us dollars and seven cents")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.English, currency: Currency.USDollar, shouldConvertToWordsWhenZero: true);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }

    [TestClass]
    public class PriceToWordsConverterUSDollarEnglishWithoutZero
    {
        [DataTestMethod]
        #region Test Price In Words English - US Dollar - with zero
        [DataRow("0", "zero us dollars")]
        [DataRow("0.01", "one cent")]
        [DataRow("0.07", "seven cents")]
        [DataRow("0.15", "fifteen cents")]
        [DataRow("0.31", "thirty-one cents")]
        [DataRow("1", "one us dollar")]
        [DataRow("1.01", "one us dollar and one cent")]
        [DataRow("1.10", "one us dollar and ten cents")]
        [DataRow("10.01", "ten us dollars and one cent")]
        [DataRow("21.22", "twenty-one us dollars and twenty-two cents")]
        [DataRow("43", "forty-three us dollars")]
        [DataRow("63.01", "sixty-three us dollars and one cent")]
        [DataRow("467.63", "four hundred sixty-seven us dollars and sixty-three cents")]
        [DataRow("1 000", "one thousand us dollars")]
        [DataRow("2 758.6", "two thousand seven hundred fifty-eight us dollars and sixty cents")]
        [DataRow("13 817.03", "thirteen thousand eight hundred seventeen us dollars and three cents")]
        [DataRow("198 407.07", "one hundred ninety-eight thousand four hundred seven us dollars and seven cents")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.English, currency: Currency.USDollar, shouldConvertToWordsWhenZero: false);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }
}