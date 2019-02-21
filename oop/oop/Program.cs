using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //pluralsight
            //if(DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            //{
            //    Console.WriteLine("Another case of the Wednesday!");
            //}
            //Console.WriteLine("Your name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("How many hours of sleep did you get last night?");
            //int hoursOfSleep = int.Parse(Console.ReadLine());

            //Console.WriteLine("Hello, " + name);

            //if(hoursOfSleep > 8)
            //{
            //    Console.WriteLine("you are well rested");
            //} 
            ////else
            ////{
            ////    Console.WriteLine("you need more sleep");
            ////}
            ///

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
