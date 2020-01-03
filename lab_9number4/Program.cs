using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_4_Contravariant
{
    // Contravariant interface.
    interface IContravariant<in A> { }

    // Extending contravariant interface.
    interface IExtContravariant<in A> : IContravariant<A> { }

    // Implementing contravariant interface.
    class Sample<A> : IContravariant<A> { }

    class Program
    {
        static void Main()
        {
            IContravariant<Object> iobj = new Sample<Object>();
            IContravariant<String> istr = new Sample<String>();

            // You can assign iobj to istr because
            // the IContravariant interface is contravariant.
            istr = iobj;

            Console.ReadKey();
        }
    }
}