using System.Text.RegularExpressions;
using SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries.Converters.Tests.PriceToWordsConverterTests.GeorgianLari
{
    [TestClass]
    public class PriceToWordsConverterUSDollarGeorgianWithZero
    {
        [DataTestMethod]
        #region Test Price In Words Georgian - US Dollar - with zero
        [DataRow("0", "ნული აშშ დოლარი და ნული ცენტი")]
        [DataRow("0.15", "ნული აშშ დოლარი და თხუთმეტი ცენტი")]
        [DataRow("1", "ერთი აშშ დოლარი და ნული ცენტი")]
        [DataRow("10.10", "ათი აშშ დოლარი და ათი ცენტი")]
        [DataRow("21.22", "ოცდაერთი აშშ დოლარი და ოცდაორი ცენტი")]
        [DataRow("43", "ორმოცდასამი აშშ დოლარი და ნული ცენტი")]
        [DataRow("467.63", "ოთხას სამოცდაშვიდი აშშ დოლარი და სამოცდასამი ცენტი")]
        [DataRow("1 000", "ერთი ათასი აშშ დოლარი და ნული ცენტი")]
        [DataRow("2 758.6", "ორი ათას შვიდას ორმოცდათვრამეტი აშშ დოლარი და სამოცი ცენტი")]
        [DataRow("198 407.07", "ას ოთხმოცდათვრამეტი ათას ოთხას შვიდი აშშ დოლარი და შვიდი ცენტი")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.Georgian, currency: Currency.USDollar, shouldConvertToWordsWhenZero: true);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }

    [TestClass]
    public class PriceToWordsConverterUSDollarGeorgianWithoutZero
    {
        [DataTestMethod]
        #region Test Price In Words Georgian - US Dollar - with zero
        [DataRow("0", "ნული აშშ დოლარი")]
        [DataRow("0.15", "თხუთმეტი ცენტი")]
        [DataRow("1", "ერთი აშშ დოლარი")]
        [DataRow("10.10", "ათი აშშ დოლარი და ათი ცენტი")]
        [DataRow("21.22", "ოცდაერთი აშშ დოლარი და ოცდაორი ცენტი")]
        [DataRow("43", "ორმოცდასამი აშშ დოლარი")]
        [DataRow("467.63", "ოთხას სამოცდაშვიდი აშშ დოლარი და სამოცდასამი ცენტი")]
        [DataRow("1 000", "ერთი ათასი აშშ დოლარი")]
        [DataRow("2 758.6", "ორი ათას შვიდას ორმოცდათვრამეტი აშშ დოლარი და სამოცი ცენტი")]
        [DataRow("198 407.07", "ას ოთხმოცდათვრამეტი ათას ოთხას შვიდი აშშ დოლარი და შვიდი ცენტი")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.Georgian, currency: Currency.USDollar, shouldConvertToWordsWhenZero: false);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }
}