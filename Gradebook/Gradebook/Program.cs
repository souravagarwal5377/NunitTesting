using Gradebook;
using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var gradebook = new Book("Tom's GradeBook");
            gradebook.AddGrade(77.8);
            gradebook.AddGrade(87.1);
            gradebook.AddGrade(93.6);
            gradebook.showStatistics();
        }
    }
}