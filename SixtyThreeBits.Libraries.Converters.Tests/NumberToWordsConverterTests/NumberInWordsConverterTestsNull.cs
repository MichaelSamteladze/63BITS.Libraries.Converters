using SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries.Converters.Tests.NumberToWordsConverterTests
{
    [TestClass]
    public class NumberInWordsConverterTestsNull
    {
        [TestMethod]
        public void TestNullGeorgian()
        {
            var result = NumberToWordsConverter.ConvertNumberToWords(inputNumber: (string?)null, language: Language.Georgian);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestNullEnglish()
        {
            var result = NumberToWordsConverter.ConvertNumberToWords(inputNumber: (string?)null, language: Language.English);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestNullRussian()
        {
            var result = NumberToWordsConverter.ConvertNumberToWords(inputNumber: (string?)null, language: Language.Russian);
            Assert.IsNull(result);
        }
    }
}