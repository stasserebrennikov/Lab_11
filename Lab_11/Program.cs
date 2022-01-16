using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k = Convert.ToDouble (Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Primer primer1 = new Primer(k, b);
            Console.WriteLine(primer1.Root());  
            Console.ReadKey();  
        }
    }
}
