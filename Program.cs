using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNum
{
    class Program
    {
        static void bin(long n)
        {
            long i;
            Console.Write("0");
            for (i = 1 << 30; i > 0; i = i / 2)
            {
                if ((n & i) != 0)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
            }
        }
        
        static public void Main()
        {
            bin(7);
            Console.WriteLine();
            bin(4);
        }
    }
}

