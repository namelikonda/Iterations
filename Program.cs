using System;

namespace Iterations

{

    class Program

    {
        static void Main(string[] args)

        {
            Console.Write("How Many Years of experience do you have in professional Programming: ");
            
            try
            {
                string Experience = Console.ReadLine();
                int YOE = int.Parse(Experience);
                for (int i = 0; i < YOE; i++)
                {
                    Console.WriteLine("You have : " + i.ToString() + "Years of Experience");
                }
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }
        }
    }
}