using System;
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
        }
        public static bool IsPrime(int n)
        {
            int count = 0;
            for (int i = 0; i <= n; i++)
            {
                if (n % n == 0)
                {
                    count++;
                } if (count < 2)
                {
                    return false;
                }
            }
        return true;
        }

    }
}
