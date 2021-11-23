using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int members, capacity, full, last;
            Console.WriteLine("Enter number of members: ");
            members = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter capacity of coaches: ");
            capacity = Convert.ToInt32(Console.ReadLine());
            full = members / capacity;
            last = members % capacity;
            Console.WriteLine("Number of full coaches: {0}", full);
            Console.WriteLine("Number of members in last coach: {0}", last);
            Console.ReadLine();
        }
    }
}
