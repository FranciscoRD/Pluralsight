using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // IBook book = new InMemoryBook("Scott's Grade Book");
            IBook book = new DiskBook("GradeBook");
            book.GradeAdded += OnGradeAdded;

            EnterGrade(book);
            ShowStatistics(book);
        }

        private static void EnterGrade(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or enter 'q' to quit: ");
                string input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void ShowStatistics(IBook book)
        {
            Statistics result = book.GetStatistics();
            Console.WriteLine($"{book.Name} Statistics: ");
            /*
            foreach (var grade in book.Grades)
            {
                Console.Write($"\t{grade}");
            }
            */

            Console.WriteLine(
                $"\n\tAverage: {result.Average:N2}"+
                $"\n\tLowest Grade: {result.Low}"+
                $"\n\tHighest Grade: {result.High}"+
                $"\n\tLetter Grade: {result.Letter}");
        }

        private static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}