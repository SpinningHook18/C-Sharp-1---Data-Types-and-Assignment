using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int widgets, fullBoxes, leftOver;
            Console.WriteLine("Enter number of widgets:");
            widgets = Convert.ToInt32(Console.ReadLine());
            fullBoxes = widgets / 150;
            leftOver = widgets % 150;
            Console.WriteLine("Number of full boxes: {0}", fullBoxes);
            Console.WriteLine("Widgets left over: {0}", leftOver);
            Console.ReadLine();
        }
    }
}
