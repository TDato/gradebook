﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Tommy's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(92.6);
            book.AddGrade(77.5);
            book.AddGrade(104.0);
            book.AddGrade(95.1);
            var stats = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
            
        }
    }
}
