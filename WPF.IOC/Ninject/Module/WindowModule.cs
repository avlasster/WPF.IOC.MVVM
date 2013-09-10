using Ninject.Modules;

namespace WPF.IOC.Ninject.Module
{
    public class WindowModule : NinjectModule
    {
        public override void Load()
        {
            Bind<MainWindow>().ToSelf();
        }

    }
}
