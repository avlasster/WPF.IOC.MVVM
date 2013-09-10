using System.Windows;
using WPF.IOC.MVVM.ViewModel.Architecture;

namespace WPF.IOC.MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Access UserControl's ViewModel
            AccessChildVM();
        }

        private void AccessChildVM()
        {
            var mainViewModel = UxMain.DataContext as IMainViewModel;

            if (mainViewModel != null)
                Title = mainViewModel.FullName;
        }
    }
}
