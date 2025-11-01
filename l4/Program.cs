namespace l4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.9
            Console.WriteLine("1.9");
            Console.Write("Введите длину списка: ");
            int len_list = Convert.ToInt32(Console.ReadLine());
            List<int> lst = new List<int>();

            for (int i = 0; i < len_list; i++)
            {
                Console.Write("Введите эл-т списка под индексом " + i + ": ");
                lst.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Collections col1 = new Collections(lst);
            col1.ReverseList();

            //col1.RevList();

        }
    }
}
