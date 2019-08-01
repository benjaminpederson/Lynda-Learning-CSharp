using System;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var pass="";

            while (pass != "secret")
            {
                Console.WriteLine("Please enter the secure passcode to confirm your access.");
                pass = Console.ReadLine();

                if (pass != "secret")
                {
                    Console.WriteLine("Invalid Passcode, Authorization Denied");
                }
            }
            Console.WriteLine("User Authentication Complete, Access Granted");
        }
    }
}
