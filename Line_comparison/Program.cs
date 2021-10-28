using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            double len, length;
            double point1, point2;

            Console.WriteLine("Enter value of x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of y1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of y2");
            y2 = Convert.ToDouble(Console.ReadLine());

            // formula of length = sqrt[(x2 -x1)^2 + (y2-y1)^2]
            point1 = Math.Pow((x2 - x1), 2);
            point2 = Math.Pow((y2 - y1), 2);
            len = point1 + point2;
            length = Math.Sqrt(len);

            Console.WriteLine("The length of line is: " + length);
            Console.ReadLine();

        }
    }
}
