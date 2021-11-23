using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            Console.WriteLine("Enter Fahrenheit: ");
            f = Convert.ToDouble(Console.ReadLine());
            c = 5 * (f - 32) / 9;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
