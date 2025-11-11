using System.Globalization;

namespace l4_67
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double x = Inspector.CheckDouble("Введите координату x(double): ");
            double y = Inspector.CheckDouble("Введите координату y(double): ");

            Point point = new Point(x, y);

            Console.WriteLine(point.ToString());
            Console.WriteLine(point.Interval());

            // Унарные операции
            // Операция --
            point = --point;
            Console.WriteLine(point.ToString());

            // Операция -
            point = -point;
            Console.WriteLine(point.ToString());

            // Операции приведения типа
            // Неявное приведение к Int
            int x_int = point;
            Console.WriteLine(x_int);

            // Явное приведение к Double
            double y_double = (double)point;
            Console.WriteLine(y_double);
            

            // Бинарные операции
            // – Point p, целое число (левосторонняя операция, уменьшается координата х)
            //Point point_leftx = new Point(x, y);
            int num1 = Inspector.CheckInt32("Введите целое число на которое нужно уменьшить координату x: ");
            point = point - num1;
            Console.WriteLine(point.ToString());

            // – целое число, Point p (правосторонняя операция, уменьшается координата y)
            int num2 = Inspector.CheckInt32("Введите целое число на которое нужно уменьшить координату y: ");
            point = num2 - point;
            Console.WriteLine(point.ToString());


            // – Point p – вычисляется расстояние до точки p, результатом должно быть вещественное число.
            Console.WriteLine(point.ToString());
            double x2 = Inspector.CheckDouble("Введите координату x2(double): ");
            double y2 = Inspector.CheckDouble("Введите координату y2(double): ");
            Console.WriteLine();

            Point point2 = new Point(x2, y2);
            Console.WriteLine((point - point2).ToString());

            
        }
    }
}
