namespace TeamTrackApi.Services;

public interface IEmployeeService
{
    List<Employee> GetAllEmployees();

    Employee GetEmployeeById(int id);

    List<Employee> AddEmployee(Employee newEmployee);
}