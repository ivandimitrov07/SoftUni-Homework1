using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintASecuence
{
    class Program
    {
        static void Main(string[] args)
        {
            int even = 2;
            int odd = -3;
            for (int i = 0; i < 5; i++)
            {
                Console.Write(even + "," + odd + ",");
                even += 2;
                odd -= 2;
            }
        }
    }
}
