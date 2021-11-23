using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, radius, sArea, volume;
            Console.WriteLine("Enter height:");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter radius:");
            radius = Convert.ToDouble(Console.ReadLine());
            volume = Math.PI * radius * radius * height;
            sArea = 2 * Math.PI * radius * (radius + height);
            Console.WriteLine("Volume: {0}", volume);
            Console.WriteLine("Surface Area: {0}", sArea);
            Console.ReadLine();
        }
    }
}
