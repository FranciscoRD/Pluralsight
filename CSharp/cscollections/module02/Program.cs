using System;

namespace module02
{
    class Program
    {
        static void Main(string[] args)
        {
            // string monday = "Monday";

            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thurdsday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
            /*
            Console.WriteLine("Which day do you what to display? ");
            Console.Write("(Monday = 1, etc. ) > ");
            int iDay = int.Parse(Console.ReadLine());

            string chosenDay = daysOfWeek[--iDay];
            Console.WriteLine($"That day is {chosenDay}");
            */
        }
    }
}
