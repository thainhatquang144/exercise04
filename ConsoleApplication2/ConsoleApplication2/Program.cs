﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Rand1());
            Console.WriteLine(Factorial(5));
        }
        public static bool IsPrime(int n)
        {
            int count = 0;
            for (int i = 0; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                } if (count < 2)
                {
                    return false;
                }
            }
        return true;
        }
        //input:
        //output:
        public static int Ceil(float x)
        {
            if (x < 0)
             return ((int)x);
             
              return ((int)x)+1;
            
        }
        public static int floor(float x)
        {
            int a = (int)x;
            if (x < 0)
                if(x>a)
                return ((int)x)-1;
            return ((int)x);
        }
        public static int Rand1()
        {
            Random rand = new Random();
            int rd= rand.Next(0, 2147483647);
            return rd;

        }
        public static long Factorial(long n)
        {
            long R=1 ;
            for (int i = 1; i <= n; i++)
            {
                R = i*R;
            }
            return R;
        }

    }
}
