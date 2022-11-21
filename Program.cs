using System;

namespace Nov22_Fundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("\nProgrma for adding three numbers");
            int sum = 0;
            for (int i = 1; i <= 3; i++)
            {
                //Console.Write("Enter " + i + " Number\t: ");
                Console.Write("Enter {0} Number ", i);
                sum = sum+Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum.ToString());
        }
    }
}
