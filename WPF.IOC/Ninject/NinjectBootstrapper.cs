using Ninject;
using WPF.IOC.MVVM.Ninject;
using WPF.IOC.MVVM.Ninject.Module;
using WPF.IOC.Ninject.Module;

namespace WPF.IOC.Ninject
{
    public class NinjectBootstrapper : INinjectBootstrapper
    {
        public NinjectBootstrapper()
        {
            Kernel = new StandardKernel();
        }

        public void LoadModules()
        {
            // Services
            Kernel.Load(new ServiceModule());

            // Windows
            Kernel.Load(new WindowModule());
        }

        public IKernel Kernel { get; set; }
    }
}
