using System;
using System.Collections.Generic;

namespace SchoolTrackerList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in your class?");
            var studentGrades = new List<int>();
            var studentNames  = new List<string>();

            var adding = true;

            while ( adding )
            {
                Console.WriteLine("Student Name: ");
                studentNames.Add(Console.ReadLine());

                Console.WriteLine("Student Grade: ");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add Another? y/n");

                if (Console.ReadLine() != "y")
                {
                    adding = false;
                }
            }


            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine("Student: {0} | Grade: {1}", studentNames[i], studentGrades[i]);
            }
        }
    }
}
