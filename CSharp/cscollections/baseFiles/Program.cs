using System;
using System.Collections.Generic;

namespace CAMBIARNAMESPACE
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = 
                @"C:\Proyectos\Pluralsight\CSharp\cscollections\module07\population.csv";

            CsvReader reader = new CsvReader(filePath);
            List<Country> countries = reader.ReadAllCountries();

            foreach (Country country in countries)
            {
                Console.WriteLine($"{country.Population} : {country.Name}");
            }
            Console.WriteLine($"Cantidad de Paises: {countries.Count}");
        }
    }
}
