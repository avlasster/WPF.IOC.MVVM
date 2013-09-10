using GalaSoft.MvvmLight;
using WPF.IOC.MVVM.Service.Architecture;
using WPF.IOC.MVVM.ViewModel.Architecture;

namespace WPF.IOC.MVVM.ViewModel
{
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        private readonly IMainService _mainService;
       
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IMainService mainService)
        {
            _mainService = mainService;
            FullName = _mainService.GetUsername(1);
        }

        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
                RaisePropertyChanged("FullName");
            }
        }
    }
}