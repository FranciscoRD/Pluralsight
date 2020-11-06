using System;

namespace module03
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = 
                @"C:\Proyectos\Pluralsight\CSharp\cscollections\module03\population.csv";

            CsvReader reader = new CsvReader(filePath);

            Country[] countries = reader.ReadFirstNCountries(10);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{country.Population} : {country.Name}");
            }
        }
    }
}
