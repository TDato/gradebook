using System;
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
            Console.WriteLine(book);



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
