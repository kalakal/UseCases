using System;

namespace EmployRoll1

{
    //usecase1
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int value = random.Next(0, 1);
            if (value == 1)
            {
                Console.WriteLine("present");
            }
            else
                Console.WriteLine("not present");
        }
    }
}

