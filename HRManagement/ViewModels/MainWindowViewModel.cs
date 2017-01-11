using System.Collections.ObjectModel;

namespace HRManagement.ViewModels
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly IEmployeeViewModel _employeeViewModel;
        public ObservableCollection<object> TabItems { get; set; }
        
        public MainWindowViewModel(IEmployeeViewModel employeeViewModel)
        {
            _employeeViewModel = employeeViewModel;

            TabItems = new ObservableCollection<object>
            {
                _employeeViewModel
            };
        }
    }
}