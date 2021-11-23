using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Unit1Mark, Unit2Mark, TotalMark;
            double AverageMark;
            Console.Write("Enter mark for unit 1: ");
            Unit1Mark = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter mark for unit 2: ");
            Unit2Mark = Convert.ToInt32(Console.ReadLine());
            //TotalMark = Unit1Mark + Unit2Mark;
            //Console.WriteLine("The total mark is: " + TotalMark);
            AverageMark = (Unit1Mark + Unit2Mark) / 2;
            Console.WriteLine("The average mark is: " + AverageMark);
            Console.ReadLine();
            



        }
    }
}
