using System.Text.RegularExpressions;
using static SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries.Converters.Tests.PriceToWordsConverterTests.GeorgianLari
{
    [TestClass]
    public class PriceToWordsConverterRussianRubleRussianWithZero
    {
        [DataTestMethod]
        #region Test Price In Words Russian - Russian Ruble - with zero
        [DataRow("0", "ноль рублей и ноль копеек")]
        [DataRow("0.01", "ноль рублей и одна копейка")]
        [DataRow("0.02", "ноль рублей и две копейки")]
        [DataRow("0.03", "ноль рублей и три копейки")]
        [DataRow("0.04", "ноль рублей и четыре копейки")]
        [DataRow("0.05", "ноль рублей и пять копеек")]
        [DataRow("0.07", "ноль рублей и семь копеек")]
        [DataRow("0.15", "ноль рублей и пятнадцать копеек")]
        [DataRow("0.31", "ноль рублей и тридцать одна копейка")]
        [DataRow("0.42", "ноль рублей и сорок две копейки")]
        [DataRow("1", "один рубль и ноль копеек")]        
        [DataRow("1.01", "один рубль и одна копейка")]
        [DataRow("1.10", "один рубль и десять копеек")]
        [DataRow("2.03", "два рубля и три копейки")]
        [DataRow("3.01", "три рубля и одна копейка")]        
        [DataRow("4.05", "четыре рубля и пять копеек")]
        [DataRow("5.05", "пять рублей и пять копеек")]
        [DataRow("10.01", "десять рублей и одна копейка")]        
        [DataRow("21.22", "двадцать один рубль и двадцать две копейки")]
        [DataRow("31", "тридцать один рубль и ноль копеек")]
        [DataRow("32.22", "тридцать два рубля и двадцать две копейки")]
        [DataRow("43", "сорок три рубля и ноль копеек")]
        [DataRow("467.63", "четыреста шестьдесят семь рублей и шестьдесят три копейки")]
        [DataRow("1 000", "одна тысяча рублей и ноль копеек")]
        [DataRow("2 758.6", "две тысячи семьсот пятьдесят восемь рублей и шестьдесят копеек")]
        [DataRow("10 121.01", "десять тысяч сто двадцать один рубль и одна копейка")]
        [DataRow("21 232.22", "двадцать одна тысяча двести тридцать два рубля и двадцать две копейки")]
        [DataRow("32 343.33", "тридцать две тысячи триста сорок три рубля и тридцать три копейки")]
        [DataRow("43 454.44", "сорок три тысячи четыреста пятьдесят четыре рубля и сорок четыре копейки")]
        [DataRow("50 567.50", "пятьдесят тысяч пятьсот шестьдесят семь рублей и пятьдесят копеек")]
        [DataRow("71 740.61", "семьдесят одна тысяча семьсот сорок рублей и шестьдесят одна копейка")]
        [DataRow("82 851", "восемьдесят две тысячи восемьсот пятьдесят один рубль и ноль копеек")]
        [DataRow("93 963", "девяносто три тысячи девятьсот шестьдесят три рубля и ноль копеек")]
        [DataRow("13 817.03", "тринадцать тысяч восемьсот семнадцать рублей и три копейки")]
        [DataRow("198 401.01", "сто девяносто восемь тысяч четыреста один рубль и одна копейка")]
        [DataRow("198 407.07", "сто девяносто восемь тысяч четыреста семь рублей и семь копеек")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.Russian, currency: Currency.RussianRuble, shouldConvertToWordsWhenZero: true);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }

    public class PriceToWordsConverterRussianRubleRussianWithoutZero
    {
        [DataTestMethod]
        #region Test Price In Words Russian - Russian Ruble - without zero
        [DataRow("0", "ноль рублей")]
        [DataRow("0.01", "одна копейка")]
        [DataRow("0.02", "две копейки")]
        [DataRow("0.03", "три копейки")]
        [DataRow("0.04", "четыре копейки")]
        [DataRow("0.05", "пять копеек")]
        [DataRow("0.07", "семь копеек")]
        [DataRow("0.15", "пятнадцать копеек")]
        [DataRow("0.31", "тридцать одна копейка")]
        [DataRow("0.42", "сорок две копейки")]
        [DataRow("1", "один рубль")]
        [DataRow("1.01", "один рубль и одна копейка")]
        [DataRow("1.10", "один рубль и десять копеек")]
        [DataRow("2.03", "два рубля и три копейки")]
        [DataRow("3.01", "три рубля и одна копейка")]
        [DataRow("4.05", "четыре рубля и пять копеек")]
        [DataRow("5.05", "пять рублей и пять копеек")]
        [DataRow("10.01", "десять рублей и одна копейка")]
        [DataRow("21.22", "двадцать один рубль и двадцать две копейки")]
        [DataRow("31", "тридцать один рубль")]
        [DataRow("32.22", "тридцать два рубля и двадцать две копейки")]
        [DataRow("43", "сорок три рубля")]
        [DataRow("467.63", "четыреста шестьдесят семь рублей и шестьдесят три копейки")]
        [DataRow("1 000", "одна тысяча рублей")]
        [DataRow("2 758.6", "две тысячи семьсот пятьдесят восемь рублей и шестьдесят копеек")]
        [DataRow("10 121.01", "десять тысяч сто двадцать один рубль и одна копейка")]
        [DataRow("21 232.22", "двадцать одна тысяча двести тридцать два рубля и двадцать две копейки")]
        [DataRow("32 343.33", "тридцать две тысячи триста сорок три рубля и тридцать три копейки")]
        [DataRow("43 454.44", "сорок три тысячи четыреста пятьдесят четыре рубля и сорок четыре копейки")]
        [DataRow("50 567.50", "пятьдесят тысяч пятьсот шестьдесят семь рублей и пятьдесят копеек")]
        [DataRow("71 740.61", "семьдесят одна тысяча семьсот сорок рублей и шестьдесят одна копейка")]
        [DataRow("82 851", "восемьдесят две тысячи восемьсот пятьдесят один рубль")]
        [DataRow("93 963", "девяносто три тысячи девятьсот шестьдесят три рубля")]
        [DataRow("13 817.03", "тринадцать тысяч восемьсот семнадцать рублей и три копейки")]
        [DataRow("198 401.07", "сто девяносто восемь тысяч четыреста один рубль и семь копеек")]
        [DataRow("198 402.07", "сто девяносто восемь тысяч четыреста два рубля и семь копеек")]
        [DataRow("198 403.07", "сто девяносто восемь тысяч четыреста три рубля и семь копеек")]
        [DataRow("198 407.07", "сто девяносто восемь тысяч четыреста семь рублей и семь копеек")]
        #endregion
        public void Test(string inputString, string expectedResult)
        {
            inputString = Regex.Replace(inputString, @"\s+", "");
            decimal inputPrice;
            decimal.TryParse(inputString, out inputPrice);
            var result = PriceToWordsConverter.ConvertPriceToWords(inputPrice: inputPrice, language: Language.Russian, currency: Currency.RussianRuble, shouldConvertToWordsWhenZero: false);
            Assert.AreEqual(expected: expectedResult, actual: result);
        }
    }
}