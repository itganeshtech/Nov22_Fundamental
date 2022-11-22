using System;

namespace Nov22_Fundamental
{
    class Factorial
    {
        public void Fact()
        {
            Console.WriteLine("Enter Number");
            int k = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            while (k > 0)
            {
                fact = fact * k;
                k--;
            }
            Console.WriteLine("Factorial=" + fact.ToString());
        }
        public void Hello()
        {
            Console.WriteLine("Hello World!");

        }
        public void AddNum()
        {
            Console.WriteLine("\nProgram for adding three numbers");
            int sum = 0;
            for (int i = 1; i <= 3; i++)
            {
                //Console.Write("Enter " + i + " Number\t: ");
                Console.Write("Enter {0} Number ", i);
                sum = sum + Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum.ToString());
        }
    }
}
