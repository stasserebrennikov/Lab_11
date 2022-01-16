using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    struct Primer
    {
        double k;
        double b;

        public Primer(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            double x = - b / k;
            if (k > 0 && k < 0)
                return "Решений нет";
            double r = k * x + b;
            
                return $" Находим X = { x}\n Решение верно, уравнение равно - {r = 0} ";

        }
    }
}
