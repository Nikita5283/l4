using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4
{
    internal class Collections
    {

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
                    lst.AddLast(Inspector.CheckInt32("Введите эл-т списка под индексом " + i + ": "));
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


        //3.9
        private static HashSet<string> CreateHashSet(int num_disc)
        {
            HashSet<string> set = new HashSet<string>();
            Console.WriteLine("Введите кол-во студентов дискотеки " + num_disc + ": ");
            int len_set = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < len_set; i++)
            {
                Console.Write("Введите " + (i + 1) + " студента: ");
                set.Add(Console.ReadLine());
            }

            return set;
        }


        public static void Discos(int count_discos)
        {
            //массив множеств дискотек
            HashSet<string>[] discs = new HashSet<string>[count_discos];
            //создание множеств дискотек
            for (int i = 0; i < discs.Length; i++)
            {
                discs[i] = CreateHashSet(i + 1);
            }

            HashSet<string> students = new HashSet<string>();

            //заполнение множества студентов из множеств дискотек
            for (int i = 0; i < discs.Length; i++)
            {
                foreach (string stud in discs[i])
                {
                    students.Add(stud);
                }
                Console.WriteLine();
            }

            //вывод множеств
            for (int i = 0; i < discs.Length; i++)
            {
                Console.Write("Дискотека " + (i + 1) + ": ");
                foreach (string stud in discs[i])
                {
                    Console.Write(stud + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Студенты: ");
            foreach (string stud in students)
            {
                Console.Write(stud + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < discs.Length; i++)
            {
                discs[i].IntersectWith(students);

                if (discs[i].Count == students.Count)
                {
                    Console.WriteLine("На дискотеку " + (i + 1) + " ходили все студенты группы");
                }
                else if (discs[i].Count == 0)
                {
                    Console.WriteLine("На дискотеку " + (i + 1) + " не ходил ни один из студентов группы");
                }
                else if (discs[i] != students)
                {
                    Console.WriteLine("На дискотеку " + (i + 1) + " ходили некоторые студенты группы");
                }

            }

        }

        //4.9
        public static void Symbols()
        {
            Console.WriteLine("Введите текст для записи в файл: ");
            string text = Console.ReadLine();

            using (FileStream stream_write = new FileStream("russian_text.txt", FileMode.Create))
            {
                byte[] text_arr = Encoding.Default.GetBytes(text);
                stream_write.Write(text_arr, 0, text_arr.Length);
            }
            using (FileStream stream_read = File.OpenRead("russian_text.txt"))
            {
                byte[] text_arr = new byte[stream_read.Length];
                stream_read.Read(text_arr, 0, text_arr.Length);

                string textFromFile = Encoding.Default.GetString(text_arr);
                Console.WriteLine("Содержимое файла: " + textFromFile);

                string[] words = textFromFile.Split(new char[] { ' ' });
                SortedSet<char> syms = new SortedSet<char>();

                for (int i = 1; i < words.Length; i += 2)
                {
                    foreach (char sym in words[i])
                    {
                        syms.Add(sym);
                    }
                }

                Console.WriteLine("Символы, которые встречаются хотя бы однажды в словах с чётными номерами: ");
                foreach (char sym in syms)
                {
                    Console.Write(sym + " ");
                }
                Console.WriteLine();

            }
        }

        //5.9
        private static void CreateFileForApplicants()
        {
            Console.WriteLine("Введите кол-во абитуриетов, принимавших участие в тестировании(N): ");
            string N = Console.ReadLine();

            string path = "applicants.txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(N);

                Console.WriteLine("Введите N строк <Фамилия><Имя><Баллы>\n" +
                        "Где <Фамилия> – строка, состоящая не более чем из 20 символов;\n" +
                        "<Имя> – строка, состоящая не более чем из 15 символов,\n" +
                        "<Баллы> – строка, содержащая два целых числа,\nразделенных пробелом – баллы, полученные на тестировании по каждому из трёх предметов." +
                        "При этом <Фамилия> и <Имя>, <Имя> и <Баллы> разделены одним пробелом.\n" +
                        "Пример входной строки:\nРоманов Вельямин 48 39 55");
                for (int i = 0; i < Convert.ToInt32(N); i++)
                {
                    Console.Write("Введите " + (i+1) + " строку: ");
                    string line = Console.ReadLine();
                    writer.WriteLine(line);
                }
                Console.WriteLine();
            }
        }


        public static void Admission()
        {
            CreateFileForApplicants();

            string path = "applicants.txt";

            SortedList<string, string> applicants = new SortedList<string, string>();


            using (StreamReader reader = new StreamReader(path))
            {
                int N = Convert.ToInt32(reader.ReadLine());
                for (int i = 0; i < N; i++)
                {
                    string appl_str = reader.ReadLine();
                    string[] appl_data = appl_str.Split(new char[] { ' ' });
                    applicants.Add(String.Join(" ", appl_data[..2]), String.Join(" ", appl_data[2..]));
                }
            }

            Console.WriteLine("Допущенные к сдаче экзаменов: ");
            foreach (string key in applicants.Keys)
            {
                string points_str = applicants[key];
                string fl = key;
                string[] points = points_str.Split(new char[] { ' ' });
                int sum_points = 0;

                bool failed = false;
                foreach (string point in points)
                {
                    int int_point = Convert.ToInt32(point);
                    if (int_point < 30)
                    {
                        failed = true;
                        break;
                    }
                    sum_points += int_point;
                }

                if (!failed)
                {
                    if (sum_points >= 140) 
                    {
                        Console.WriteLine(key);
                    }
                    
                }


            }

        }
    }
}