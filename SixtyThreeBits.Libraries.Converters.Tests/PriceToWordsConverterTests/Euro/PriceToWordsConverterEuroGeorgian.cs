using System.Text.RegularExpressions;
using static SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries.Converters.Tests.PriceToWordsConverterTests.GeorgianLari
{
    [TestClass]
    public class PriceToWordsConverterEuroGeorgianWithZero
    {
        [DataTestMethod]
        #region Test Price In Words Georgian - Euro - with zero
        [DataRow("0", "ნული ევრო და ნული ცენტი")]
        [DataRow("0.15", "ნული ევრო და თხუთმეტი ცენტი")]
        [DataRow("1", "ერთი ევრო და ნული ცენტი")]
        [DataRow("10.10", "ათი ევრო და ათი ცენტი")]
        [DataRow("21.22", "ოცდაერთი ევრო და ოცდაორი ცენტი")]
        [DataRow("43", "ორმოცდასამი ევრო და ნული ცენტი")]
        [DataRow("467.63", "ოთხას სამოცდაშვიდი ევრო და სამოცდასამი ცენტი")]
        [DataRow("1 000", "ერთი ათასი ევრო და ნული ცენტი")]
        [DataRow("2 758.6", "ორი ათას შვიდას ორმოცდათვრამეტი ევრო და სამოცი ცენტი")]
        [DataRow("198 407.07", "ას ოთხმოცდათვრამეტი ათას ოთხას შვიდი ევრო და შვიდი ცენტი")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.Georgian, currency: Currency.Euro, shouldConvertToWordsWhenZero: true);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }

    [TestClass]
    public class PriceToWordsConverterEuroGeorgianWithoutZero
    {
        [DataTestMethod]
        #region Test Price In Words Georgian - Euro - with zero
        [DataRow("0", "ნული ევრო")]
        [DataRow("0.01", "ერთი ევრო ცენტი")]
        [DataRow("0.15", "თხუთმეტი ევრო ცენტი")]
        [DataRow("1", "ერთი ევრო")]
        [DataRow("10.10", "ათი ევრო და ათი ცენტი")]
        [DataRow("21.22", "ოცდაერთი ევრო და ოცდაორი ცენტი")]
        [DataRow("43", "ორმოცდასამი ევრო")]
        [DataRow("467.63", "ოთხას სამოცდაშვიდი ევრო და სამოცდასამი ცენტი")]
        [DataRow("1 000", "ერთი ათასი ევრო")]
        [DataRow("2 758.6", "ორი ათას შვიდას ორმოცდათვრამეტი ევრო და სამოცი ცენტი")]
        [DataRow("198 407.07", "ას ოთხმოცდათვრამეტი ათას ოთხას შვიდი ევრო და შვიდი ცენტი")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.Georgian, currency: Currency.Euro, shouldConvertToWordsWhenZero: false);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }
}