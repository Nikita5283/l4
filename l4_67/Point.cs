using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4_67
{
    internal class Point
    {
        private double _x, _y;

        public Point(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        public double Interval()
        {
            Console.Write("Расстояние от точки до начала координат: ");
            return Math.Sqrt(_x * _x + _y * _y);
        }

        public static Point operator --(Point point)
        {
            Console.WriteLine("Координаты x и y уменьшены на 1");
            return new Point(--point._x, --point._y);
        }

        public static Point operator -(Point point)
        {
            Console.WriteLine("Координаты x и y переставлены");
            return new Point(point._y, point._x);
        }

        public static implicit operator int(Point p)
        {
            Console.Write("Целая часть координаты x: ");
            return (int)p._x;
        }

        public static explicit operator double(Point p)
        {
            Console.Write("Ккоордината y: ");
            return (double)p._y;
        }

        public override string ToString()
        {
            return "Координаты точки: x = " + _x + " y = " + _y;
        }

    }
}
