namespace l4_67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите координату x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату y: ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Point point = new Point(x, y);

                Console.WriteLine(point.ToString()); // Метод ToString
                Console.WriteLine(point.Interval());

                // Унарные операции
                // Операция --
                Point point_lower = new Point(x, y);
                point = --point_lower;
                Console.WriteLine(point.ToString());

                // Операция -
                Point point_change = new Point(x, y);
                point = -point_change;
                Console.WriteLine(point.ToString());

                // Операции приведения типа
                // Неявное приведение к Int
                Point point_type = new Point(x, y);
                int x_int = point_type;
                Console.WriteLine(x_int);

                // Явное приведение к Double
                double y_double = (double)point_type;
                Console.WriteLine(y_double);

                // Бинарные операции
                // – Point p, целое число (левосторонняя операция, уменьшается координата х)
                Point point_leftx = new Point(x, y);
                int 
                point = 

                // – целое число, Point p (правосторонняя операция, уменьшается координата y)


                //– Point p – вычисляется расстояние до точки p, результатом должно быть вещественное число.

            }
            catch
            {
                Console.WriteLine("Неверный тип данных! Должен быть double");
            }
        }
    }
}
