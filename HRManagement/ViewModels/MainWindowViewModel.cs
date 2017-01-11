using System.Collections.ObjectModel;

namespace HRManagement.ViewModels
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly IEmployeeControlViewModel _employeeViewModel;
        
        public MainWindowViewModel(IEmployeeControlViewModel employeeViewModel)
        {
            _employeeViewModel = employeeViewModel;

            TabItems = new ObservableCollection<object>
            {
                _employeeViewModel
            };
        }
        public ObservableCollection<object> TabItems { get; set; }
    }
}