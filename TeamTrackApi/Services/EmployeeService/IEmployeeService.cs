namespace TeamTrackApi.Services;

public interface IEmployeeService
{
    Task<List<Employee>> GetAllEmployees();

    Task<Employee> GetEmployeeById(int id);

    Task<List<Employee>> AddEmployee(Employee newEmployee);
}