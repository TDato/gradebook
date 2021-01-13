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

            while(true)
            {
                Console.WriteLine("Please enter a grade or 'q' to quit):");
                var input = Console.ReadLine();
                // check for quit
                if (input == "q" || input == "Q") 
                {
                    break;
                }
                
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex) // stack catches for specific exceptions
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // A finally block useful if there's a piece of code 
                    // that you always always always want to execute wether 
                    // an exception was thrown or not
                    // Example:
                    // Close a file, close a network socket, or clean things up even 
                    // when there has been an exception
                    Console.WriteLine("**");
                }

                

            }

            var stats = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
            
        }
    }
}
