namespace l4_67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;

            try
            {
                Console.Write("Введите координату x: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату y: ");
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

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

            }
            catch
            {
                Console.WriteLine("Неверный тип данных! Должен быть double");
            }

            

            // Бинарные операции
            // – Point p, целое число (левосторонняя операция, уменьшается координата х)
            //Point point_leftx = new Point(x, y);
            try 
            {
                Point point = new Point(x, y);
                Console.WriteLine("Создана новая точка с координатами x, y:");
                Console.WriteLine(point.ToString());
                Console.Write("Введите целое число на которое нужно уменьшить координату x: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                point = point - num1;
                Console.WriteLine(point.ToString());

                // – целое число, Point p (правосторонняя операция, уменьшается координата y)
                Console.Write("Введите целое число на которое нужно уменьшить координату y: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                point = num2 - point;
                Console.WriteLine(point.ToString());
            }
            catch
            {
                Console.WriteLine("Неверный тип данных! Должен быть int");
            }



            // – Point p – вычисляется расстояние до точки p, результатом должно быть вещественное число.
            try
            {
                Point point = new Point(x, y);
                Console.WriteLine("Создана новая точка с координатами x, y:");
                Console.WriteLine(point.ToString());
                Console.Write("Введите координату x2: ");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату y2: ");
                double y2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Point point2 = new Point(x2, y2);
                Console.WriteLine((point - point2).ToString());
            }
            catch 
            { 
                Console.WriteLine("Неверный тип данных! Должен быть int");
            }

            
        }
    }
}
