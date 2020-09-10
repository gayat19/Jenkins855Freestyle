﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProj
{
    class Program
    {
        int iNum1 = 0, iNum2 = 0;
        void GetNumbers()
        {
            
            Console.WriteLine("Please enter the first number");
            while (!Int32.TryParse(Console.ReadLine(), out iNum1) || iNum1<=0)
            {
                Console.WriteLine("Invalid entry for Num1. Please try again");
            }
            while (!Int32.TryParse(Console.ReadLine(), out iNum2) || iNum2 <= 0)
            {
                Console.WriteLine("Invalid entry for Num2. Please try again");
            }
            Add();
        }

        private void Add()
        {
            int iSum = iNum1 + iNum2;
            Console.WriteLine("The sum is "+iSum);
        }

        static void Main(string[] args)
        {
            new Program().GetNumbers();
            Console.ReadKey();
        }
    }
}
