using System;

namespace SquareCubeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Enter a number");
                int number = int.Parse(Console.ReadLine());
                int squared = Square(number);
                Console.WriteLine("{0} squared is {1}", number, squared);
                int cubed = Cube(number);
                Console.WriteLine("{0} cubed is {1}", number, cubed);
                Console.WriteLine("Would you like to try again? Press Y or y to start over or any other sign to quit");
                answer = Console.ReadLine();
            } while (answer == "Y" || answer == "y");
        }

        public static int Square(int number)
        {
            int answer = number * number;
            return answer;
        }

        public static int Cube(int number)
        {
            int answer = Square(number) * number;
            return answer;
        }
    }
}
