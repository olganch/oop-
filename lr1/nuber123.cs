using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//три функции, не возвращающие значения

namespace Lab_1
{
    class Program
    {
        public static void Hello()
        {
            Console.WriteLine("Hello World!");
        }
        public static void Morning()
        {
            Console.WriteLine("Good morning!");
        }
        public static void Afternoon()
        {
            Console.WriteLine("Good afternoon!");
        }

        int Summa(int x, int y)
        {
            int z = x + y;
            return z;
        }

        static Program S = new Program();
        static void Main(string[] args)
        {
            int a = 9, b = 5;
            Hello();
            Morning();
            Afternoon();
            Console.WriteLine("Summa = {0}", S.Summa(a, b));

            Console.ReadKey();
        }
    }
}
