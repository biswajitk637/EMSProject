using EMSProject.Models;
using EMSProject.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMSProject.Respository.Contract
{
    public interface IEmployee
    {
        List<Employees> GetEmployees();
        Employees CreateEmployee(EmployeeViewModel model);
        List<Department> GetDepartments();
    }
}
