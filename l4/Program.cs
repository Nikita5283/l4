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
            int F = Inspector.CheckInt32("Введите элемент F: ");

            int E = Inspector.CheckInt32("Введите элемент E слева и справа от которого нужно вставить элемент F: ");

            int indE = Inspector.CheckInt32("Введите индекс, на который нужно поместить эл-т E: ");
            Collections.Insert(F, E, indE);

            //3.9
            Console.WriteLine("3.9");
            int count_discos = Inspector.CheckInt32("Введите кол-во дискотек: ");
            Collections.Discos(count_discos);

            //4.9
            Console.WriteLine("4.9");
            Collections.Symbols();

            //5.9
            Console.WriteLine("5.9");
            Collections.Admission();
        }
    }
}
