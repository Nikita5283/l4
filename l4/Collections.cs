using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4
{
    internal class Collections
    {
        //общий метод вывода коллекций

        //1.9
        //без метода Reverse
        private static List<int> CreateList()
        {
            Console.Write("Введите длину списка: ");
            int len_list = Convert.ToInt32(Console.ReadLine());
            List<int> lst = new List<int>();

            for (int i = 0; i < len_list; i++)
            {
                Console.Write("Введите эл-т списка под индексом " + i + ": ");
                lst.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return lst;
        }

        public static void ReverseList()
        {
            List<int> L = CreateList();

            Console.WriteLine("Исходный список:");
            foreach (int num in L)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            List<int> L_copy = new List<int>(L);
            int ind_rev = 0;

            for (int i = L.Count - 1; i >= 0; i--)
            {
                L[ind_rev++] = L_copy[i];
            }

            Console.WriteLine("Перевернутый список:");
            foreach (int num in L)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        //с методом Reverse
        //public static void RevList()
        //{
        //    List<int> list = CreateList();
        //    Console.WriteLine("Исходный список:");
        //    foreach (int num in list)
        //    {
        //        Console.Write(num + " ");
        //    }
        //    Console.WriteLine();

        //    list.Reverse();

        //    Console.WriteLine("Перевернутый список:");
        //    foreach (int num in list)
        //    {
        //        Console.Write(num + " ");
        //    }
        //    Console.WriteLine();
        //}

        //2.9
        private static LinkedList<int> CreateLinkedList(int E, int indE)
        {
            Console.Write("Введите длину списка: ");
            int len_list = Convert.ToInt32(Console.ReadLine());
            LinkedList<int> lst = new LinkedList<int>();

            for (int i = 0; i < len_list; i++)
            {
                if (i == indE)
                {
                    var node = lst.First;
                    for (int j = 0; j < indE - 1; j++)
                        node = node.Next;

                    lst.AddBefore(node, E);
                    Console.WriteLine("По индексу " + indE + " вставлен эл-т E: " + E);
                }
                else 
                {
                    Console.Write("Введите эл-т списка под индексом " + i + ": ");
                    lst.AddLast(Convert.ToInt32(Console.ReadLine()));
                }

            }

            return lst;
        }

        public static void Insert(int F, int E, int indE)
        {
            LinkedList<int> list = CreateLinkedList(E, indE);

            Console.WriteLine("Исходный список L: ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var current = list.First;
            for (int i = 1; i <= indE; i++)
            {
                if (i == indE)
                {
                    list.AddBefore(current, F);
                    list.AddAfter(current, F);
                    break;
                }
                current = current.Next;
            }

            Console.WriteLine("Итоговый список L: ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
