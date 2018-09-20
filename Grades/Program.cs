using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // defining a variable from the class gradebook
            //when creating a class definition we can think of the class as a cookie cutter. Class can be used to create objects with a specific and consistent shape
            //using the new keyword allows us to ask for a new instance of the Gradebook class. We store a reference of the object in the variable book
            GradeBook book = new GradeBook();
            book.NameChanged += OnNameChanged;


            book.Name = "Adrian's Grade Book";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);


            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            Console.ReadKey();
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }

        static void WriteResult(string description, int result)
        {

            Console.WriteLine($"{ description}: { result}");
        }
        static void WriteResult(string description, float result)
        {

            Console.WriteLine("{0}: {1}", description, result);
        }
    }
}
