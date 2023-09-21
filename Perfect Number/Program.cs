
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211201作業
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i;
            for (num = 2; num < 1000; num++)
            {
                int sum = 0;
                for (i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                        continue;
                    }
                }
                if (sum == num)
                {
                    Console.Write("1~1000完美數有 "+sum);
                    Console.ReadLine();
                }
            }
        }
    }
}
