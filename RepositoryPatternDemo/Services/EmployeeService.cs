using RepositoryPatternDemo.Models;
using RepositoryPatternDemo.Repositories;

namespace RepositoryPatternDemo.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository repo;
        public EmployeeService(IEmployeeRepository repo)
        {
            this.repo = repo;
        }
        int IEmployeeService.AddEmployee(Employee employee)
        {
            return repo.AddEmployee(employee);
        }

        int IEmployeeService.DeleteEmployee(int Empid)
        {
            return repo.DeleteEmployee(Empid);
        }

        Employee IEmployeeService.GetEmployeeByEmpid(int Empid)
        {
            return repo.GetEmployeeByEmpid(Empid);
        }

        IEnumerable<Employee> IEmployeeService.GetEmployees()
        {
            return repo.GetEmployees();
        }

        int IEmployeeService.UpdateEmployee(Employee employee)
        {
            return repo.UpdateEmployee(employee);
        }
    }
}
