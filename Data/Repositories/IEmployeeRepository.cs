using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repositories
{
    public interface IEmployeeRepository
    {
        void Create(Employee employee);
        Task<IList<Employee>> ReadAsync();
    }
}