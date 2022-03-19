using EMSProject.Models;
using EMSProject.Models.ViewModel;
using EMSProject.Respository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMSProject.Respository.Service
{
    public class EmployeeService : IEmployee
    {
        private readonly EMSDBContext dbcontext;

        public EmployeeService(EMSDBContext context)
        {
            this.dbcontext = context;
        }

        public Employees CreateEmployee(EmployeeViewModel model)
        {
            var dept = dbcontext.Departments.SingleOrDefault(e => e.Id == model.Department);
            var emp = new Employees()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Mobile = model.Mobile,
                IsActive = model.IsActive,
                Department = dept
            };
            dbcontext.Employees.Add(emp);
            dbcontext.SaveChanges();
            return emp;
        }

        public List<Department> GetDepartments()
        {
            return dbcontext.Departments.ToList();
        }

        public List<Employees> GetEmployees()
        {
            return dbcontext.Employees.ToList();
        }

    }
}
