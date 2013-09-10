using Ninject;
using WPF.IOC.MVVM.Ninject.Module;

namespace WPF.IOC.MVVM.Ninject
{
    public class DesignTimeNinjectBootstrapper : INinjectBootstrapper
    {
        public IKernel Kernel { get; set; }

        public DesignTimeNinjectBootstrapper()
        {
            Kernel = new StandardKernel();
        }

        public void LoadModules()
        {
            // Load Services
            Kernel.Load(new ServiceModule());
            // Load ViewModels
            Kernel.Load(new DesignViewModelModule());
        }
    }
}
