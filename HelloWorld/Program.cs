using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, thank you for taking the time to participate in our survey.  Please answer the following:");

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();

            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();

            Console.WriteLine("Thanks, you entered:");
            Console.WriteLine("Your name is {0}.", name);
            Console.WriteLine("You are {0} years old.", age);
            Console.WriteLine("You were born in {0}.", month);
        }
    }
}
