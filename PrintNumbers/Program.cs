using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Convert.ToString(x, 2));
                x += 4;
            }
        }
    }
}
