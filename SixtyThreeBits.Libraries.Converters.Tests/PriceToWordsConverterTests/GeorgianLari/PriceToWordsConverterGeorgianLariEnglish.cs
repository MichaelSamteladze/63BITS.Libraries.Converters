using System.Text.RegularExpressions;
using static SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries.Converters.Tests.PriceToWordsConverterTests.GeorgianLari
{
    [TestClass]
    public class PriceToWordsConverterGeorgianLariEnglishWithZero
    {
        [DataTestMethod]
        #region Test Price In Words English - Lari - with zero
        [DataRow("0", "zero laris and zero tetris")]
        [DataRow("0.07", "zero laris and seven tetris")]
        [DataRow("0.15", "zero laris and fifteen tetris")]
        [DataRow("0.31", "zero laris and thirty-one tetris")]
        [DataRow("1", "one lari and zero tetris")]
        [DataRow("1.01", "one lari and one tetri")]
        [DataRow("1.10", "one lari and ten tetris")]
        [DataRow("10.01", "ten laris and one tetri")]
        [DataRow("21.22", "twenty-one laris and twenty-two tetris")]
        [DataRow("43", "forty-three laris and zero tetris")]
        [DataRow("467.63", "four hundred sixty-seven laris and sixty-three tetris")]
        [DataRow("1 000", "one thousand laris and zero tetris")]
        [DataRow("2 758.6", "two thousand seven hundred fifty-eight laris and sixty tetris")]
        [DataRow("13 817.03", "thirteen thousand eight hundred seventeen laris and three tetris")]
        [DataRow("198 407.07", "one hundred ninety-eight thousand four hundred seven laris and seven tetris")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.English, currency: Currency.Lari, shouldConvertToWordsWhenZero: true);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }

    [TestClass]
    public class PriceToWordsConverterGeorgianLariEnglishWithoutZero
    {
        [DataTestMethod]
        #region Test Price In Words English - Lari - with zero
        [DataRow("0", "zero laris")]
        [DataRow("0.07", "seven tetris")]
        [DataRow("0.15", "fifteen tetris")]
        [DataRow("0.31", "thirty-one tetris")]
        [DataRow("1", "one lari")]
        [DataRow("1.01", "one lari and one tetri")]
        [DataRow("1.10", "one lari and ten tetris")]
        [DataRow("10.01", "ten laris and one tetri")]
        [DataRow("21.22", "twenty-one laris and twenty-two tetris")]
        [DataRow("43", "forty-three laris")]
        [DataRow("467.63", "four hundred sixty-seven laris and sixty-three tetris")]
        [DataRow("1 000", "one thousand laris")]
        [DataRow("2 758.6", "two thousand seven hundred fifty-eight laris and sixty tetris")]
        [DataRow("13 817.03", "thirteen thousand eight hundred seventeen laris and three tetris")]
        [DataRow("198 407.07", "one hundred ninety-eight thousand four hundred seven laris and seven tetris")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.English, currency: Currency.Lari, shouldConvertToWordsWhenZero: false);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }
}