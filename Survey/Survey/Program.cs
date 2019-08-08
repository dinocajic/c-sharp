using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            var name  = getInput("What is your name?");
            var age   = getInput("What is your age?");
            var month = getInput("What month were you born in?");

            displayOutput(name, age, month);
        }

        static string getInput(string question)
        {
            Console.WriteLine( question );

            var str = Console.ReadLine();

            while ( str == "" )
            {
                Console.WriteLine("You didn't enter anything. Try again.");
                str = Console.ReadLine();
            }

            return str;
        }

        static void displayOutput(string name, string age, string month)
        {
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("You were born in: {0}", month);

            if (month.Equals("October"))
            {
                Console.WriteLine("You are a Libra");
            }
            else if (month.Equals("November"))
            {
                Console.WriteLine("You are a Scorpio");
            }

            switch (age)
            {
                case "31":
                    Console.WriteLine("Hey, you're {0}", age);
                    break;
                case "32":
                    Console.WriteLine("Sup Homie");
                    break;
            }
        }
    }
}
