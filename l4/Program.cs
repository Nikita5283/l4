namespace l4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.9
            Console.WriteLine("1.9");
            Collections.ReverseList();

            //Collections.RevList();

            //2.9
            Console.WriteLine("2.9");
            Console.WriteLine("Введите элемент F: ");
            int F = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элемент E слева и справа от которого нужно вставить элемент F: ");
            int E = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите индекс, на который нужно поместить эл-т E");
            int indE = Convert.ToInt32(Console.ReadLine());
            Collections.Insert(F, E, indE);
        }
    }
}
