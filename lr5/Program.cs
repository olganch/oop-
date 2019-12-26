using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public interface A
    {
        void mIA();
        int fIA();
    }

    public class B : A
    {
        public int b;
        public B()
        {
            Console.WriteLine(" constructor B ()");
            this.b = 88;
        }
        public B(int b)
        {
            Console.WriteLine(" constructor B (int b) ");
            this.b = b;
        }

        public int fAS() { return this.b; }

        public void mIA() { }
        public int fIA() { return 10; }

    }

    public class K: B
    {
        public int z;
        public K() { this.z = this.fAS(); }

        public K(int k, int z) : base(k)
        {
            Console.WriteLine(" constructor K");
            this.z = z;
        }

        public int fIC() { return 66; }
        public void mIC() { this.z = this.fIA() + this.fIC(); }
    }

    public class D : B
    {
        public int z;
        public D() { this.z = this.fAS(); }

        public D(int b, int z) : base(b)
        {
            Console.WriteLine(" constructor D");
            this.z = z;
        }

        public int fIC() { return 77; }
        public void mIC() { this.z = this.fIA() + this.fIC(); }
    }

    public class E : B
    {
        public int z;

        public E() { this.z = this.fAS(); }

        public E(int e, int z) : base(e)
        {
            Console.WriteLine(" constructor E");
            this.z = z;
        }

        public int fIE() { return 88; }
        public void mIE() { this.z = this.fIA() + this.fIE(); }
    }

    public interface J : A
    {
        int fIJ();
        void mIJ();
    }

    public class C : J, A
    {
        public int c;
        public C()
        {
            Console.WriteLine(" constructor C ()");
            this.c = 88;
        }
        public C(int b)
        {
            Console.WriteLine(" constructor C(int c) ");
        }

        public int fJS() { return this.c; }

        public void mIJ() { }
        public int fIJ() { return 10; }

        public int fAS() { return this.c; }

        public void mIA() { }
        public int fIA() { return 10; }
    }

    public class F : B
    {
        public int z;

        public F() { this.z = this.fAS(); }

        public F(int f, int z) : base(f)
        {
            Console.WriteLine(" constructor F");
            this.z = z;
        }

        public int fIC() { return 88; }
        public void mIC() { this.z = this.fIA() + this.fIC(); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = null;
            a = new B();
            Console.WriteLine(" B a.fIA() = {0}", a.fIA());

            J j = null;
            j = new C();
            Console.WriteLine(" C j.fIJ() = {0}", j.fIJ() + j.fIJ());
            Console.WriteLine(" C j.fIA() = {0}", j.fIA());

            F cf = new F();

            K bk = new K();
            D bd = new D();
            E be = new E();

            
            Console.ReadKey();
        }
    }
}