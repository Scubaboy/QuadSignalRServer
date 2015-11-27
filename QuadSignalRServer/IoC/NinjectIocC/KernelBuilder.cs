using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadSignalRServer.IoC.NinjectIocC
{
    internal static class KernelBuilder
    {
        public static StandardKernel BuildKernel()
        {
            var kernel = new StandardKernel();

            return kernel;
        }
    }
}
