using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4
{
    internal class Collections
    {
        private List<int> list;

        public Collections(List<int> list)
        {
            this.list = list; 
        }

        //без метода Reverse
        public void ReverseList()
        {
            Console.WriteLine("Исходный список:");
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            List<int> list_copy = new List<int>(list);
            int ind_rev = 0;

            for (int i = list.Count - 1; i >= 0; i--)
            {
                list[ind_rev++] = list_copy[i];
            }

            Console.WriteLine("Перевернутый список:");
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        //с методом Reverse
        //public void RevList()
        //{
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


    }
}
