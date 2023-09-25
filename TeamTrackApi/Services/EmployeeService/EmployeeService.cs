
namespace TeamTrackApi.Services.EmployeeService;

public class EmployeeService : IEmployeeService
{

    public static List<Employee> employees = new List<Employee>{
        new Employee(),
        new Employee{Id = 1, Name = "Second"}
    };

    public async Task<List<Employee>> AddEmployee(Employee newEmployee)
    {
        employees.Add(newEmployee);
        return employees;
    }

    public async Task<List<Employee>> GetAllEmployees()
    {
        return employees;
    }

    public async Task<Employee> GetEmployeeById(int id)
    {
        var employee = employees.FirstOrDefault(c => c.Id == id);
        if (employee is not null) return employee;

        throw new NullReferenceException($"Employee with id: {id} not found");
    }
}