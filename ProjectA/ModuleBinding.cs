using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Package1;

namespace ProjectA
{
    public class ModuleBinding : NinjectModule
    {
        public override void Load()
        {

            Bind<IInterfaceSomething>().To<ClassM>();//jb,jandkjs

        }
    }
}
