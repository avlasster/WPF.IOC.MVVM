using Ninject.Modules;
using WPF.IOC.MVVM.Service;
using WPF.IOC.MVVM.Service.Architecture;

namespace WPF.IOC.MVVM.Ninject.Module
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMainService>().To<MainService>();
        }

    }
}
