using System;
using System.Collections.Generic;

namespace module06
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = 
                @"C:\Proyectos\Pluralsight\CSharp\cscollections\module06\population.csv";

            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();
            reader.RemoveCommaCountries(countries);

            Console.Write("Enter no. of countries to display: ");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if (!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("You must type in a +ve integer. Exiting");
                return;
            }

            // int maxToDisplay = Math.Min(userInput, countries.Count);
            int maxToDisplay = userInput;
            
            for (int index = 0; index < countries.Count; index++)
            {
                // Country country = countries[index];
                // Console.WriteLine($"{country.Population} : {country.Name}");
                if (index > 0 && (index % maxToDisplay == 0))
                {
                    Console.WriteLine("Hit return to continue, anything else to quit>");
                    if(Console.ReadLine() != "")
                        break;
                }
                Country country = countries[index];
                Console.WriteLine($"{index+1} {country.Population} : {country.Name}");
            }

            /*
            for (int index = countries.Count - 1; index >= 0; index-- )
            {
                int displayIndex = countries.Count - 1 - index;
                if (displayIndex > 0 && (displayIndex % maxToDisplay == 0))
                {
                    Console.WriteLine("Hit return to continue, anything else to quit>");
                    if(Console.ReadLine() != "")
                        break;
                }
                Country country = countries[index];
                Console.WriteLine($"{displayIndex+1} {country.Population} : {country.Name}");
            }
            */
        }
    }
}
