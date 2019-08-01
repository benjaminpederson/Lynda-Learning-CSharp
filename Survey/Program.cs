using System;

namespace Survey
{
    class Data
    {
        public string Name;
        public int Age;
        public string Month;

        public void Display()
        {
            Console.WriteLine("Thanks, you entered:");
            Console.WriteLine("Your name is {0}.", Name);
            Console.WriteLine("You are {0} years old.", Age);
            Console.WriteLine("You were born in {0}.", Month);

            switch (Month)
            {
                case "march":
                case "March":
                    Console.WriteLine("You are an Aries.");
                    break;
                case "april":
                case "April":
                    Console.WriteLine("You are a Taurus.");
                    break;
                case "may":
                case "May":
                    Console.WriteLine("You are a Gemini.");
                    break;
            }
        }
    }
    class Program
    {
        public static event Action Posted;
        static void Main(string[] args)
        {
            var stats = new Stats();
            stats.Start();
            var data = new Data();

            Console.WriteLine("Hello, thank you for taking the time to participate in our survey.  Please answer the following:");

            Console.WriteLine("What is your name?");
            data.Name = QuestionAnswer();

            Console.WriteLine("How old are you?");
            data.Age = int.Parse(QuestionAnswer());

            Console.WriteLine("What month were you born in?");
            data.Month = QuestionAnswer();
            
            if(Posted != null)
                Posted();

            data.Display();
        }
         
        static string QuestionAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You did not type anything, please try again.");
                return Console.ReadLine();
            }
            return answer;
        }
    }
}
