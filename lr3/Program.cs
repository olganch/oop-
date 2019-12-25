using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_Substitution
{
    public class A
    {
        public A() { Console.WriteLine("constructor A"); this.size = 88; }
        ~A() { Console.WriteLine("destructor ~A ");
            System.Threading.Thread.Sleep(1000); }
        protected int size { set; get; }
        public virtual int fm() { return this.size + 22; }
    }

    public class B : A
    {
        public B() { Console.WriteLine("constructor B "); this.size = 11; }
        ~B() { Console.WriteLine("destructor ~B "); }
        public override int fm() { return this.size + 1; }
    }

    public class J : A
    {
        public J() { Console.WriteLine("constructor J "); this.size = 1; }
        ~J() { Console.WriteLine("destructor ~J "); }
        public override int fm() { return this.size + 1; }
    }

    public class C : J
    {
        public C() { Console.WriteLine("constructor C "); this.size = 1; }
        ~C() { Console.WriteLine("destructor ~C "); }
        public override int fm() { return this.size + 1; }
    }

    public class F : C
    {
        public F() { Console.WriteLine("constructor F "); this.size = 1; }
        ~F() { Console.WriteLine("destructor ~F "); }
        public override int fm() { return this.size + 1; }
    }

    public class Bb : B
    {
        public Bb( char children ) {
            Console.WriteLine($"constructor of children {children}");
            this.size = 1;
        }

        ~Bb() { Console.WriteLine("destructor ~F "); }
        public override int fm() { return this.size + 1; }
    }

    class Program
    {
        static void Main( )
        {
            A a = new A();
            Console.WriteLine(" a.fm()  = {0}", a.fm());

            a = new B();
            Console.WriteLine(" a.fm()  = {0}", a.fm());

            a = new J();
            Console.WriteLine(" a.fm()  = {0}", a.fm());

            a = new C();
            Console.WriteLine(" a.fm()  = {0}", a.fm());

            a = new F();
            Console.WriteLine(" a.fm()  = {0}", a.fm());

            Bb bbK = new Bb('K');
            Bb bbD = new Bb('D');
            Bb bbE = new Bb('E');

            if (a is F)
            {
                Console.WriteLine(" a is F");
            }

            Console.ReadKey();
        }
    }
}