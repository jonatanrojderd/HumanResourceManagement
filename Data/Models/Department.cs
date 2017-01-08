using System;
using System.Collections.Generic;

namespace Data.Models
{
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual IList<Employee> Employees { get; set; }
    }
}