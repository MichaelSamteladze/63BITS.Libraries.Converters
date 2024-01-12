using System.Text.RegularExpressions;
using static SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries.Converters.Tests.PriceToWordsConverterTests.GeorgianLari
{
    [TestClass]
    public class PriceToWordsConverterRussianRubleGeorgianWithZero
    {
        [DataTestMethod]
        #region Test Price In Words Georgian - Ruble - with zero
        [DataRow("0", "ნული რუბლი და ნული კაპიკი")]
        [DataRow("0.15", "ნული რუბლი და თხუთმეტი კაპიკი")]
        [DataRow("1", "ერთი რუბლი და ნული კაპიკი")]
        [DataRow("10.10", "ათი რუბლი და ათი კაპიკი")]
        [DataRow("21.22", "ოცდაერთი რუბლი და ოცდაორი კაპიკი")]
        [DataRow("43", "ორმოცდასამი რუბლი და ნული კაპიკი")]
        [DataRow("467.63", "ოთხას სამოცდაშვიდი რუბლი და სამოცდასამი კაპიკი")]
        [DataRow("1 000", "ერთი ათასი რუბლი და ნული კაპიკი")]
        [DataRow("2 758.6", "ორი ათას შვიდას ორმოცდათვრამეტი რუბლი და სამოცი კაპიკი")]
        [DataRow("198 407.07", "ას ოთხმოცდათვრამეტი ათას ოთხას შვიდი რუბლი და შვიდი კაპიკი")]
        #endregion
        public void TestPriceToWordsConverterGeorgianLari(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.Georgian, currency: Currency.RussianRuble, shouldConvertToWordsWhenZero: true);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }

    [TestClass]
    public class PriceToWordsConverterRussianRubleGeorgianWithoutZero
    {
        [DataTestMethod]
        #region Test Price In Words Georgian - Ruble - with zero
        [DataRow("0", "ნული რუბლი")]
        [DataRow("0.15", "თხუთმეტი კაპიკი")]
        [DataRow("1", "ერთი რუბლი")]
        [DataRow("10.10", "ათი რუბლი და ათი კაპიკი")]
        [DataRow("21.22", "ოცდაერთი რუბლი და ოცდაორი კაპიკი")]
        [DataRow("43", "ორმოცდასამი რუბლი")]
        [DataRow("467.63", "ოთხას სამოცდაშვიდი რუბლი და სამოცდასამი კაპიკი")]
        [DataRow("1 000", "ერთი ათასი რუბლი")]
        [DataRow("2 758.6", "ორი ათას შვიდას ორმოცდათვრამეტი რუბლი და სამოცი კაპიკი")]
        [DataRow("198 407.07", "ას ოთხმოცდათვრამეტი ათას ოთხას შვიდი რუბლი და შვიდი კაპიკი")]
        #endregion
        public void TestPriceToWordsConverterGeorgianLari(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.Georgian, currency: Currency.RussianRuble, shouldConvertToWordsWhenZero: false);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }
}