using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using WPF.IOC.MVVM.Service.Architecture;

namespace WPF.IOC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private readonly IMainService _mainService;
        private string _fullName;

        public MainWindow(IMainService mainService)
        {
            InitializeComponent();

            DataContext = this;

            _mainService = mainService;
            FullName = _mainService.GetUsername(1);
        }

        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null) 
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
