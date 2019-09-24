using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Book
    {
        string name;
        List<double> grades;

        public Book(string name)
        {
            this.name = name;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public double MinGrade()
        {
            double minGrade = double.MaxValue;
            foreach(double grade in grades)
            {
                if (grade < minGrade)
                    minGrade = grade;
            }
            return minGrade;
        }

        public double MaxGrade()
        {
            double maxGrade = double.MinValue;
            foreach (double grade in grades)
            {
                if (grade > maxGrade)
                    maxGrade = grade;
            }
            return maxGrade;
        }

        public double AvgGrade()
        {
            double avgGrade = 0.0;
            foreach(double grade in grades)
            {
                avgGrade += grade;
            }
            avgGrade /= grades.Count;
            return avgGrade;
        }

        public void showStatistics()
        {
            Console.WriteLine("Displaying statistics on "+name+"\'s gradebook:");
            double minGrade=MinGrade(), maxGrade=MaxGrade(), avgGrade=AvgGrade();
            Console.WriteLine("Minimum Grade: " + minGrade);
            Console.WriteLine("Maximum Grade: " + maxGrade);
            Console.WriteLine("Average Grade: " + avgGrade);
        }
    }
}
