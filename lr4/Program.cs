using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{

	public interface J
	{
		void mJ();
		int fJ();
	}

	public class A : J
	{
		public A() { this.size = 22; this.color = 77; }
		protected int size { set; get; }
		public int color { set; get; }
		public virtual int f()

		{
			Console.WriteLine(" class A f() ");
			return 99;
		}

		public void mJ() { this.size = this.size * this.color; }
		public int fJ() { return this.color + 555; }
	}

	public class B : A
	{
		public B() { this.speed = 33; }
		public int speed { set; get; }

		public override int f()
		{
			Console.WriteLine(" class B f() ");
			return base.f() + 1;
		}
	}

	public class E : A
	{
	
		public int f1()
		{
			Console.WriteLine(" class E f1() ");
			return base.f() + 1;
		}

	}


	public abstract class D : J
	{
		public void mD(int a) { this.a = a; }
		public abstract int fD();
		public void mJ() { this.a = 55; }
		public int fJ() { return this.a; }

		private int a = 22;
	}

	public class L : D
	{
		public L() { }
		~L() { }
		public override int fD() { return 0; }
	}

	public class F : D
	{
		public override int fD()
		{
			Console.WriteLine(" not use");
			return 0;
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			J j = new A();

			A a = new A();
			Console.WriteLine(" class A a.f() {0}", a.f());
			Console.WriteLine(" class A color {0}", a.color);
			j.mJ();
			Console.WriteLine(" interface J fJ() {0}", j.fJ());

			a = new B();

			j = a;

			Console.WriteLine(" class B a.f() {0}", a.f());
			Console.WriteLine(" class B color {0}", a.color);
			Console.WriteLine(" class B speed {0}", ((B)a).speed);

			a = new E();

			j = a;
			// по функция 
			Console.WriteLine(" class E a.f() {0}", a.f());
			Console.WriteLine(" class A  (E)a.f1() {0}", ((E)a).f1());
			a.mJ();
			Console.WriteLine(" class A  (E)a.f1() {0} ", a.fJ());
			E e = new E();
			Console.WriteLine(" class E e.f1() {0}", e.f1());
			D d = null;
			d = new L();
			Console.WriteLine(" class D d.fD() {0}", d.fD());

			Console.ReadKey();

		}
	}
}