using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;




namespace NumberManipulations
{
    public class NumberSorting
    {
       static void Main(string[] args)
        {
            CountryModel countryModel = new CountryModel();
            Console.WriteLine("Enter the number:");
            var number = Console.ReadLine();
            Console.WriteLine(number = Regex.Replace(number, @"[^0-9\+]", ""));

            NumberManipulation.Manipulations(number);
        }

        public void EnterNumber(string number1)
        {
            CountryModel countryModel = new CountryModel();
            var number = Console.ReadLine();
            Console.WriteLine(number = Regex.Replace(number1, @"[^0-9\+]", ""));

            NumberManipulation.Manipulations(number1);
        }
    }
}


 