using Ninject.Modules;
using WPF.IOC.MVVM.ViewModel;
using WPF.IOC.MVVM.ViewModel.Architecture;

namespace WPF.IOC.MVVM.Ninject.Module
{
    public class DesignViewModelModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMainViewModel>().To<DesignTimeMainViewModel>();
        }

    }
}
