using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {


        public static String Test(string s)
        {
            if (String.IsNullOrEmpty(s))
                return "null или пустая";
            else
                return String.Format("(\"{0}\") не null или пустая", s);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Task1();
            Console.WriteLine("Task 2");
            Task2();
            Console.WriteLine("Task 3");
            Task3();
            Console.WriteLine("Task 4");
            Task4();
            Console.WriteLine("Task 5");
            Console.WriteLine("Введите массив");
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            var tup = Task5(num, s);
            Console.WriteLine("Минимальный элемент " + tup.Item1 + " Максимальный " + tup.Item2 + " Их сумма " + tup.Item3 + " Первая Буква " + tup.Item4);

        }

        static void Task1()
        {
            Console.WriteLine("Инициализация примитивных переменных");
            sbyte a = -128; //127
            byte c = 255; // 0 - 255
            int b = 2147483647; //–2 147 483 648
            short d = 32767; //-32766
            long e = -9223372036854775808; //9 223 372 036 854 775 807
            ushort f = 65535; // 0 - 65535
            uint g = 4294967295;  // 0 -
            ulong h = 18446744073709551615; // 0 -
            char ch1 = 'a';
            bool q = true;
            float fl = 123;
            double db = 12345.4444;
            decimal dc = 12321412312323423423;


            //неявное приведение
            Int16 i16 = 32333;
            Int32 i32 = i16;
            Double dd = i32;
            Single ss = i16;
            long lg = i16;
            short st = i16;

            //явное приведение
            a = (sbyte)c;
            c = (byte)fl;
            dd = (double)dc;
            dc = (decimal)fl;
            d = (short)g;

            //упаковка-распаковка
            int x = 10; //упкаовка
            Object obj = x; //ссылка на упакованный объект
            byte bbb = (byte)(int)obj; //распаковка и приведение типа

            //работа с неявно типизированной переменной
            var mv1 = new[] { 'a', 'b', 'c' };
            Console.WriteLine(mv1.GetType());

            var mv2 = new[] { 123, 1.654, 1 };
            Console.WriteLine(mv2.GetType());

            var mv3 = new List<int>
                (new int[] { 1, 2, 3, 4, 5, 6, 7, 544354, 3453, 45345, 34, 53, 45 });
            Console.WriteLine(mv3.GetType());

            //NULLABLE
            int? nl1 = null;
            int? nl2 = null;
            Console.Write("x1 = x2? "); System.Console.WriteLine(nl1 == nl2);

            int? xx1 = null;
            if (xx1.HasValue)
            {
                int xx2 = (int)x; //явное
                int? xx3 = xx1; //неявное
                long? xx4 = xx2; //неявное расширяющее
            }
        }

        static void Task2()
        {
            Console.WriteLine("Строки ");
            string str1 = "Hello ";
            string str2 = "World";
            string str3 = "! ";
            string str4 = "Hello ";
            string strO = "";
            Console.WriteLine("Равны: " + (str1 == str2));
            Console.WriteLine("Равны: " + (str1 == str4));
            strO = str1 + str2 + str3 + str4;
            Console.WriteLine("Сцепление всех строк: " + strO);
            string CPY = str4;
            Console.WriteLine("Копирование: " + CPY);
            string stri = str4.Substring(1, 3);
            Console.WriteLine("Выделение подстроки: " + stri);

            string lett = "Hello! my name is: Vladislav";
            char[] del = ".,:;!?\n\xD\xA\' ' ".ToCharArray();
            string[] words = lett.Split(del);
            foreach (string www in words)
                Console.WriteLine(www);
            Console.WriteLine();

            Console.WriteLine("Вставка подстроки на 6 позицию " + str4.Insert(5, stri));

            Console.WriteLine();
            string fullstr = "Hello! my name is: Vladislav";
            Console.Write("Введите подстроку: ");
            string substr = Console.ReadLine();
            int nnnn = fullstr.IndexOf(substr);
            fullstr = fullstr.Remove(nnnn, substr.Length);
            Console.WriteLine(" " + fullstr);

            Console.WriteLine();
            string s1 = "abcd";
            string s2 = "";
            string s3 = null;

            Console.WriteLine("String s1 {0}.", Test(s1));
            Console.WriteLine("String s2 {0}.", Test(s2));
            Console.WriteLine("String s3 {0}.", Test(s3));



            StringBuilder sb = new StringBuilder("Привет мир");

            sb.Remove(0, 3);
            sb.Append("!");
            sb.Insert(0, "C");
            Console.WriteLine(sb);
        }

        static void Task3()
        {
            int[][] array = { new int[3] { 1, 2, 3 }, new int[3] { 28, 16, 34 }, new int[3] { 21, 22, 33 } };
            foreach (int[] x in array)
            {
                foreach (int b in x)
                    Console.WriteLine("\t" + b);
                Console.WriteLine();
            }
            string[] str = new string[] { "Hello", "Im", "Vlad" };
            foreach (string b in str)
                Console.WriteLine("\t" + b);
            Console.WriteLine("длина: " + str.Length);

            Console.WriteLine("Введите значение");
            string value = Console.ReadLine();
            Console.WriteLine("Введите позицию");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                if (num == i)
                {
                    str[num] = value;

                }
                Console.WriteLine(str[i]);
            }


            int[][] abc = new int[3][];
            abc[0] = new int[1];
            abc[1] = new int[2];
            abc[2] = new int[3];
            Console.WriteLine("\nВведите элемент заполнения массива");
            double[][] c = { new double[1], new double[2], new double[3] };
            int n = 2;
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[][] с = new int[5][];
            for (int i = 0; i < abc.Length; i++)
            {
                с[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    с[i][j] = k;
                    Console.Write("{0} ", с[i][j]);
                }
                Console.WriteLine();
                n++;
            }

            var arra = new object[0];
            var sstr = "";

        }

        static void Task4()
        {
            var myTup = Tuple.Create<int, string, char, string, ushort>(123, "asdasda", 's', "four", 123);
            Console.WriteLine(myTup.Item1 + " " + myTup.Item2 + " " + myTup.Item3 + " " + myTup.Item4 + " " + myTup.Item5);
            Console.WriteLine();
            Console.WriteLine(myTup.Item1 + " " + myTup.Item3 + " " + myTup.Item4);
            int acl = myTup.Item1;
            string av = myTup.Item2;
            char cl = myTup.Item3;
            string vbh = myTup.Item4;
            ushort nnn = myTup.Item5;
            var myTup2 = Tuple.Create<int, string, char, string, ushort>(123, "VladIslav", 's', "four", 123);
            Console.WriteLine();
            Console.WriteLine(myTup.Equals(myTup2));
        }

        static Tuple<int, int, int, string> Task5(int[] num, string s)
        {
            int min = num[0];
            int max = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
            }

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
            }

            int sum = max + min;
            string firstLetter = s.Substring(0, 1);

            return Tuple.Create<int, int, int, string>(min, max, sum, firstLetter);
        }
    }

}
