using System.Windows;
using HRManagement.IoC;
using Microsoft.Practices.Unity;

namespace HRManagement
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IoCConfiguration.Register(IoCContainer.Instance);
            IoCContainer.Instance.Resolve<IMainWindow>().Show();
        }
    }
}
