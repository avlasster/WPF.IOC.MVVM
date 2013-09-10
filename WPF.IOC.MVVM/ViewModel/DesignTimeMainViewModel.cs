using GalaSoft.MvvmLight;
using WPF.IOC.MVVM.ViewModel.Architecture;

namespace WPF.IOC.MVVM.ViewModel
{
    public class DesignTimeMainViewModel : ViewModelBase, IMainViewModel
    {
        public DesignTimeMainViewModel()
        {
            FullName = "John Doe Design Time";
        }

        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
                RaisePropertyChanged("Title");
            }
        }
    }
}
