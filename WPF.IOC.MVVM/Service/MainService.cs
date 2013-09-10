using WPF.IOC.MVVM.Service.Architecture;

namespace WPF.IOC.MVVM.Service
{
    public class MainService : IMainService
    {
        public string GetUsername(int userId)
        {
            return "John Doe";
        }
    }
}
