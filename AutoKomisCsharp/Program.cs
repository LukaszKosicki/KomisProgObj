using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKomisCsharp
{
    class Program
    {
        class A
        {
            private char V() { return 'A'; }
            virtual public void Echo1() { Console.Write(V()); }
            public void Echo2() { Console.Write(V()); }
        }
        class B : A
        {
            private char V() { return 'B'; }
            override public void Echo1() { Console.Write(V()); }
        }
        class C : B
        {
            private char V() { return 'C'; }
        }
        static void Main(string[] args)
        {
            A a = new A(); a.Echo1();
            B b = new B(); b.Echo1();
            C c = new C(); c.Echo1();
            A a1 = b; a1.Echo1(); a1.Echo2();
            a1 = c; a1.Echo1(); a1.Echo2();

            Console.ReadKey();
        }
    }
}
