using System;
using System.Collections.Generic;

namespace lab_14
{
    class K
    {
        public void mK() { Console.WriteLine(" method of K"); }
    }
    class D
    {
        public void mD() { Console.WriteLine(" method of D"); }
    }
    class E
    {
        public void mE() { Console.WriteLine(" method of E"); }
    }
    class F
    {
        public void mF() { Console.WriteLine(" method of F"); }
    }

    class C
    {
        public C(F f)
        {
            this.f = f;
        }

        public void mC() { Console.WriteLine(" method of C"); }

        public F fA
        {
            set { Console.WriteLine("set f"); f = value; }
            get { Console.Write("get f -> "); return f; }
        }

        private F f = null;
    }

    class J
    {
        public J(C c)
        {
            this.c = c;
        }

        public void mJ() { Console.WriteLine(" method of J"); }

        public C cA
        {
            set { Console.WriteLine("set c"); c = value; }
            get { Console.Write("get c -> "); return c; }
        }

        private C c = null;
    }

    class B
    {
        public B(K k, D d, E e)
        {
            this.k = k;
            this.d = d;
            this.e = e;
        }

        public void mB() { Console.WriteLine("  method of B"); }

        public K kA
        {
            set { Console.WriteLine("set k"); k = value; }
            get { Console.Write("get k -> "); return k; }
        }
        public D dA
        {
            set { Console.WriteLine("set d"); d = value; }
            get { Console.Write("get d -> "); return d; }
        }
        public E eA
        {
            set { Console.WriteLine("set e"); e = value; }
            get { Console.Write("get e ->"); return e; }
        }

        private K k = null;
        private D d = null;
        private E e = null;

    }

    class A
    {
        public A(B b, J j)
        {
            this.b = b;
            this.j = j;
        }

        public void mA() { Console.WriteLine("method of A"); }

        public B bA
        {
            set { Console.WriteLine("set b"); b = value; }
            get { Console.Write("get b ->"); return b; }
        }
        public C cA
        {
            set { Console.WriteLine("set c"); c = value; }
            get { Console.Write("get c ->"); return c; }
        }
        public J jA
        {
            set { Console.WriteLine("set j"); j = value; }
            get { Console.Write("get j ->"); return j; }
        }

        private B b = null;
        private C c = null;
        private J j = null;
    }

    class Program
    {
        static void Main()
        {
            K k = new K();
            D d = new D();
            E e = new E();
            F f = new F();

            C c = new C(f);

            J j = new J(c);
            B b = new B(k, d, e);

            A a = new A(b, j);

            a.mA();

            a.jA.cA.fA.mF();

            a.bA.kA.mK();
            a.bA.dA.mD();
            a.bA.eA.mE();

            Console.ReadKey();

        }
    }
}



/*interface ITreeElement<T> where T: class, new()
{
    T GetData();
    IEnumerable<ITreeElement<T>> Children { get; }
}*/
