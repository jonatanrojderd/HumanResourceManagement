using Prism.Mvvm;

namespace HRManagement.ViewModels
{
    public class EmployeeControlViewModel : BindableBase, IEmployeeControlViewModel
    {
        public string Header => "Employees";
        public string Content => "Employee Tab Content";
    }
}