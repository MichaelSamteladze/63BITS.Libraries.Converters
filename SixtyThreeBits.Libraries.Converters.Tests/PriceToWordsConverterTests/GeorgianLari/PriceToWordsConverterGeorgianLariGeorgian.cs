using System.Text.RegularExpressions;
using SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries.Converters.Tests.PriceToWordsConverterTests.GeorgianLari
{
    [TestClass]
    public class PriceToWordsConverterGeorgianLariGeorgianWithZero
    {
        [DataTestMethod]
        #region Test Price In Words Georgian - Lari - with zero
        [DataRow("0", "ნული ლარი და ნული თეთრი")]
        [DataRow("0.15", "ნული ლარი და თხუთმეტი თეთრი")]
        [DataRow("1", "ერთი ლარი და ნული თეთრი")]
        [DataRow("10.10", "ათი ლარი და ათი თეთრი")]
        [DataRow("21.22", "ოცდაერთი ლარი და ოცდაორი თეთრი")]
        [DataRow("43", "ორმოცდასამი ლარი და ნული თეთრი")]
        [DataRow("467.63", "ოთხას სამოცდაშვიდი ლარი და სამოცდასამი თეთრი")]
        [DataRow("1 000", "ერთი ათასი ლარი და ნული თეთრი")]
        [DataRow("2 758.6", "ორი ათას შვიდას ორმოცდათვრამეტი ლარი და სამოცი თეთრი")]
        [DataRow("198 407.07", "ას ოთხმოცდათვრამეტი ათას ოთხას შვიდი ლარი და შვიდი თეთრი")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.Georgian, currency: Currency.Lari, shouldConvertToWordsWhenZero: true);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }

    [TestClass]
    public class PriceToWordsConverterGeorgianLariGeorgianWithoutZero
    {
        [DataTestMethod]
        #region Test Price In Words Georgian - Lari - with zero
        [DataRow("0", "ნული ლარი")]
        [DataRow("0.15", "თხუთმეტი თეთრი")]
        [DataRow("1", "ერთი ლარი")]
        [DataRow("10.10", "ათი ლარი და ათი თეთრი")]
        [DataRow("21.22", "ოცდაერთი ლარი და ოცდაორი თეთრი")]
        [DataRow("43", "ორმოცდასამი ლარი")]
        [DataRow("467.63", "ოთხას სამოცდაშვიდი ლარი და სამოცდასამი თეთრი")]
        [DataRow("1 000", "ერთი ათასი ლარი")]
        [DataRow("2 758.6", "ორი ათას შვიდას ორმოცდათვრამეტი ლარი და სამოცი თეთრი")]
        [DataRow("198 407.07", "ას ოთხმოცდათვრამეტი ათას ოთხას შვიდი ლარი და შვიდი თეთრი")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.Georgian, currency: Currency.Lari, shouldConvertToWordsWhenZero: false);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }
}