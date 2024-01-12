using System.Text.RegularExpressions;
using static SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries.Converters.Tests.PriceToWordsConverterTests.Georgianeuro
{
    [TestClass]
    public class PriceToWordsConverterEuroEnglishWithZero
    {
        [DataTestMethod]
        #region Test Price In Words English - Euro - with zero
        [DataRow("0", "zero euros and zero cents")]
        [DataRow("0.07", "zero euros and seven cents")]
        [DataRow("0.15", "zero euros and fifteen cents")]
        [DataRow("0.31", "zero euros and thirty-one cents")]
        [DataRow("1", "one euro and zero cents")]
        [DataRow("1.01", "one euro and one cent")]
        [DataRow("1.10", "one euro and ten cents")]
        [DataRow("10.01", "ten euros and one cent")]
        [DataRow("21.22", "twenty-one euros and twenty-two cents")]
        [DataRow("43", "forty-three euros and zero cents")]
        [DataRow("467.63", "four hundred sixty-seven euros and sixty-three cents")]
        [DataRow("1 000", "one thousand euros and zero cents")]
        [DataRow("2 758.6", "two thousand seven hundred fifty-eight euros and sixty cents")]
        [DataRow("13 817.03", "thirteen thousand eight hundred seventeen euros and three cents")]
        [DataRow("198 407.07", "one hundred ninety-eight thousand four hundred seven euros and seven cents")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.English, currency: Currency.Euro, shouldConvertToWordsWhenZero: true);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }

    [TestClass]
    public class PriceToWordsConverterEuroEnglishWithoutZero
    {
        [DataTestMethod]
        #region Test Price In Words English - Euro - with zero
        [DataRow("0", "zero euros")]
        [DataRow("0.07", "seven euro cents")]
        [DataRow("0.15", "fifteen euro cents")]
        [DataRow("0.31", "thirty-one euro cents")]
        [DataRow("1", "one euro")]
        [DataRow("1.01", "one euro and one cent")]
        [DataRow("1.10", "one euro and ten cents")]
        [DataRow("10.01", "ten euros and one cent")]
        [DataRow("21.22", "twenty-one euros and twenty-two cents")]
        [DataRow("43", "forty-three euros")]
        [DataRow("467.63", "four hundred sixty-seven euros and sixty-three cents")]
        [DataRow("1 000", "one thousand euros")]
        [DataRow("2 758.6", "two thousand seven hundred fifty-eight euros and sixty cents")]
        [DataRow("13 817.03", "thirteen thousand eight hundred seventeen euros and three cents")]
        [DataRow("198 407.07", "one hundred ninety-eight thousand four hundred seven euros and seven cents")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.English, currency: Currency.Euro, shouldConvertToWordsWhenZero: false);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }
}