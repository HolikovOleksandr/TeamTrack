
namespace TeamTrackApi.Services.EmployeeService;

public class EmployeeService : IEmployeeService
{

    public static List<Employee> employees = new List<Employee>{
        new Employee(),
        new Employee{Id = 1, Name = "Second"}
    };

    public async Task<ServiceResponse<List<Employee>>> AddEmployee(Employee newEmployee)
    {
        var serviceResponse = new ServiceResponse<List<Employee>>();
        employees.Add(newEmployee);
        serviceResponse.Data = employees;
        return serviceResponse;
    }

    public async Task<ServiceResponse<List<Employee>>> GetAllEmployees()
    {
        var serviceResponse = new ServiceResponse<List<Employee>>
        {
            Data = employees
        };

        return serviceResponse;
    }

    public async Task<ServiceResponse<Employee>> GetEmployeeById(int id)
    {
        var serviceResponse = new ServiceResponse<Employee>();
        var employee = employees.FirstOrDefault(c => c.Id == id);
        serviceResponse.Data = employee;
        return serviceResponse;
    }
}