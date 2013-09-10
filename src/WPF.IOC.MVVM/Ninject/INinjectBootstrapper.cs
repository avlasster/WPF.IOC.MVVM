using Ninject;

namespace WPF.IOC.MVVM.Ninject
{
    public interface INinjectBootstrapper
    {
        IKernel Kernel { get; set; }

        void LoadModules();
    }
}
