using Ninject;
using Package1;
using Package2;
using Package3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new ModuleBinding());

            ClassA a = new ClassA();
            a.Method1();
            a.Method2(); // hello world
            a.Method3();//fswefwf

            ClassB b = new ClassB();
            b.Method1();
            b.Method2();
            b.Method3();

            ClassD d = new ClassD(a);
            d.Method1();

            ClassE e = new ClassE();
            e.Method2();
            e.Method5();

            ClassH h = new ClassH();
            h.Method2();

            ClassJ j = new ClassJ();
            j.Method1();

            ClassK k = new ClassK();
            k.Method1();

            ClassM m = new ClassM();
            m.Method2();
            m.Method3();
            m.Method7();
            m.Method8();

            ClassN n = new ClassN();
            n.Method3();

            ClassO o = new ClassO();
            o.Method2();

            ClassP p = new ClassP();
            p.Method10();
            p.Method2();
            p.Method9();

            ClassL l = new ClassL(p);
            l.Method1();

            ClassQ q = new ClassQ();
            q.Method3();

            ClassR r = new ClassR();
            r.Method1();

            ClassS s = new ClassS();
            s.Method1();
            s.Method2();
            s.Method3();

            ClassT t = new ClassT(e);
            t.Method2();

            ClassU u = new ClassU();
            u.Mehthod1();

            ClassV v = new ClassV();
            v.Method2();

            ClassW w = new ClassW(kernel.Get <IInterfaceSomething>());
            w.Method2();
            w.Method3();

            ClassX x = new ClassX();
            x.Method1();

            ClassY y = new ClassY();
            y.Method2();

            ClassZ z = new ClassZ();
            z.Method2();
        }
    }
}
