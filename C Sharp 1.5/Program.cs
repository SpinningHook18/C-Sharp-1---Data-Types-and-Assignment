using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h , a;
            b = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
            a = b * h / 2;
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
