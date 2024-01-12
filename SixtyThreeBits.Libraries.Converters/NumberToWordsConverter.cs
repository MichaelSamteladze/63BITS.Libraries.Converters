using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using static SixtyThreeBits.Libraries.Converters.Enums;

namespace SixtyThreeBits.Libraries
{
    public class NumberToWordsConverter
    {
        #region Georgian Numbers In Words        
        const string _zeroKa = "ნული";
        const string _oneKa = "ერთი";
        const string _twoKa = "ორი";
        const string _threeKa = "სამი";
        const string _fourKa = "ოთხი";
        const string _fiveKa = "ხუთი";
        const string _sixKa = "ექვსი";
        const string _sevenKa = "შვიდი";
        const string _eightKa = "რვა";
        const string _nineKa = "ცხრა";
        const string _tenKa = "ათი";
        const string _elevenKa = "თერთმეტი";
        const string _twelveKa = "თორმეტი";
        const string _thirteenKa = "ცამეტი";
        const string _fourteenKa = "თოთხმეტი";
        const string _fifteenKa = "თხუთმეტი";
        const string _sixteenKa = "თექვსმეტი";
        const string _seventeenKa = "ჩვიდმეტი";
        const string _eighteenKa = "თვრამეტი";
        const string _nineteenKa = "ცხრამეტი";
        const string _twentyKa = "ოცი";
        const string _fortyKa = "ორმოცი";
        const string _sixtyKa = "სამოცი";
        const string _eightyKa = "ოთხმოცი";
        const string _hundredKa = "ასი";
        const string _twoHundredKa = "ორასი";
        const string _threeHundredKa = "სამასი";
        const string _fourHundredKa = "ოთხასი";
        const string _fiveHundredKa = "ხუთასი";
        const string _sixHundredKa = "ექვსასი";
        const string _sevenHundredKa = "შვიდასი";
        const string _eightHundredKa = "რვაასი";
        const string _nineHundredKa = "ცხრაასი";        
        const string _thousandKa = " ათასი";
        const string _millionKa = " მილიონი";
        const string _billionKa = " მილიარდი";
        const string _trillionKa = " ტრილიონი";
        const string _quadrillionKa = " კვადრილიონი";              
        #endregion

        #region English Numbers In Words
        const string _zeroEng = "zero";
        const string _oneEng = "one";
        const string _twoEng = "two";
        const string _threeEng = "three";
        const string _fourEng = "four";
        const string _fiveEng = "five";
        const string _sixEng = "six";
        const string _sevenEng = "seven";
        const string _eightEng = "eight";
        const string _nineEng = "nine";
        const string _tenEng = "ten";
        const string _elevenEng = "eleven";
        const string _twelveEng = "twelve";
        const string _thirteenEng = "thirteen";
        const string _fourteenEng = "fourteen";
        const string _fifteenEng = "fifteen";
        const string _sixteenEng = "sixteen";
        const string _seventeenEng = "seventeen";
        const string _eighteenEng = "eighteen";
        const string _nineteenEng = "nineteen";
        const string _twentyEng = "twenty";
        const string _thirtyEng = "thirty";
        const string _fortyEng = "forty";
        const string _fiftyEng = "fifty";
        const string _sixtyEng = "sixty";
        const string _seventyEng = "seventy";
        const string _eightyEng = "eighty";
        const string _ninetyEng = "ninety";
        const string _hundredEng = " hundred";
        const string _thousandEng = " thousand";
        const string _millionEng = " million";
        const string _billionEng = " billion";
        const string _trillionEng = " trillion";
        const string _quadrillionEng = " quadrillion";
        #endregion

        #region Russian Numbers In Words        
        const string _zeroRus = "ноль";
        public const string _oneRus = "один";
        public const string _oneRusFemale = "одна";        
        public const string _twoRus = "два";
        public const string _twoRusFemale = "две";
        const string _threeRus = "три";
        const string _fourRus = "четыре";
        const string _fiveRus = "пять";
        const string _sixRus = "шесть";
        const string _sevenRus = "семь";
        const string _eightRus = "восемь";
        const string _nineRus = "девять";
        const string _tenRus = "десять";
        const string _elevenRus = "одиннадцать";
        const string _twelveRus = "двенадцать";
        const string _thirteenRus = "тринадцать";
        const string _fourteenRus = "четырнадцать";
        const string _fifteenRus = "пятнадцать";
        const string _sixteenRus = "шестнадцать";
        const string _seventeenRus = "семнадцать";
        const string _eighteenRus = "восемнадцать";
        const string _nineteenRus = "девятнадцать";
        const string _twentyRus = "двадцать";
        const string _thirtyRus = "тридцать";
        const string _fortyRus = "сорок";
        const string _fiftyRus = "пятьдесят";
        const string _sixtyRus = "шестьдесят";
        const string _seventyRus = "семьдесят";
        const string _eightyRus = "восемьдесят";
        const string _ninetyRus = "девяносто";
        const string _hundredRus = "сто";
        const string _twoHundredRus = "двести";
        const string _threeHundredRus = "триста";
        const string _fourHundredRus = "четыреста";
        const string _fiveHhundredRus = "пятьсот";
        const string _sixHundredRus = "шестьсот";
        const string _sevenHundredRus = "семьсот";
        const string _eightHundredRus = "восемьсот";
        const string _nineHundredRus = "девятьсот";

        const string _thousandRus = " тысяча";
        const string _thousandRus2_4 = " тысячи";
        const string _thousandsRus = " тысяч";

        const string _millionRus = " миллион";
        const string _millionRus2_4 = " миллиона";
        const string _millionsRus = " миллионов";

        const string _billionRus = " миллиард";
        const string _billionRus2_4 = " миллиарда";
        const string _billionsRus = " миллиардов";

        const string _trillionRus = " триллион";
        const string _trillionRus2_4 = " триллиона";
        const string _trillionsRus = " триллионов";

        const string _quadrillionRus = " квартальен";
        const string _quadrillionRus2_4 = " квартальена";
        const string _quadrillionsRus = " квартальенов";
        #endregion

        #region Currencies
        const string _lariKa = "ლარი";
        const string _lariEng = "lari";
        const string _larisEng = "lari";
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
        static Dictionary<Language, string> dictionaryMinus => new Dictionary<Language, string>
        {
            {Language.Georgian, "მინუს" },
            {Language.English, "minus" },
            {Language.Russian, "минус" }
        };        
        #endregion

        #region Methods
        /// <summary>
        /// Converts number to words
        /// </summary>
        /// <param name="inputNumber">Number up to length 18</param>
        /// <param name="language">Georgian, English or Russian</param>
        /// <returns>Number as words</returns>
        public static string? ConvertNumberToWords(int? inputNumber, Language language)
        {
            var inputString = inputNumber.ToString();
            return ConvertNumberToWords(inputString, language);
        }

        /// <summary>
        /// Converts number to words
        /// </summary>
        /// <param name="inputString">Numeric string up to length 18</param>
        /// <param name="language">Georgian, English or Russian</param>
        /// <returns>Number as words</returns>
        public static string? ConvertNumberToWords(string? inputString, Language language)
        {
            bool isNegative = false;
            string? textMinus = default;

            if (inputString == null)
            {
                return null;
            }

            long valueValidator;
            if(!long.TryParse(inputString, out valueValidator))
            {
                return null;
            }

            if (inputString.StartsWith('-'))
            {
                isNegative = true;
                textMinus = dictionaryMinus[language];
                inputString = inputString.Remove(0, 1);
            }

            if (inputString.Length > 18)
            {
                throw new Exception("Numeric overflow - only up to 18 length numbers are allowed");
            }

            var translated = new StringBuilder();
            char[] backwardPosition = inputString.ToCharArray();
            char[] forwardPosition = new char[18];
            for (int i = 0; i < forwardPosition.Length; i++)
            {
                forwardPosition[i] = '0';
            }

            bool isZero = true;
            int j = 0;
            for (int i = backwardPosition.Length - 1; i >= 0; i--)
            {
                forwardPosition[j] = backwardPosition[i];
                j += 1;
                if (backwardPosition[i] != '0')
                {
                    isZero = false;
                }
            }

            if (isZero)
            {
                switch (language)
                {
                    case Language.Georgian:
                        translated.Append(_zeroKa);
                        break;
                    case Language.English:
                        translated.Append(_zeroEng);
                        break;
                    case Language.Russian:
                        translated.Append(_zeroRus);
                        break;
                    default:
                        break;
                }                
            }
            else
            {
                byte firstLow, firstHigh, secondLow, secondHigh, thirdLow, thirdHigh, fourthLow, fourthHigh, fifthLow, fifthHigh, sixthLow, sixthHigh;
                string firstLowStr, firstHighStr, secondLowStr, secondHighStr, thirdLowStr, thirdHighStr, fourthLowStr, fourthHighStr, fifthLowStr, fifthHighStr, sixthLowStr, sixthHighStr;

                firstLow = Convert.ToByte(Convert.ToString(forwardPosition[1]) + Convert.ToString(forwardPosition[0]));
                firstHigh = Convert.ToByte(Convert.ToString(forwardPosition[2]));
                secondLow = Convert.ToByte(Convert.ToString(forwardPosition[4]) + Convert.ToString(forwardPosition[3]));
                secondHigh = Convert.ToByte(Convert.ToString(forwardPosition[5]));
                thirdLow = Convert.ToByte(Convert.ToString(forwardPosition[7]) + Convert.ToString(forwardPosition[6]));
                thirdHigh = Convert.ToByte(Convert.ToString(forwardPosition[8]));
                fourthLow = Convert.ToByte(Convert.ToString(forwardPosition[10]) + Convert.ToString(forwardPosition[9]));
                fourthHigh = Convert.ToByte(Convert.ToString(forwardPosition[11]));
                fifthLow = Convert.ToByte(Convert.ToString(forwardPosition[13]) + Convert.ToString(forwardPosition[12]));
                fifthHigh = Convert.ToByte(Convert.ToString(forwardPosition[14]));
                sixthLow = Convert.ToByte(Convert.ToString(forwardPosition[16]) + Convert.ToString(forwardPosition[15]));
                sixthHigh = Convert.ToByte(Convert.ToString(forwardPosition[17]));

                switch (language)
                {
                    case Language.Georgian:
                        _xLowHigh(sixthLow, sixthHigh, language, out sixthLowStr, out sixthHighStr);
                        _xLowHigh(fifthLow, fifthHigh, language, out fifthLowStr, out fifthHighStr);
                        _xLowHigh(fourthLow, fourthHigh, language, out fourthLowStr, out fourthHighStr);
                        _xLowHigh(thirdLow, thirdHigh, language, out thirdLowStr, out thirdHighStr);
                        _xLowHigh(secondLow, secondHigh, language, out secondLowStr, out secondHighStr);
                        _xLowHigh(firstLow, firstHigh, language, out firstLowStr, out firstHighStr);

                        translated.Append(sixthHighStr + sixthLowStr);
                        if (sixthLowStr.Length > 0 | sixthHighStr.Length > 0)
                        {
                            if (fifthLowStr.Length > 0 | fifthHighStr.Length > 0 |
                           fourthLowStr.Length > 0 | fourthHighStr.Length > 0 |
                           thirdLowStr.Length > 0 | thirdHighStr.Length > 0 |
                           secondLowStr.Length > 0 | secondHighStr.Length > 0 |
                           firstLowStr.Length > 0 | firstHighStr.Length > 0)
                            {
                                translated.Append(_quadrillionKa.Substring(0, _quadrillionKa.Length - 1)).Append(" ");
                            }
                            else
                            {
                                translated.Append(_quadrillionKa);
                            }
                        }

                        translated.Append(fifthHighStr + fifthLowStr);
                        if (fifthLowStr.Length > 0 | fifthHighStr.Length > 0)
                        {
                            if (fourthLowStr.Length > 0 | fourthHighStr.Length > 0 |
                           thirdLowStr.Length > 0 | thirdHighStr.Length > 0 |
                           secondLowStr.Length > 0 | secondHighStr.Length > 0 |
                           firstLowStr.Length > 0 | firstHighStr.Length > 0)
                            {
                                translated.Append(_trillionKa.Substring(0, _trillionKa.Length - 1)).Append(" ");
                            }
                            else
                            {
                                translated.Append(_trillionKa);
                            }
                        }

                        translated.Append(fourthHighStr + fourthLowStr);
                        if (fourthLowStr.Length > 0 | fourthHighStr.Length > 0)
                        {
                            if (thirdLowStr.Length > 0 | thirdHighStr.Length > 0 |
                           secondLowStr.Length > 0 | secondHighStr.Length > 0 |
                           firstLowStr.Length > 0 | firstHighStr.Length > 0)
                            {
                                translated.Append(_billionKa.Substring(0, _billionKa.Length - 1)).Append(" ");
                            }
                            else
                            {
                                translated.Append(_billionKa);
                            }
                        }

                        translated.Append(thirdHighStr + thirdLowStr);
                        if (thirdLowStr.Length > 0 | thirdHighStr.Length > 0)
                        {
                            if (secondLowStr.Length > 0 | secondHighStr.Length > 0 |
                           firstLowStr.Length > 0 | firstHighStr.Length > 0)
                            {
                                translated.Append(_millionKa.Substring(0, _millionKa.Length - 1)).Append(" ");
                            }
                            else
                            {
                                translated.Append(_millionKa);
                            }
                        }

                        translated.Append(secondHighStr + secondLowStr);
                        if (secondLowStr.Length > 0 | secondHighStr.Length > 0)
                        {
                            if (firstLowStr.Length > 0 | firstHighStr.Length > 0)
                            {
                                translated.Append(_thousandKa.Substring(0, _thousandKa.Length - 1)).Append(" ");
                            }
                            else
                            {
                                translated.Append(_thousandKa);
                            }
                        }
                        translated.Append(firstHighStr + firstLowStr);
                        break;
                    case Language.English:
                        _xLowHigh(sixthLow, sixthHigh, language, out sixthLowStr, out sixthHighStr);
                        _xLowHigh(fifthLow, fifthHigh, language, out fifthLowStr, out fifthHighStr);
                        _xLowHigh(fourthLow, fourthHigh, language, out fourthLowStr, out fourthHighStr);
                        _xLowHigh(thirdLow, thirdHigh, language, out thirdLowStr, out thirdHighStr);
                        _xLowHigh(secondLow, secondHigh, language, out secondLowStr, out secondHighStr);
                        _xLowHigh(firstLow, firstHigh, language, out firstLowStr, out firstHighStr);

                        translated.Append(sixthHighStr + sixthLowStr);
                        if (sixthLowStr.Length > 0 | sixthHighStr.Length > 0)
                        {
                            if (fifthLowStr.Length > 0 | fifthHighStr.Length > 0 |
                           fourthLowStr.Length > 0 | fourthHighStr.Length > 0 |
                           thirdLowStr.Length > 0 | thirdHighStr.Length > 0 |
                           secondLowStr.Length > 0 | secondHighStr.Length > 0 |
                           firstLowStr.Length > 0 | firstHighStr.Length > 0)
                            {
                                translated.Append(_quadrillionEng + " ");
                            }
                            else
                            {
                                translated.Append(_quadrillionEng);
                            }
                        }

                        translated.Append(fifthHighStr + fifthLowStr);
                        if (fifthLowStr.Length > 0 | fifthHighStr.Length > 0)
                        {
                            if (fourthLowStr.Length > 0 | fourthHighStr.Length > 0 |
                           thirdLowStr.Length > 0 | thirdHighStr.Length > 0 |
                           secondLowStr.Length > 0 | secondHighStr.Length > 0 |
                           firstLowStr.Length > 0 | firstHighStr.Length > 0)
                            {
                                translated.Append(_trillionEng + " ");
                            }
                            else
                            {
                                translated.Append(_trillionEng);
                            }
                        }

                        translated.Append(fourthHighStr + fourthLowStr);
                        if (fourthLowStr.Length > 0 | fourthHighStr.Length > 0)
                        {
                            if (thirdLowStr.Length > 0 | thirdHighStr.Length > 0 |
                           secondLowStr.Length > 0 | secondHighStr.Length > 0 |
                           firstLowStr.Length > 0 | firstHighStr.Length > 0)
                            {
                                translated.Append(_billionEng + " ");
                            }
                            else
                            {
                                translated.Append(_billionEng);
                            }
                        }

                        translated.Append(thirdHighStr + thirdLowStr);
                        if (thirdLowStr.Length > 0 | thirdHighStr.Length > 0)
                        {
                            if (secondLowStr.Length > 0 | secondHighStr.Length > 0 |
                           firstLowStr.Length > 0 | firstHighStr.Length > 0)
                            {
                                translated.Append(_millionEng + " ");
                            }
                            else
                            {
                                translated.Append(_millionEng);
                            }
                        }

                        translated.Append(secondHighStr + secondLowStr);
                        if (secondLowStr.Length > 0 | secondHighStr.Length > 0)
                        {
                            if (firstLowStr.Length > 0 | firstHighStr.Length > 0)
                            {
                                translated.Append(_thousandEng + " ");
                            }
                            else
                            {
                                translated.Append(_thousandEng);
                            }
                        }
                        translated.Append(firstHighStr + firstLowStr);

                        break;
                    case Language.Russian:
                        _xLowHigh(sixthLow, sixthHigh, language, out sixthLowStr, out sixthHighStr);
                        _xLowHigh(fifthLow, fifthHigh, language, out fifthLowStr, out fifthHighStr);
                        _xLowHigh(fourthLow, fourthHigh, language, out fourthLowStr, out fourthHighStr);
                        _xLowHigh(thirdLow, thirdHigh, language, out thirdLowStr, out thirdHighStr);
                        _xLowHigh(secondLow, secondHigh, language, out secondLowStr, out secondHighStr);
                        _xLowHigh(firstLow, firstHigh, language, out firstLowStr, out firstHighStr);

                        //quadrillion
                        translated.Append(sixthHighStr + sixthLowStr);
                        if (sixthLowStr.Length > 0 | sixthHighStr.Length > 0)
                        {
                            var translatedString = translated.ToString();
                            if (translatedString.EndsWith(_oneRus))
                            {
                                translated.Append(_quadrillionRus);
                            }
                            else if (translatedString.EndsWith(_twoRus) || translatedString.EndsWith(_threeRus) || translatedString.EndsWith(_fourRus))
                            {
                                translated.Append(_quadrillionRus2_4);
                            }
                            else
                            {
                                translated.Append(_quadrillionsRus);
                            }
                            if (fifthLowStr.Length > 0 | fifthHighStr.Length > 0 |
                           fourthLowStr.Length > 0 | fourthHighStr.Length > 0 |
                           thirdLowStr.Length > 0 | thirdHighStr.Length > 0 |
                           secondLowStr.Length > 0 | secondHighStr.Length > 0 |
                           firstLowStr.Length > 0 | firstHighStr.Length > 0)
                            {
                                translated.Append(" ");
                            }
                        }

                        //trillion
                        translated.Append(fifthHighStr + fifthLowStr);
                        if (fifthLowStr.Length > 0 | fifthHighStr.Length > 0)
                        {
                            var translatedString = translated.ToString();
                            if (translatedString.EndsWith(_oneRus))
                            {
                                translated.Append(_trillionRus);
                            }
                            else if (translatedString.EndsWith(_twoRus) || translatedString.EndsWith(_threeRus) || translatedString.EndsWith(_fourRus))
                            {
                                translated.Append(_trillionRus2_4);
                            }
                            else
                            {
                                translated.Append(_trillionsRus);
                            }
                            if (fourthLowStr.Length > 0 | fourthHighStr.Length > 0 |
                           thirdLowStr.Length > 0 | thirdHighStr.Length > 0 |
                           secondLowStr.Length > 0 | secondHighStr.Length > 0 |
                           firstLowStr.Length > 0 | firstHighStr.Length > 0)
                            {
                                translated.Append(" ");
                            }
                        }

                        //billion
                        translated.Append(fourthHighStr + fourthLowStr);
                        if (fourthLowStr.Length > 0 | fourthHighStr.Length > 0)
                        {                            
                            var translatedString = translated.ToString();
                            if (translatedString.EndsWith(_oneRus))
                            {
                                translated.Append(_billionRus);
                            }
                            else if (translatedString.EndsWith(_twoRus) || translatedString.EndsWith(_threeRus) || translatedString.EndsWith(_fourRus))
                            {
                                translated.Append(_billionRus2_4);
                            }
                            else
                            {
                                translated.Append(_billionsRus);
                            }
                            if (thirdLowStr.Length > 0 | thirdHighStr.Length > 0 |
                           secondLowStr.Length > 0 | secondHighStr.Length > 0 |
                           firstLowStr.Length > 0 | firstHighStr.Length > 0)
                            {
                                translated.Append(" ");
                            }
                        }

                        //million
                        translated.Append(thirdHighStr + thirdLowStr);
                        if (thirdLowStr.Length > 0 | thirdHighStr.Length > 0)
                        {
                            var translatedString = translated.ToString();
                            if (translatedString.EndsWith(_oneRus))
                            {
                                translated.Append(_millionRus);
                            }
                            else if (translatedString.EndsWith(_twoRus) || translatedString.EndsWith(_threeRus) || translatedString.EndsWith(_fourRus))
                            {
                                translated.Append(_millionRus2_4);
                            }
                            else
                            {
                                translated.Append(_millionsRus);
                            }
                            if (secondLowStr.Length > 0 | secondHighStr.Length > 0 |
                           firstLowStr.Length > 0 | firstHighStr.Length > 0)
                            {
                                translated.Append(" ");
                            }
                        }

                        //thousand
                        translated.Append(secondHighStr + secondLowStr);
                        if (secondLowStr.Length > 0 | secondHighStr.Length > 0)
                        {
                            var translatedString = translated.ToString();
                            if (translated.Length >= 4 && translatedString.Substring(translatedString.Length - 4, 4) == _oneRus)
                            {
                                translated.Clear();
                                translated.Append(translatedString.Substring(0, translatedString.Length - 4) + _oneRusFemale);
                            }

                            if (translated.Length >= 3 && translatedString.Substring(translatedString.Length - 3, 3) == _twoRus)
                            {
                                translated.Clear();
                                translated.Append(translatedString.Substring(0, translatedString.Length - 3) + _twoRusFemale);
                            }

                            translatedString = translated.ToString();
                            if (translatedString.EndsWith(_oneRusFemale))
                            {
                                translated.Append(_thousandRus);
                            }                            
                            else if (translatedString.EndsWith(_twoRusFemale) || translatedString.EndsWith(_threeRus) || translatedString.EndsWith(_fourRus))
                            {
                                translated.Append(_thousandRus2_4);
                            }
                            else
                            {
                                translated.Append(_thousandsRus);
                            }

                            if (firstLowStr.Length > 0 | firstHighStr.Length > 0)
                            {
                                translated.Append(" ");
                            }
                        }
                        translated.Append(firstHighStr + firstLowStr);
                        break;
                    default:
                        break;
                }
            }
            var result = isNegative ? $"{textMinus} {translated}" : translated.ToString();
            return result;
        }

        /// <summary>
        /// Convert price in words
        /// </summary>
        /// <param name="price">Price numeric value</param>
        /// <param name="language">Language to use</param>
        /// <param name="shouldConvertFractionalUnits">Weather fraction part should also be translated to words or not</param>
        /// <returns>Price in words</returns>
        public static string? ConvertPriceToWords(decimal? price, Language language, Currency currency, bool shouldConvertFractionalUnits = false)
        {
            if (price == null)
            {
                return null;
            }

            price = Math.Round(Math.Abs(price.Value), 2);

            var priceWhole = Convert.ToInt32(Math.Truncate(price.Value));
            var priceFraction = price - priceWhole;
            var priceFractionIntValue = Convert.ToInt32(priceFraction * 100);

            string translatedNumber = "";
            string priceString = Convert.ToString(price.Value, CultureInfo.InvariantCulture);
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


            var wholeNumberInWords = ConvertNumberToWords(priceWholeString, language);
            var fractionalUnitsInWords = shouldConvertFractionalUnits ? ConvertNumberToWords(priceFractionString, language) : priceFractionString;

            switch (language)
            {
                case Language.Georgian:
                    {
                        switch(currency)
                        {
                            case Currency.Lari:
                                {
                                    translatedNumber = $"{wholeNumberInWords} {_lariKa} და {fractionalUnitsInWords} {_tetriKa}";                                    
                                    break;
                                }
                            case Currency.USDollar:
                                {
                                    translatedNumber = $"{wholeNumberInWords} {_usDollarKa} და {fractionalUnitsInWords} {_centKa}";
                                    break;
                                }
                            case Currency.Euro:
                                {
                                    translatedNumber = $"{wholeNumberInWords} {_euroKa} და {fractionalUnitsInWords} {_centKa}";
                                    break;
                                }
                            case Currency.RussianRuble:
                                {
                                    translatedNumber = $"{wholeNumberInWords} {_rubleKa} და {fractionalUnitsInWords} {_kopekKa}";
                                    break;
                                }
                        }
                        
                        break;
                    }
                case Language.English:
                    {
                        var currencyWholeInWords = default(string);
                        var currencyFractionInWords = default(string);

                        switch (currency)
                        {
                            case Currency.Lari:
                                {
                                    currencyWholeInWords = priceWhole == 1 ? _lariEng : _larisEng;
                                    currencyFractionInWords = priceFraction == 1 ? _tetriEng : _tetrisEng;
                                    break;                                
                                }
                            case Currency.USDollar:
                                {
                                    currencyWholeInWords = priceWhole == 1 ? _usDollarEng : _usDollarsEng;
                                    currencyFractionInWords = priceFraction == 1 ? _centEng : _centsEng;                                    
                                    break;
                                }
                            case Currency.Euro:
                                {
                                    currencyWholeInWords = priceWhole == 1 ? _euroEng : _eurosEng;
                                    currencyFractionInWords = priceFraction == 1 ? _centEng : _centsEng;                                    
                                    break;
                                }
                            case Currency.RussianRuble:
                                {
                                    currencyWholeInWords = priceWhole == 1 ? _rubleEng : _rublesEng;
                                    currencyFractionInWords = priceFraction == 1 ? _centEng : _centsEng;                                    
                                    break;
                                }
                        }

                        translatedNumber = $"{wholeNumberInWords} {currencyWholeInWords} and {fractionalUnitsInWords} {currencyFractionInWords}";

                        break;
                    }
                case Language.Russian:
                    {
                        var currencyWholeInWords = default(string);
                        var currencyFractionInWords = default(string);
                        var priceWholeLastDigit = priceWholeString[priceWholeString.Length - 1];
                        var priceWholePreLastDigit = priceWholeString.Length - 2 > 0 ? priceWholeString[priceWholeString.Length - 2] : ' ';
                        var priceFractionLastDigit = priceFractionString[priceFractionString.Length - 1];
                        var priceFractionPreLastDigit = priceFractionString.Length - 2 > 0 ? priceFractionString[priceFractionString.Length - 2] : ' ';

                        var isRussisanGrammar_1_PriceWhole =
                        priceWhole == 1
                        ||
                        (
                            new char[] { '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(priceWholePreLastDigit)
                            &&
                            new char[] { '1' }.Contains(priceWholeLastDigit)
                        );
                        var isRussisanGrammar_1_PriceFraction =
                        priceFractionIntValue == 1
                        ||
                        (
                            new char[] { '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(priceFractionPreLastDigit)
                            &&
                            new char[] { '1' }.Contains(priceFractionLastDigit)
                        );


                        var isRussisanGrammar_2_4_PriceWhole = 
                        new int[] {2,3,4}.Contains(priceWhole)
                        ||
                        (
                            new char[] { '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(priceWholePreLastDigit)
                            &&
                            new char[] { '2', '3', '4' }.Contains(priceWholeLastDigit)
                        );
                        var isRussisanGrammar_2_4_PriceFraction =
                        new int[] { 2, 3, 4 }.Contains(priceFractionIntValue)
                        ||
                        (
                            new char[] { '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(priceFractionPreLastDigit)
                            &&
                            new char[] { '2', '3', '4' }.Contains(priceFractionLastDigit)
                        );

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
                                    if (isRussisanGrammar_1_PriceFraction)
                                    {
                                        currencyWholeInWords = _usDollarRus;
                                        currencyFractionInWords = _centRus;
                                    }
                                    else if (isRussisanGrammar_2_4_PriceWhole)
                                    {
                                        currencyWholeInWords = _usDollarRus_2_4;
                                        currencyFractionInWords = _centsRus_2_4;
                                    }
                                    else
                                    {
                                        currencyWholeInWords = _usDollarsRus;
                                        currencyFractionInWords = _centsRus;
                                    }
                                    break;
                                }
                            case Currency.Euro:
                                {
                                    if (isRussisanGrammar_1_PriceFraction)
                                    {
                                        currencyWholeInWords = _euroRus;
                                        currencyFractionInWords = _centRus;
                                    }
                                    else if (isRussisanGrammar_2_4_PriceWhole)
                                    {
                                        currencyWholeInWords = _euroRus;
                                        currencyFractionInWords = _centsRus_2_4;
                                    }
                                    else
                                    {
                                        currencyWholeInWords = _euroRus;
                                        currencyFractionInWords = _centsRus;
                                    }
                                    break;
                                }
                            case Currency.RussianRuble:
                                {
                                    if (isRussisanGrammar_1_PriceFraction)
                                    {
                                        currencyWholeInWords = _rubleRus;
                                        currencyFractionInWords = _kopekRus;
                                    }
                                    else if (isRussisanGrammar_2_4_PriceWhole)
                                    {
                                        currencyWholeInWords = _rubleRus_2_4;
                                        currencyFractionInWords = _kopekRus_2_4;
                                    }
                                    else
                                    {
                                        currencyWholeInWords = _rublesRus;
                                        currencyFractionInWords = _kopeksRus;
                                    }
                                    break;
                                }
                        }

                        translatedNumber = $"{wholeNumberInWords} {currencyWholeInWords} и {fractionalUnitsInWords} {currencyFractionInWords}";
                      
                        break;
                    }
            }
            return translatedNumber;
        }

        /// <summary>
        /// Returns verbal triad from the provided numeric value and language
        /// </summary>
        /// <param name="xLow">Provided number from 0 to 99: ones and tens</param>
        /// <param name="xHigh">provided number from 0 to 9: hundreds</param>
        /// <param name="language">Language option</param>
        /// <param name="xLowStr">0 to 99 word part of the number</param>
        /// <param name="xHighStr">100 to 900 word part of the number</param>
        static void _xLowHigh(byte xLow, byte xHigh, Language language, out string xLowStr, out string xHighStr)
        {
            xLowStr = "";
            xHighStr = "";

            switch (language)
            {
                case Language.Georgian:
                    if (xHigh > 0)
                    {
                        switch (xHigh)
                        {
                            case 1:
                                xHighStr = _hundredKa;
                                break;
                            case 2:
                                xHighStr = _twoHundredKa;
                                break;
                            case 3:
                                xHighStr = _threeHundredKa;
                                break;
                            case 4:
                                xHighStr = _fourHundredKa;
                                break;
                            case 5:
                                xHighStr = _fiveHundredKa;
                                break;
                            case 6:
                                xHighStr = _sixHundredKa;
                                break;
                            case 7:
                                xHighStr = _sevenHundredKa;
                                break;
                            case 8:
                                xHighStr = _eightHundredKa;
                                break;
                            case 9:
                                xHighStr = _nineHundredKa;
                                break;
                            default:
                                break;
                        }
                        xHighStr = xHighStr.Substring(0, xHighStr.Length - (xLow > 0 ? 1 : 0)) + (xLow > 0 ? " " : "");
                    }
                    else
                    {
                        xHighStr = "";
                    }
                    if (xLow > 0)
                    {
                        if (xLow == 20)
                        {
                            xLowStr = _twentyKa;
                        }
                        else if (xLow == 40)
                        {
                            xLowStr = _fortyKa;
                        }
                        else if (xLow == 60)
                        {
                            xLowStr = _sixtyKa;
                        }
                        else if (xLow == 80)
                        {
                            xLowStr = _eightyKa;
                        }
                        else
                        {
                            int tmpLow;
                            Math.DivRem(xLow, 20, out tmpLow);
                            switch (tmpLow)
                            {
                                case 1:
                                    xLowStr = _oneKa;
                                    break;
                                case 2:
                                    xLowStr = _twoKa;
                                    break;
                                case 3:
                                    xLowStr = _threeKa;
                                    break;
                                case 4:
                                    xLowStr = _fourKa;
                                    break;
                                case 5:
                                    xLowStr = _fiveKa;
                                    break;
                                case 6:
                                    xLowStr = _sixKa;
                                    break;
                                case 7:
                                    xLowStr = _sevenKa;
                                    break;
                                case 8:
                                    xLowStr = _eightKa;
                                    break;
                                case 9:
                                    xLowStr = _nineKa;
                                    break;
                                case 10:
                                    xLowStr = _tenKa;
                                    break;
                                case 11:
                                    xLowStr = _elevenKa;
                                    break;
                                case 12:
                                    xLowStr = _twelveKa;
                                    break;
                                case 13:
                                    xLowStr = _thirteenKa;
                                    break;
                                case 14:
                                    xLowStr = _fourteenKa;
                                    break;
                                case 15:
                                    xLowStr = _fifteenKa;
                                    break;
                                case 16:
                                    xLowStr = _sixteenKa;
                                    break;
                                case 17:
                                    xLowStr = _seventeenKa;
                                    break;
                                case 18:
                                    xLowStr = _eighteenKa;
                                    break;
                                case 19:
                                    xLowStr = _nineteenKa;
                                    break;
                                default:
                                    break;
                            }
                            if (xLow > 20 & xLow < 40)
                            {
                                xLowStr = _twentyKa.Substring(0, _twentyKa.Length - 1) + "და" + xLowStr;
                            }
                            else if (xLow > 40 & xLow < 60)
                            {
                                xLowStr = _fortyKa.Substring(0, _fortyKa.Length - 1) + "და" + xLowStr;
                            }
                            else if (xLow > 60 & xLow < 80)
                            {
                                xLowStr = _sixtyKa.Substring(0, _sixtyKa.Length - 1) + "და" + xLowStr;
                            }
                            else if (xLow > 80)
                            {
                                xLowStr = _eightyKa.Substring(0, _eightyKa.Length - 1) + "და" + xLowStr;
                            }
                        }
                    }
                    break;
                case Language.English:
                    if (xHigh > 0)
                    {
                        switch (xHigh)
                        {
                            case 1:
                                xHighStr = _oneEng + _hundredEng;
                                break;
                            case 2:
                                xHighStr = _twoEng + _hundredEng;
                                break;
                            case 3:
                                xHighStr = _threeEng + _hundredEng;
                                break;
                            case 4:
                                xHighStr = _fourEng + _hundredEng;
                                break;
                            case 5:
                                xHighStr = _fiveEng + _hundredEng;
                                break;
                            case 6:
                                xHighStr = _sixEng + _hundredEng;
                                break;
                            case 7:
                                xHighStr = _sevenEng + _hundredEng;
                                break;
                            case 8:
                                xHighStr = _eightEng + _hundredEng;
                                break;
                            case 9:
                                xHighStr = _nineEng + _hundredEng;
                                break;
                            default:
                                break;
                        }
                        xHighStr = xHighStr + (xLow > 0 ? " " : "");
                    }
                    else
                    {
                        xHighStr = "";
                    }
                    if (xLow > 0)
                    {
                        if (xLow == 10)
                        {
                            xLowStr = _tenEng;
                        }
                        else if (xLow == 20)
                        {
                            xLowStr = _twentyEng;
                        }
                        else if (xLow == 30)
                        {
                            xLowStr = _thirtyEng;
                        }
                        else if (xLow == 40)
                        {
                            xLowStr = _fortyEng;
                        }
                        else if (xLow == 50)
                        {
                            xLowStr = _fiftyEng;
                        }
                        else if (xLow == 60)
                        {
                            xLowStr = _sixtyEng;
                        }
                        else if (xLow == 70)
                        {
                            xLowStr = _seventyEng;
                        }
                        else if (xLow == 80)
                        {
                            xLowStr = _eightyEng;
                        }
                        else if (xLow == 90)
                        {
                            xLowStr = _ninetyEng;
                        }
                        else
                        {
                            int tmpLow;
                            Math.DivRem(xLow, 10, out tmpLow);
                            switch (tmpLow)
                            {
                                case 1:
                                    xLowStr = _oneEng;
                                    break;
                                case 2:
                                    xLowStr = _twoEng;
                                    break;
                                case 3:
                                    xLowStr = _threeEng;
                                    break;
                                case 4:
                                    xLowStr = _fourEng;
                                    break;
                                case 5:
                                    xLowStr = _fiveEng;
                                    break;
                                case 6:
                                    xLowStr = _sixEng;
                                    break;
                                case 7:
                                    xLowStr = _sevenEng;
                                    break;
                                case 8:
                                    xLowStr = _eightEng;
                                    break;
                                case 9:
                                    xLowStr = _nineEng;
                                    break;
                                default:
                                    break;
                            }
                            if (xLow > 10 & xLow < 20)
                            {
                                switch (xLow)
                                {
                                    case 11:
                                        xLowStr = _elevenEng;
                                        break;
                                    case 12:
                                        xLowStr = _twelveEng;
                                        break;
                                    case 13:
                                        xLowStr = _thirteenEng;
                                        break;
                                    case 14:
                                        xLowStr = _fourteenEng;
                                        break;
                                    case 15:
                                        xLowStr = _fifteenEng;
                                        break;
                                    case 16:
                                        xLowStr = _sixteenEng;
                                        break;
                                    case 17:
                                        xLowStr = _seventeenEng;
                                        break;
                                    case 18:
                                        xLowStr = _eighteenEng;
                                        break;
                                    case 19:
                                        xLowStr = _nineteenEng;
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else if (xLow > 20 & xLow < 30)
                            {
                                xLowStr = _twentyEng + "-" + xLowStr;
                            }
                            else if (xLow > 30 & xLow < 40)
                            {
                                xLowStr = _thirtyEng + "-" + xLowStr;
                            }
                            else if (xLow > 40 & xLow < 50)
                            {
                                xLowStr = _fortyEng + "-" + xLowStr;
                            }
                            else if (xLow > 50 & xLow < 60)
                            {
                                xLowStr = _fiftyEng + "-" + xLowStr;
                            }
                            else if (xLow > 60 & xLow < 70)
                            {
                                xLowStr = _sixtyEng + "-" + xLowStr;
                            }
                            else if (xLow > 70 & xLow < 80)
                            {
                                xLowStr = _seventyEng + "-" + xLowStr;
                            }
                            else if (xLow > 80 & xLow < 90)
                            {
                                xLowStr = _eightyEng + "-" + xLowStr;
                            }
                            else if (xLow > 90)
                            {
                                xLowStr = _ninetyEng + "-" + xLowStr;
                            }
                        }
                    }
                    break;
                case Language.Russian:
                    if (xHigh > 0)
                    {
                        switch (xHigh)
                        {
                            case 1:
                                xHighStr = _hundredRus;
                                break;
                            case 2:
                                xHighStr = _twoHundredRus;
                                break;
                            case 3:
                                xHighStr = _threeHundredRus;
                                break;
                            case 4:
                                xHighStr = _fourHundredRus;
                                break;
                            case 5:
                                xHighStr = _fiveHhundredRus;
                                break;
                            case 6:
                                xHighStr = _sixHundredRus;
                                break;
                            case 7:
                                xHighStr = _sevenHundredRus;
                                break;
                            case 8:
                                xHighStr = _eightHundredRus;
                                break;
                            case 9:
                                xHighStr = _nineHundredRus;
                                break;
                            default:
                                break;
                        }
                        xHighStr = xHighStr + (xLow > 0 ? " " : "");
                    }
                    else
                    {
                        xHighStr = "";
                    }
                    if (xLow > 0)
                    {
                        if (xLow == 10)
                        {
                            xLowStr = _tenRus;
                        }
                        else if (xLow == 20)
                        {
                            xLowStr = _twentyRus;
                        }
                        else if (xLow == 30)
                        {
                            xLowStr = _thirtyRus;
                        }
                        else if (xLow == 40)
                        {
                            xLowStr = _fortyRus;
                        }
                        else if (xLow == 50)
                        {
                            xLowStr = _fiftyRus;
                        }
                        else if (xLow == 60)
                        {
                            xLowStr = _sixtyRus;
                        }
                        else if (xLow == 70)
                        {
                            xLowStr = _seventyRus;
                        }
                        else if (xLow == 80)
                        {
                            xLowStr = _eightyRus;
                        }
                        else if (xLow == 90)
                        {
                            xLowStr = _ninetyRus;
                        }
                        else
                        {
                            int tmpLow;
                            Math.DivRem(xLow, 10, out tmpLow);
                            switch (tmpLow)
                            {
                                case 1:
                                    xLowStr = _oneRus;
                                    break;
                                case 2:
                                    xLowStr = _twoRus;
                                    break;
                                case 3:
                                    xLowStr = _threeRus;
                                    break;
                                case 4:
                                    xLowStr = _fourRus;
                                    break;
                                case 5:
                                    xLowStr = _fiveRus;
                                    break;
                                case 6:
                                    xLowStr = _sixRus;
                                    break;
                                case 7:
                                    xLowStr = _sevenRus;
                                    break;
                                case 8:
                                    xLowStr = _eightRus;
                                    break;
                                case 9:
                                    xLowStr = _nineRus;
                                    break;
                                default:
                                    break;
                            }
                            if (xLow > 10 & xLow < 20)
                            {
                                switch (xLow)
                                {
                                    case 11:
                                        xLowStr = _elevenRus;
                                        break;
                                    case 12:
                                        xLowStr = _twelveRus;
                                        break;
                                    case 13:
                                        xLowStr = _thirteenRus;
                                        break;
                                    case 14:
                                        xLowStr = _fourteenRus;
                                        break;
                                    case 15:
                                        xLowStr = _fifteenRus;
                                        break;
                                    case 16:
                                        xLowStr = _sixteenRus;
                                        break;
                                    case 17:
                                        xLowStr = _seventeenRus;
                                        break;
                                    case 18:
                                        xLowStr = _eighteenRus;
                                        break;
                                    case 19:
                                        xLowStr = _nineteenRus;
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else if (xLow > 20 & xLow < 30)
                            {
                                xLowStr = _twentyRus + " " + xLowStr;
                            }
                            else if (xLow > 30 & xLow < 40)
                            {
                                xLowStr = _thirtyRus + " " + xLowStr;
                            }
                            else if (xLow > 40 & xLow < 50)
                            {
                                xLowStr = _fortyRus + " " + xLowStr;
                            }
                            else if (xLow > 50 & xLow < 60)
                            {
                                xLowStr = _fiftyRus + " " + xLowStr;
                            }
                            else if (xLow > 60 & xLow < 70)
                            {
                                xLowStr = _sixtyRus + " " + xLowStr;
                            }
                            else if (xLow > 70 & xLow < 80)
                            {
                                xLowStr = _seventyRus + " " + xLowStr;
                            }
                            else if (xLow > 80 & xLow < 90)
                            {
                                xLowStr = _eightyRus + " " + xLowStr;
                            }
                            else if (xLow > 90)
                            {
                                xLowStr = _ninetyRus + " " + xLowStr;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion        
    }

    public static class NumberToWordsConverterExtensions
    {
        #region Methods
        /// <summary>
        /// Convert number in words
        /// </summary>
        /// <param name="inputNumber">Numeric value 18 registry long max</param>
        /// <param name="language">Language to use</param>
        /// <param name="shouldInlcudeFractionAsWords">Weather fraction part should also be translated to words or not</param>
        /// <returns>Number in words</returns>
        public static string? ConvertNumberToWords(this int? inputNumber, Language language)
        {
            return NumberToWordsConverter.ConvertNumberToWords(inputNumber.ToString(), language);
        }

        /// <summary>
        /// Convert number in words
        /// </summary>
        /// <param name="inputNumber">Numeric value 18 registry long max</param>
        /// <param name="language">Language to use</param>
        /// <param name="shouldInlcudeFractionAsWords">Weather fraction part should also be translated to words or not</param>
        /// <returns>Number in words</returns>
        public static string? ConvertNumberToWords(this long? inputNumber, Language language)
        {
            return NumberToWordsConverter.ConvertNumberToWords(inputNumber.ToString(), language);
        }

        /// <summary>
        /// Convert number in words
        /// </summary>
        /// <param name="inputNumber">Numeric value 18 registry long max</param>
        /// <param name="language">Language to use</param>
        /// <param name="shouldInlcudeFractionAsWords">Weather fraction part should also be translated to words or not</param>
        /// <returns>Number in words</returns>
        public static string? ConvertNumberToWords(this byte? inputNumber, Language language)
        {
            return NumberToWordsConverter.ConvertNumberToWords(inputNumber.ToString(), language);
        }

        /// <summary>
        /// Convert number in words
        /// </summary>
        /// <param name="inputNumber">Numeric value 18 registry long max</param>
        /// <param name="language">Language to use</param>
        /// <param name="shouldInlcudeFractionAsWords">Weather fraction part should also be translated to words or not</param>
        /// <returns>Number in words</returns>
        public static string? ConvertNumberToWords(this string inputNumber, Language language)
        {
            return NumberToWordsConverter.ConvertNumberToWords(inputNumber, language);
        }
        #endregion Methods
    }    
}