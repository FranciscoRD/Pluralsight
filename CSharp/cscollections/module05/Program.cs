using System;
using System.Collections.Generic;

namespace module05
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = 
                @"C:\Proyectos\Pluralsight\CSharp\cscollections\module05\population.csv";
            CsvReader reader = new CsvReader(filePath);

            Dictionary<string, Country> countries = reader.ReadAllCountries();

            Console.WriteLine("Which country code do you want to look up? ");
            string userInput = Console.ReadLine();

            bool gotCountry = countries.TryGetValue(userInput, out Country country);
            if (!gotCountry)
            {
                Console.WriteLine($"Sorry, there is no country with code: {userInput}");
            }
            else
            {
                Console.WriteLine($"{country.Name} has population {country.Population}");
            }

        }
    }
}
/*

Country norway = new Country("Norway", "NOR","Europe", 5_282_223);
Country finland = new Country("Finland", "FIN", "Europe", 5_551_303);

var countries = new Dictionary<string, Country>()
{
    {norway.Code, norway},
    {finland.Code, finland}
};

// countries.Add(norway.Code, norway);
// countries.Add(finland.Code, finland);

// Country selectedCountry = countries["NOR"];
// Console.WriteLine($"{selectedCountry.Name}");

// foreach (var country in countries.Values)
//     Console.WriteLine(country.Name)

bool exist = countries.TryGetValue("MUS", out Country country);
if (exist)
    Console.WriteLine(country.Name);
else
{
    Console.WriteLine("There is no country with the code MUS");
}

*/
