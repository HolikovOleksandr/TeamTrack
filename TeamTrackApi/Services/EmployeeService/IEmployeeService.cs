namespace TeamTrackApi.Services;

public interface IEmployeeService
{
    Task<ServiceResponse<List<Employee>>> GetAllEmployees();

    Task<ServiceResponse<Employee>> GetEmployeeById(int id);

    Task<ServiceResponse<List<Employee>>> AddEmployee(Employee newEmployee);
}