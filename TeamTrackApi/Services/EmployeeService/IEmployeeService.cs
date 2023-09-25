namespace TeamTrackApi.Services;

public interface IEmployeeService
{
    Task<ServiceResponse<List<GetEmployeeDto>>> GetAllEmployees();

    Task<ServiceResponse<GetEmployeeDto>> GetEmployeeById(int id);

    Task<ServiceResponse<List<GetEmployeeDto>>> AddEmployee(AddEmployeeDto newEmployee);

    Task<ServiceResponse<GetEmployeeDto>> UpdateEmployee(UpdateEmployeeDto updatedEmployee);

    Task<ServiceResponse<List<GetEmployeeDto>>> DeleteEmployees(int id);
}