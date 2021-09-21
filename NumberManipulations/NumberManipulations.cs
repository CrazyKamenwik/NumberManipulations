using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NumberManipulations
{
    public class NumberManipulation
    {
        public static void Manipulations(string number)
        {
            char[] symbols = number.ToCharArray();

            for (int i = 0; i < symbols.Length; i++)
            {
                string CountryCode = "";
                switch (symbols[i])
                {
                    case '+':
                        foreach (var country in CountryModel.Countries)
                        {
                            char[] code = country.Code.ToCharArray();
                            int k = i;
                            for (int j = 0; j < code.Length; j++)
                            {

                                if (code[j] == symbols[k])
                                {
                                    CountryCode += code[j];
                                    k++;
                                }
                                else
                                {
                                    CountryCode = "";
                                    break;
                                }

                            }
                            if (CountryCode.Equals(country.Code))
                            {
                                char[] trim = { ' ', '+' };
                                var number2 = new string(symbols);
                                number2 = number2.Trim(trim);
                                CountryCode = CountryCode.Trim(trim);
                                number2 = Regex.Replace(number2, CountryCode, "");
                                Console.WriteLine("Number is {2},\tCountry code is +{0},\tCountry name is {1}.", CountryCode, country.Name, number2);
                                i = number.Length;
                                break;
                            }
                        }
                        break;

                    case '0':
                        if (symbols[i + 1] == '0')
                        {
                            symbols[i] = ' ';
                            symbols[i + 1] = '+';
                            continue;
                        }
                        else
                        {
                            symbols[i] = ' ';
                            break;
                        }

                    default:
                        symbols[i] = ' ';
                        Console.WriteLine(symbols[i]);
                        break;
                }
            }
        }
    }
}
