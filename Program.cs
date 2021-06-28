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

                Console.WriteLine("1.Enter Triangle dimensions");
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
            int selection;
            selection = MenuChoice();
            if (selection != 2)
            {
                Console.WriteLine("Please enter the dimensions of the triangle(eg: a,b,c):\n");
                string dimensions = Console.ReadLine();
                int[] sides = Array.ConvertAll(dimensions.Split(','), int.Parse);
                int a = sides[0];
                int b = sides[1];
                int c = sides[2];
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    Console.WriteLine("It does not form a Triangle!");
                }
                else 
                {
                    TriangleSolver.Analyze(a, b, c);
                }
                
            }
             
        }
    }
}
