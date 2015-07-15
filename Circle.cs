using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Листинг_программы
{
    class Program
    {
        static void Main(string[] args)
        {
            double RAD; 
            while (true)
            {
                Console.Write("Ввдите радиус окружности: ");
                RAD = double.Parse(Console.ReadLine());
                if (RAD < 0 )
                    break;
               Console.Write("\nТакой окружности не существует! Повторите попытку:\n\n");
            }
            Console.Write("\nВведите абциссу центра окружности: ");
            double cordX = double.Parse(Console.ReadLine());
            Console.Write("\nВвдите ординату центра окружности: ");
            double cordY = double.Parse(Console.ReadLine());
            Circle circle = new Circle(RAD, cordX, cordY);
            circle.Print();
            circle.coordinate();
            Console.Write("\nВвдите абциссу  _ : ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("\nВвдите ординату _ : ");
            double Y = double.Parse(Console.ReadLine());
            circle.straight(X, Y);
            Console.ReadKey();
        }
    }
}
