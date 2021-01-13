using System;
using System.Collections.Generic;


namespace GradeBook
{

    /***
    * All Events in .Net, typically have two parameters
    * first parameter: an object as sender
    * second parameter: an EventArgs args
    ***/
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class InMemoryBook : Book {


        public InMemoryBook(string name) 
            : base(name)
        {
            Name = name;
            grades = new List<double>();
        }

        public void AddGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                case 'D':
                    AddGrade(60);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }

        public override void AddGrade(double grade) 
        {
            if(grade <= 100 && grade >= 0) 
            {
                this.grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else 
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        
        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            foreach(var grade in this.grades) 
            {
                result.Add(grade);
            }

            return result;
        }

    
        public override string ToString()
        {
            return $"Name: {Name}\n"+
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
        public override event GradeAddedDelegate GradeAdded;

        readonly string category;
    }
}