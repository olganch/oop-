using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace lab_8
    {
        public class A<T>
        {
            public T a { get; set; }
            public A() { a = default(T); }
            public A(T _a) { a = _a; }

            public void m() { Console.WriteLine(this.a); }
        }

        class Program
        {
            public static void Swap<T>(T a, T b)
            {
                T c = a;
                a = b;
                b = c;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }

            static void Main(string[] args)
            {
                A<string> e = new A<string>("Hi");
                e.m();
                A<int> e2 = new A<int>(45);
                e2.m();
                Swap<string>("Yes", "No");
                Console.ReadLine();
            }
        }
    }