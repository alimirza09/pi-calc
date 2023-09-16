using System;
using System.Collections.Generic;
using System.Linq;

namespace HCF_Calculator;

internal class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Enter your first number");
        int num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter your second number");
        int num2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter operation");
        string op = Console.ReadLine();
        switch (op)
        {
           case"/":
            if (num2 != 0)
                {
                Console.WriteLine(num1/num2);
                }
            if (num2 == 0)
                {
                Console.WriteLine("Cannot divide by Zero");
                }
            break;
            case"+":
                Console.WriteLine(num1+num2);
                break;
            case"*":
                Console.WriteLine(num1*num2);
                break;
           case"-":
            Console.WriteLine(num1-num2);
            break;
           case"sqrt":
            Console.WriteLine(Math.Sqrt(num1));
            break;
           case"HCF":
            int[] prime =  {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
            List<double> num1_Factors = new List<double>();
            int i = 0;
            List<double> num2_Factors = new List<double>();
            while (i <= prime.Length)
            {
                if (num1 % prime[i] == 0)
                {
                    num1_Factors.Add(prime[i]);
                    i++;
                }
            
            }
            while (i <= prime.Length)
            {
                if (num2 % prime[i] == 0)
                {
                    num2_Factors.Add(prime[i]);
                    i++;
                }
            }
            
            List<int> Factors = new List<int>();
            foreach (int factor in num1_Factors)
            {
                if (num2_Factors.Contains(factor))
                {
                    Factors.Add(factor);
                }
                
            }
            foreach(int j in Factors)
            {

            }
            int hcf = Factors[0];
                foreach (var factor in Factors.Where(factor => factor > hcf))
                {
                    hcf = factor;
                }

                Console.WriteLine("The highest common factor of " + num1 + " and " + num2 + " is " + hcf);
                break;
            
        }
    }
}
                  