using Data.Repositories;
using HRManagement.ViewModels;
using HRManagement.Views;
using Microsoft.Practices.Unity;

namespace HRManagement.IoC
{
    public class IoCConfiguration
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IMainWindow, MainWindow>();
            container.RegisterType<IMainWindowViewModel, MainWindowViewModel>();
            container.RegisterType<IEmployeeControlViewModel, EmployeeControlViewModel>();

            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
        }
    }
}