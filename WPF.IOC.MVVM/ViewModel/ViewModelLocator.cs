/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:WPF.IOC"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator.NinjectAdapter;
using GalaSoft.MvvmLight;
using Microsoft.Practices.ServiceLocation;
using WPF.IOC.MVVM.Ninject;
using WPF.IOC.MVVM.ViewModel.Architecture;

namespace WPF.IOC.MVVM.ViewModel
{
    ///// <summary>
    ///// This class contains static references to all the view models in the
    ///// application and provides an entry point for the bindings.
    ///// </summary>
    public class ViewModelLocator
    {
        private readonly INinjectBootstrapper _ninjectBootstrapper;
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            // Different Dependencies are Injected upon design time.
            if (ViewModelBase.IsInDesignModeStatic)
            {
                // Create an instance of NinjectBootstrapper
                _ninjectBootstrapper = new DesignTimeNinjectBootstrapper();
            }
            else
            {
                // Create an instance of NinjectBootstrapper
                _ninjectBootstrapper = new NinjectBootstrapper();
            }

            // Load the neccesary Modules.
            _ninjectBootstrapper.LoadModules();

            // Set the Ninject Kernel as the ServiceLocatorProvider to make it Resolve our ViewModels (and their dependencies)
            var serviceLocator = new NinjectServiceLocator(_ninjectBootstrapper.Kernel);
            ServiceLocator.SetLocatorProvider(() => serviceLocator);
        }

        public IMainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<IMainViewModel>();
            }
        }

        public static void Cleanup()
        {
        }
    }

    
}