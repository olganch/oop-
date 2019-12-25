using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class D
    {
        public void mD() { Console.WriteLine("method of D"); }
    }

    class E
    {
        public void mE() { Console.WriteLine("method of E"); }
    }

    class F
    {
        public void mF() { Console.WriteLine("method of F"); }
    }

    class K
    {
        public void mK() { Console.WriteLine("method of K"); }
    }

    class A
    {
        public void mA() { Console.WriteLine("method of A"); }

        public B bA { get { Console.Write("get b ->"); return b; } }
        public J jA { get { Console.Write("get j ->"); return j; } }

        private B b = new B();
        private J j = new J();
    }

    class B
    { 
        public void mB() { Console.WriteLine("method of B"); }

        public K kA { get { Console.Write("get k -> "); return k; } }
        public D dA { get { Console.Write("get d -> "); return d; } }
        public E eA { get { Console.Write("get e ->"); return e; } }

        private K k = new K();
        private D d = new D();
        private E e = new E();
    }

    class J
    {
        public void mC() { Console.WriteLine("method of J"); }

        public C cA
        {
            get { Console.Write("get c ->"); return c; }
        }

        private C c = new C();
    }

    class C
    {
        public void mC() { Console.WriteLine("method of C"); }

        public F fA
        {
            get { Console.Write("get f ->"); return f; }
        }

        private F f = new F();
    }

    class Program
    {
        static void Main()
        {
            A a = new A();

            a.mA();

            a.bA.kA.mK();
            a.bA.dA.mD();
            a.bA.eA.mE();

            a.jA.cA.fA.mF();

            Console.ReadKey();
        }
    }
}