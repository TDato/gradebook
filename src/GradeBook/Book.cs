using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class Book {

        /// <summary>
        /// Default Constructor to initialize a Book object
        /// </summary>
        public Book() 
        {
            this.grades = new List<double>();
        }

        public Book(string name)
        {
            this.name = name;
            this.grades = new List<double>();
        }

        /// <summary>
        /// Adds a double value to the grade list in the book
        /// </summary>
        /// <param name="grade">A double precision number.</param>
        public void AddGrade(double grade) 
        {
            this.grades.Add(grade);
        }
        // /// <summary>
        // /// Computes the average grade value
        // /// </summary>
        // /// <returns>
        // /// The average grade from the list of grades
        // /// </returns>
        // public double GetAverage() 
        // {
        //     return this.sum / this.grades.Count;
        // }

        public void SetName(string name)
        {
            this.name = name;
        }
        
        public string GetName()
        {
            return this.name;
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var grade in this.grades) 
            {
                lowGrade = Math.Min(grade, lowGrade);
                highGrade = Math.Max(grade, highGrade);
                result += grade;
            }

            result /= this.grades.Count;
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N2}");
        }

    
        public override string ToString()
        {
            return $"Name: {this.name}\n"+
                   $"Grades: {this.printList()}\n";
        }

        private string printList()
        {
           return string.Join(", ", this.grades.ToArray());
        }


        // -----------------------------
        // Data
        // -----------------------------
        private List<double> grades;
        private string name;
    }
}