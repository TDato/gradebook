using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1};
            grades.Add(100.0);
            var result = 0.0;
            var average = 0.0;
            foreach(double grade in grades) 
            {
                result += grade;
            }
            average = result / grades.Count;

            Console.WriteLine(result);
            Console.WriteLine($"Average grade is {average}");

            if (args.Length > 0) 
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendJoin(' ', args);
                Console.WriteLine($"Hello, {sb.ToString()}!");
            } 
            else 
            {
                Console.WriteLine("Hello!");
            }

        }
    }
}
