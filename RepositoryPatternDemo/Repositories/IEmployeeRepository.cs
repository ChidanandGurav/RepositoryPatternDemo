using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeByEmpid(int Empid);
        int AddEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int Empid);
    }
}
