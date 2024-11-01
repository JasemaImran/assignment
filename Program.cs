using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cal_age age1 = new cal_age();
            Console.WriteLine(age1.calculate_age());
            Console.ReadLine(); 

        }
    }
}
