using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            const double vat = 0.2;
            double InitialCost, VATtoBePaid, Total;
            Console.WriteLine("Enter initial cost:");
            InitialCost = Convert.ToDouble(Console.ReadLine());
            VATtoBePaid = InitialCost * vat;
            Total = VATtoBePaid + InitialCost;
            Console.WriteLine("VAT = {0}",VATtoBePaid);
            Console.WriteLine("Total cost = {0}", Total);
            Console.ReadLine();
        }
    }
}
