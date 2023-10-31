using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeByEmpid(int Empid);
        int AddEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int Empid);
    }
}
