using System;
using System.Collections.Generic;

namespace module04
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = 
                @"C:\Proyectos\Pluralsight\CSharp\cscollections\module04\population.csv";

            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();
            Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2_000_000);
            int lilliputIndex = countries.FindIndex(x => x.Population < 2_000_000);
            countries.Insert(lilliputIndex,lilliput);

            countries.RemoveAt(lilliputIndex);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{country.Population} : {country.Name}");
            }
            Console.WriteLine($"Cantidad de Paises: {countries.Count}");
        }
    }
}

/*
List<string> daysOfWeek = new List<string>(7)
{
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};
Console.WriteLine($"Elementos en la Lista: {daysOfWeek.Count},Capacidad de la Lista: {daysOfWeek.Capacity}");
daysOfWeek.Add("Dia inexistente");
Console.WriteLine($"Elementos en la Lista: {daysOfWeek.Count},Capacidad de la Lista: {daysOfWeek.Capacity}");

List<int> ints = new List<int>();

List<string> valores = new List<string>(4){"Hola","Mundo"};

foreach (var elemento in valores)
{
    Console.WriteLine(elemento);
}
Console.WriteLine($"Elementos en la Lista: {valores.Count},Capacidad de la Lista: {valores.Capacity}");
*/