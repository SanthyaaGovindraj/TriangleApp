using System;

namespace TriangleApp
{
    class Program
    {

        public static int MenuChoice()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)

            {

                Console.WriteLine("1.Enter Triangle dimensions:");
                Console.WriteLine("2.Exit\n");

                Console.WriteLine("Please select an option:\n");
                userInput = Console.ReadLine();

                if (userInput != "1" &&
                    userInput != "2")
                {
                    Console.WriteLine("That's not a valid menu option, please try again:\n");
                }
                else
                {
                    validMenuSelect = true;
                }
            }

            Console.WriteLine();
            return int.Parse(userInput);
        }


        static void Main(string[] args)
        {
            MenuChoice();
        }
    }
}
