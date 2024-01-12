using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using static SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries
{
    public class PriceToWordsConverter
    {
        #region Currencies
        const string _lariKa = "ლარი";
        const string _lariEng = "lari";
        const string _larisEng = "laris";
        const string _lariRus = "лари";
        const string _tetriKa = "თეთრი";
        const string _tetriEng = "tetri";
        const string _tetrisEng = "tetris";
        const string _tetriRus = "тетри";

        const string _usDollarKa = "აშშ დოლარი";        
        const string _usDollarEng = "us dollar";
        const string _usDollarsEng = "us dollars";
        const string _usDollarRus = "доллар сша";
        const string _usDollarRus_2_4 = "доллара сша";
        const string _usDollarsRus = "долларов сша";
        const string _centEng = "cent";
        const string _centsEng = "cents";
        const string _centKa = "ცენტი";
        const string _centRus = "цент";
        const string _centsRus_2_4 = "цента";
        const string _centsRus = "центов";

        const string _euroKa = "ევრო";
        const string _euroEng = "euro";
        const string _eurosEng = "euros";
        const string _euroRus = "эвро";
        const string _euroCentKa = "ევრო ცენტი";
        const string _euroCentEng = "euro cent";
        const string _euroCentsEng = "euro cents";
        const string _euroCentRus = "эвро цент";
        const string _euroCentsRus_2_4 = "эвро цента";
        const string _euroCentsRus = "эвро центов";

        const string _rubleKa = "რუბლი";
        const string _rubleEng = "ruble";
        const string _rublesEng = "rubles";
        const string _rubleRus = "рубль";
        const string _rubleRus_2_4 = "рубля";
        const string _rublesRus = "рублей";

        const string _kopekKa = "კაპიკი";
        const string _kopekEng = "kopek";
        const string _kopeksEng = "kopeks";
        const string _kopekRus = "копейка";
        const string _kopekRus_2_4 = "копейки";
        const string _kopeksRus = "копеек";
        #endregion

        #region Dictionaries
        static Dictionary<Language, string> dictionaryAnd => new Dictionary<Language, string>
        {
            {Language.Georgian, "და" },
            {Language.English, "and" },
            {Language.Russian, "и" }
        };
        #endregion

        #region Methods
        /// <summary>
        /// Convert price in words
        /// </summary>
        /// <param name="inputPrice">Price numeric value</param>
        /// <param name="language">Language to use</param>
        /// <param name="shouldConvertFractionalUnitsToWords">Weather fraction part should also be translated to words or not</param>
        /// <returns>Price in words</returns>
        public static string? ConvertPriceToWords(decimal? inputPrice, Language language, Currency currency, bool shouldConvertToWordsWhenZero)
        {
            if (inputPrice == null)
            {
                return null;
            }

            inputPrice = Math.Round(Math.Abs(inputPrice.Value), 2);

            var priceWhole = Convert.ToInt32(Math.Truncate(inputPrice.Value));
            var priceFraction = inputPrice - priceWhole;
            var priceFractionIntValue = Convert.ToInt32(priceFraction * 100);

            string translatedNumber;
            string priceString = Convert.ToString(inputPrice.Value, CultureInfo.InvariantCulture);
            string priceWholeString;
            string priceFractionString;
            int dotPosition;
            dotPosition = priceString.IndexOf('.');
            if (dotPosition > 0)
            {
                priceWholeString = priceString.Substring(0, dotPosition);
                priceFractionString = priceString.Substring(dotPosition + 1);
                priceFractionString = priceFractionString.Length < 2 ? priceFractionString + "0" : priceFractionString.Substring(0, 2);
            }
            else
            {
                priceWholeString = priceString;
                priceFractionString = "00";
            }


            var wholeNumberInWords = NumberToWordsConverter.ConvertNumberToWords(priceWholeString, language);
            var fractionalUnitsInWords = NumberToWordsConverter.ConvertNumberToWords(priceFractionString, language);

            var currencyWholeInWords = default(string);
            var currencyFractionInWords = default(string);

            switch (language)
            {
                case Language.Georgian:
                    {
                        switch (currency)
                        {
                            case Currency.Lari:
                                {
                                    currencyWholeInWords = _lariKa;
                                    currencyFractionInWords = _tetriKa;
                                    break;
                                }
                            case Currency.USDollar:
                                {
                                    currencyWholeInWords = _usDollarKa;
                                    currencyFractionInWords = _centKa;
                                    break;
                                }
                            case Currency.Euro:
                                {
                                    currencyWholeInWords = _euroKa;
                                    if(priceWhole == 0 && priceFractionIntValue > 0 && !shouldConvertToWordsWhenZero)
                                    {
                                        currencyFractionInWords = _euroCentKa;
                                    }
                                    else
                                    {
                                        currencyFractionInWords = _centKa;
                                    }
                                    
                                    break;
                                }
                            case Currency.RussianRuble:
                                {
                                    currencyWholeInWords = _rubleKa;
                                    currencyFractionInWords = _kopekKa;
                                    break;
                                }
                        }
                        
                        break;
                    }
                case Language.English:
                    {
                        switch (currency)
                        {
                            case Currency.Lari:
                                {
                                    currencyWholeInWords = priceWhole == 1 ? _lariEng : _larisEng;
                                    currencyFractionInWords = priceFractionIntValue == 1 ? _tetriEng : _tetrisEng;
                                    break;                                
                                }
                            case Currency.USDollar:
                                {
                                    currencyWholeInWords = priceWhole == 1 ? _usDollarEng : _usDollarsEng;
                                    currencyFractionInWords = priceFractionIntValue == 1 ? _centEng : _centsEng;                                    
                                    break;
                                }
                            case Currency.Euro:
                                {
                                    currencyWholeInWords = priceWhole == 1 ? _euroEng : _eurosEng;

                                    if (priceWhole == 0 && priceFractionIntValue > 0 && !shouldConvertToWordsWhenZero)
                                    {
                                        currencyFractionInWords = priceFractionIntValue == 1 ? _euroCentEng : _euroCentsEng;
                                    }
                                    else
                                    {
                                        currencyFractionInWords = priceFractionIntValue == 1 ? _centEng : _centsEng;
                                    }

                                    break;
                                }
                            case Currency.RussianRuble:
                                {
                                    currencyWholeInWords = priceWhole == 1 ? _rubleEng : _rublesEng;
                                    currencyFractionInWords = priceFractionIntValue == 1 ? _kopekEng : _kopeksEng;                                    
                                    break;
                                }
                        }

                        break;
                    }
                case Language.Russian:
                    {
                        var priceWholeLastDigit = priceWholeString[priceWholeString.Length - 1];
                        var priceFractionLastDigit = priceFractionString[priceFractionString.Length - 1];

                        var isRussisanGrammar_1_PriceWhole = priceWhole == 1 || (priceWhole > 20 && priceWholeLastDigit == '1');
                        var isRussisanGrammar_1_PriceFraction = priceFractionIntValue == 1 || (priceFractionIntValue > 20 && priceFractionLastDigit == '1');

                        var isRussisanGrammar_2_4_PriceWhole = new int[] { 2, 3, 4 }.Contains(priceWhole) || (priceWhole > 20 && new char[] { '2', '3', '4' }.Contains(priceWholeLastDigit));
                        var isRussisanGrammar_2_4_PriceFraction = new int[] { 2, 3, 4 }.Contains(priceFractionIntValue) || (priceFractionIntValue > 20 && new char[] { '2', '3', '4' }.Contains(priceFractionLastDigit));
                        switch (currency)
                        {
                            case Currency.Lari:
                                {                                    
                                    currencyWholeInWords = _lariRus;
                                    currencyFractionInWords = _tetriRus;                                    
                                    break;
                                }
                            case Currency.USDollar:
                                {
                                    if (isRussisanGrammar_1_PriceWhole)
                                    {
                                        currencyWholeInWords = _usDollarRus;
                                    }
                                    else if (isRussisanGrammar_2_4_PriceWhole)
                                    {
                                        currencyWholeInWords = _usDollarRus_2_4;
                                    }
                                    else
                                    {
                                        currencyWholeInWords = _usDollarsRus;
                                    }


                                    if (isRussisanGrammar_1_PriceFraction)
                                    {                                        
                                        currencyFractionInWords = _centRus;
                                    }
                                    else if (isRussisanGrammar_2_4_PriceFraction)
                                    {
                                        currencyFractionInWords = _centsRus_2_4;
                                    }
                                    else
                                    {
                                        currencyFractionInWords = _centsRus;
                                    }
                                    break;
                                }
                            case Currency.Euro:
                                {
                                    currencyWholeInWords = _euroRus;

                                    if (isRussisanGrammar_1_PriceFraction)
                                    {
                                        currencyFractionInWords = priceWhole == 0 && priceFractionIntValue > 0 && !shouldConvertToWordsWhenZero ? _euroCentRus : _centRus;
                                    }
                                    else if (isRussisanGrammar_2_4_PriceFraction)
                                    {
                                        currencyFractionInWords = priceWhole == 0 && priceFractionIntValue > 0 && !shouldConvertToWordsWhenZero ? _euroCentsRus_2_4 : _centsRus_2_4;
                                    }
                                    else
                                    {
                                        currencyFractionInWords = priceWhole == 0 && priceFractionIntValue > 0 && !shouldConvertToWordsWhenZero ? _euroCentsRus : _centsRus;
                                    }

                                    break;
                                }
                            case Currency.RussianRuble:
                                {
                                    if (isRussisanGrammar_1_PriceWhole)
                                    {
                                        currencyWholeInWords = _rubleRus;
                                    }
                                    else if (isRussisanGrammar_2_4_PriceWhole)
                                    {
                                        currencyWholeInWords = _rubleRus_2_4;
                                    }
                                    else
                                    {
                                        currencyWholeInWords = _rublesRus;
                                    }

                                    if (isRussisanGrammar_1_PriceFraction)
                                    {
                                        if (fractionalUnitsInWords is not null)
                                        {
                                            fractionalUnitsInWords = Regex.Replace(fractionalUnitsInWords, $"{NumberToWordsConverter._oneRus}$", NumberToWordsConverter._oneRusFemale);
                                        }
                                        currencyFractionInWords = _kopekRus;
                                    }
                                    else if (isRussisanGrammar_2_4_PriceFraction)
                                    {
                                        if (fractionalUnitsInWords is not null)
                                        {
                                            fractionalUnitsInWords = Regex.Replace(fractionalUnitsInWords, $"{NumberToWordsConverter._twoRus}$", NumberToWordsConverter._twoRusFemale);
                                        }
                                        currencyFractionInWords = _kopekRus_2_4;
                                    }
                                    else
                                    {                                        
                                        currencyFractionInWords = _kopeksRus;
                                    }

                                    break;
                                }
                        }

                        break;
                    }
            }

            var wordAndTranslated = dictionaryAnd[language];

            if(shouldConvertToWordsWhenZero || (priceWhole > 0 && priceFraction > 0))
            {
                translatedNumber = $"{wholeNumberInWords} {currencyWholeInWords} {wordAndTranslated} {fractionalUnitsInWords} {currencyFractionInWords}";
            }
            else
            {
                if(priceWhole > 0)
                {
                    translatedNumber = $"{wholeNumberInWords} {currencyWholeInWords}";
                }
                else if(priceFraction> 0)
                {
                    translatedNumber = $"{fractionalUnitsInWords} {currencyFractionInWords}";
                }
                else
                {
                    translatedNumber = $"{wholeNumberInWords} {currencyWholeInWords}";
                }
            }

            return translatedNumber;
        }        
        #endregion        
    }  

    public static class PriceToWordsConverterExtensions
    {
        /// <summary>
        /// Convert price in words
        /// </summary>
        /// <param name="price">Price numeric value</param>
        /// <param name="language">Language to use</param>
        /// <param name="shouldConvertFractionalUnitsToWords">Weather fraction part should also be translated to words or not</param>
        /// <returns>Price in words</returns>
        public static string? ConvertPriceToWords(this decimal? price, Language language, Currency currency, bool shouldConvertFractionalUnitsToWords = true)
        {
            return NumberToWordsConverter.ConvertPriceToWords(price, language, currency, shouldConvertFractionalUnitsToWords);
        }
    }
}