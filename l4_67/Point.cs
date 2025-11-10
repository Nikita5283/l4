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
            Console.WriteLine("Координаты x и y уменьшены на 1: ");
            return new Point(--point._x, --point._y);
        }

        public static Point operator -(Point point)
        {
            Console.WriteLine("Координаты x и y переставлены: ");
            return new Point(point._y, point._x);
        }

        public static implicit operator int(Point p)
        {
            Console.Write("Целая часть координаты x: ");
            return (int)p._x;
        }

        public static explicit operator double(Point p)
        {
            Console.Write("Координата y: ");
            return (double)p._y;
        }

        public static Point operator -(Point p, int num)
        {
            Console.WriteLine("Координата x уменьшена на введенное число: ");
            return new Point(p._x - num, p._y);
        }

        public static Point operator -(int num, Point p)
        {
            Console.WriteLine("Координата y уменьшена на введенное число: ");
            return new Point(p._x, p._y - num);
        }

        public static double operator -(Point p1, Point p2)
        {
            double dx = p1._x - p2._x;
            double dy = p1._y - p2._y;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            Console.Write($"Расстояние между точкой с координатами x = {p1._x}; y = {p1._y} и точкой " +
                $"с координатами  x = {p2._x}; y = {p2._y}: ");
            return distance;
        }

        public override string ToString()
        {
            return "Координаты точки: x = " + _x + "; y = " + _y;
        }

    }
}
