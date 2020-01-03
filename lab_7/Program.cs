using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class D
    {
        private int a;
        public D() { a = 2; }
        public D(int _a) { a = _a; }
        ~D() { }
        public int get_value() { return a; }
    }

    static class C
    {  
        public static int get_value() { return 11; }
    }

    class E 
    {
        private int b;
        public E() { b = 10; }
        public E(int _b) { b = _b; }
        ~E() { }
        public void act(D d)
        {
            Console.WriteLine("Server Method");
            Console.WriteLine("Server b = {0} and Client a = {1}", b, d.get_value());
        }
        public void utility() { Console.WriteLine("Class C utility f {0}", C.get_value()); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            D client = new D(5);
            E server = new E(15);
            server.act(client);
            server.utility();
            Console.ReadLine();
        }
    }
}