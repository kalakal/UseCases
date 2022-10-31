using System;

namespace EmployRoll1

{
    //UseCase3
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPartTime = 1;
            int isFullTime = 2;
            int empRatePerHr = 20;
            int emphr = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == isPartTime)
            {
                emphr = 4;
            }
            else if (empCheck == isFullTime)
            {
                emphr = 8;

            }
            else
            {
                emphr = 0;
            }
            empWage = emphr * empRatePerHr;
            Console.WriteLine("EmpWage = :" + empWage);
        }
    }
}
   


