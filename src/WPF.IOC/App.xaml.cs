using System.Windows;
using CommonServiceLocator.NinjectAdapter;

namespace WPF.IOC
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Init Ninject
            var ninjectBootstrapper = new Ninject.NinjectBootstrapper();
            ninjectBootstrapper.LoadModules();

            // Use SL pattern to load Main Window / Open a different window
            var serviceLocator = new NinjectServiceLocator(ninjectBootstrapper.Kernel);


            // Load up Main Window
            // As you can see, this method still required to pass the Dependencies of the Windows (all the rest will be resolved).
            // Since a "new" requires the parameters to be passed...
            //var mainWindow = new WPF.IOC.MainWindow(serviceLocator.GetInstance<IMainService>());
            //mainWindow.Show();

            // Using this method, we also resolve our Windows (and UserControls) using an IOC-Container
            var mainWindow2 = serviceLocator.GetInstance<MainWindow>();
            mainWindow2.Show();

            // The problem with both solutions is that they do not enable design time data on an easy way.
            // Design time data will be possible, but less easy than with using ViewModels
        }
    }
}
