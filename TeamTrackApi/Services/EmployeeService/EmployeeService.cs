namespace TeamTrackApi.Services.EmployeeService;

public class EmployeeService : IEmployeeService
{

    public static List<Employee> employees = new List<Employee>{
        new Employee(),
        new Employee{Id = 1, Name = "Second"}
    };

    private readonly IMapper _mapper;
    public EmployeeService(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<ServiceResponse<List<GetEmployeeDto>>> AddEmployee(AddEmployeeDto newEmployee)
    {
        var serviceResponse = new ServiceResponse<List<GetEmployeeDto>>();
        var employee = _mapper.Map<Employee>(newEmployee);
        employee.Id = employees.Max(e => e.Id) + 1;
        employees.Add(employee);
        serviceResponse.Data = employees.Select(e => _mapper.Map<GetEmployeeDto>(e)).ToList();
        return serviceResponse;
    }

    public async Task<ServiceResponse<List<GetEmployeeDto>>> DeleteEmployees(int id)
    {
        var serviceResponse = new ServiceResponse<List<GetEmployeeDto>>();

        try
        {
            var employee = employees.FirstOrDefault(c => c.Id == id);
            if (employee is null) throw new Exception($"Employee with Id '{id}' not found");
            employees.Remove(employee);

            serviceResponse.Data = employees.Select(e => _mapper.Map<GetEmployeeDto>(e)).ToList();
        }
        catch (Exception e)
        {
            serviceResponse.Success = false;
            serviceResponse.Message = e.Message;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<List<GetEmployeeDto>>> GetAllEmployees()
    {
        var serviceResponse = new ServiceResponse<List<GetEmployeeDto>>
        {
            Data = employees.Select(e => _mapper.Map<GetEmployeeDto>(e)).ToList(),
        };

        return serviceResponse;
    }

    public async Task<ServiceResponse<GetEmployeeDto>> GetEmployeeById(int id)
    {
        var serviceResponse = new ServiceResponse<GetEmployeeDto>();
        var employee = employees.FirstOrDefault(e => e.Id == id);
        serviceResponse.Data = _mapper.Map<GetEmployeeDto>(employee);
        return serviceResponse;
    }

    public async Task<ServiceResponse<GetEmployeeDto>> UpdateEmployee(UpdateEmployeeDto updatedEmployee)
    {
        var serviceResponse = new ServiceResponse<GetEmployeeDto>();

        try
        {
            var employee = employees.FirstOrDefault(e => e.Id == updatedEmployee.Id);
            if (employee is null)
            {
                throw new Exception($"Employee with Id '{updatedEmployee.Id}' not found");
            }

            employee.Name = updatedEmployee.Name;
            employee.Surname = updatedEmployee.Surname;
            employee.Position = updatedEmployee.Position;
            employee.BirthDate = updatedEmployee.BirthDate;
            employee.Email = updatedEmployee.Email;
            employee.PhoneNumber = updatedEmployee.PhoneNumber;
            employee.Salary = updatedEmployee.Salary;
            employee.HireDate = updatedEmployee.HireDate;
            employee.LiveDate = updatedEmployee.LiveDate;
            employee.Department = updatedEmployee.Department;

            serviceResponse.Data = _mapper.Map<GetEmployeeDto>(employee);
        }
        catch (Exception ex)
        {
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
        }

        return serviceResponse;
    }
}