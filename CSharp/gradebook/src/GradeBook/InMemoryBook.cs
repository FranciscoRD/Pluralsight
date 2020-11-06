using System;
using System.Collections.Generic;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class InMemoryBook : Book
    {
        public override event GradeAddedDelegate GradeAdded;
        private List<double> grades;

        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
            Name = name;
        }

        public override void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
                // Console.WriteLine("Invalid value!");
            }
        }

        public override Statistics GetStatistics()
        {
            Statistics result = new Statistics();

            for (int index = 0; index < grades.Count; index++)
            {
                result.Add(grades[index]);
            }
            
            return result;
        }

        /*
        public void ShowStatistics()
        {
            Statistics result = GetStatistics();
            Console.WriteLine($"Elements in {Name}: ");
            foreach (var grade in Grades)
            {
                Console.Write($"\t{grade}");
            }

            Console.WriteLine(
                $"\nStatistics: "+
                $"\n\tAverage: {result.Average:N2}"+
                $"\n\tLowest Grade: {result.Low}"+
                $"\n\tHighest Grade: {result.High}"+
                $"\n\tLetter Grade: {result.Letter}");
        }
        */
    }
}