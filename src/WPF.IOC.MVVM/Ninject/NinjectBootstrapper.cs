using Ninject;
using WPF.IOC.MVVM.Ninject.Module;

namespace WPF.IOC.MVVM.Ninject
{
    public class NinjectBootstrapper : INinjectBootstrapper
    {
        public NinjectBootstrapper()
        {
            Kernel = new StandardKernel();
        }

        public void LoadModules()
        {
            //Services
            Kernel.Load(new ServiceModule());
            // ViewModels
            Kernel.Load(new ViewModelModule());
        }

        public IKernel Kernel { get; set; }
    }
}
