using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Circle
    {
        double _cordX; // Абцисса центра 
        double _cordY; // Ордината центра
        double _RAD; // Радиус
        double _X; // Абцисса произвольной точки
        double _Y; // Ордината произвольной точки
        public double length; // Автовычесляемое поле длины окружности
        public double area; // Автовычесляемое поле площади окружности
        public Circle(double RAD, double cordX, double cordY)
        {
            _cordX = cordX;
            _cordY = cordY;
            _RAD = RAD;
            area = Math.PI * Math.Pow(_RAD, 2);
            length = 2 * Math.PI * (_RAD);
        }
        public void coordinate() // Непараметризтрованный метод, определяющий пересекает ли заданная окружность оси координат
        {
            int coordinate; // Оси координат
            if (Math.Sqrt(Math.Pow(_cordX, 2) + Math.Pow(_cordY, 2)) == _RAD)
                Console.WriteLine("Заданная окружность пересекает оси координат", coordinate);
            else Console.WriteLine("Заданная окружность НЕ пересекает оси координат", coordinate);
        }
        public void straight(double X, double Y)// Параметризированный метод, определяющий длину отрезка, отсекаемого окружностью от заданной прямой 
    {
        _X = X;
        _Y=Y;
        if (Math.Sqrt(Math.Pow(_cordX - X, 2) + Math.Pow(_cordY - Y, 2)) <= _RAD)
            Console.WriteLine("\nОтрезок пересекается с окржностью");
            else Console.WriteLine("\nОтрезок НЕ пересекается с окржностью");
               }
    public void Print()
{
 Console.WriteLine("\nДлина окружности равна :{0:g5}", length);
 Console.WriteLine();
 Console.WriteLine("Площадь окружности равна : {0:g5}", area);
    Console.WriteLine();
        }
    }
}