using System;

namespace solo_prep_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is solo prep 1");

            // Write your code here
            Console.Write("What is your first name? ");
            string userName = Console.ReadLine();

            Console.Write("What is your last name? ");
            string userLast = Console.ReadLine();

            Console.WriteLine($"Your name is {userLast}, {userName} {userLast}.");
        }
    }
}
