using System;

namespace CG_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Combo();
            Console.ReadLine();
        }
        private static void Combo()
        {
            //User inputs first name here
            Console.WriteLine("Please enter your first name.");
            string FirstName = Console.ReadLine();

            //User inputs their last name here
            Console.WriteLine("Please enter your last name.");
            string LastName = Console.ReadLine();

            //This compiles the input and outputs result
            Console.WriteLine($"Hello {FirstName} {LastName}! Nice to meet you.");
            Console.ReadLine();
        }
    }
}
