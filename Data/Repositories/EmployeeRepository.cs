﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Data.Context;
using Data.Models;

namespace Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void Create(Employee employee)
        {
            using (var context = new HrmContext())
            {
                context.Employees.Add(new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Email = employee.Email,
                    Salary = employee.Salary,
                    DateOfBirth = employee.DateOfBirth,
                    Absence = employee.Absence
                });
                context.SaveChanges();
            }
        }

        public async Task<IList<Employee>> ReadAsync()
        {
            using (var context = new HrmContext())
            {
                return await context.Employees.ToListAsync();
            }
        }

        public void Update(Employee employee)
        {
            using (var context = new HrmContext())
            {
                var update = context.Employees.First(e => e.Id == employee.Id);
                update.FirstName = employee.FirstName;
                update.LastName = employee.LastName;

                context.SaveChanges();
            }
        }

        public void Delete(Employee employee)
        {
            using (var context = new HrmContext())
            {
                context.Employees.Remove(context.Employees.First(e => e.Id == employee.Id));
                context.SaveChanges();
            }   
        }
    }
}