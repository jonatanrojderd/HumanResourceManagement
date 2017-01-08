using Microsoft.Practices.Unity;
using HRManagement.ViewModels;

namespace HRManagement.Views
{
    public partial class MainWindow : IMainWindow
    {
        [Dependency]
        public IMainWindowViewModel ViewModel
        {
            set { DataContext = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
