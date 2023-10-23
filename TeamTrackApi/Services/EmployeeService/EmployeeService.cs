using TeamTrackApi.Data;

namespace TeamTrackApi.Services.EmployeeService;

public class EmployeeService : IEmployeeService
{

    public static List<Employee> employees = new List<Employee>{
        new Employee(),
        new Employee{Id = 1, Name = "Second"}
    };

    private readonly IMapper _mapper;
    private readonly DataContext _context;

    public EmployeeService(IMapper mapper, DataContext context)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ServiceResponse<List<GetEmployeeDto>>> AddEmployee(AddEmployeeDto newEmployee)
    {
        var response = new ServiceResponse<List<GetEmployeeDto>>();

        try
        {
            var employee = _mapper.Map<Employee>(newEmployee);
            await _context.Employees.AddAsync(employee);

            response.Data = _context.Employees
            .Select(e => _mapper.Map<GetEmployeeDto>(e))
            .ToList();
        }
        catch (Exception exception)
        {
            response.Success = false;
            response.Message = exception.Message;
        }

        return response;
    }

    public async Task<ServiceResponse<List<GetEmployeeDto>>> DeleteEmployees(int id)
    {
        var response = new ServiceResponse<List<GetEmployeeDto>>();

        try
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(c => c.Id == id);
            if (employee is null) throw new Exception($"Employee with Id '{id}' not found");
            _context.Employees.Remove(employee);

            response.Data = employees.Select(e => _mapper.Map<GetEmployeeDto>(e)).ToList();
        }
        catch (Exception exception)
        {
            response.Success = false;
            response.Message = exception.Message;
        }

        return response;
    }

    public async Task<ServiceResponse<List<GetEmployeeDto>>> GetAllEmployees()
    {
        var response = new ServiceResponse<List<GetEmployeeDto>>();
        var dbEmployee = await _context.Employees.ToListAsync();
        response.Data = dbEmployee.Select(e => _mapper.Map<GetEmployeeDto>(e)).ToList();
        return response;
    }

    public async Task<ServiceResponse<GetEmployeeDto>> GetEmployeeById(int id)
    {
        var response = new ServiceResponse<GetEmployeeDto>();
        var dbEmployee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
        response.Data = _mapper.Map<GetEmployeeDto>(dbEmployee);
        return response;
    }

    public async Task<ServiceResponse<GetEmployeeDto>> UpdateEmployee(UpdateEmployeeDto updatedEmployee)
    {
        var response = new ServiceResponse<GetEmployeeDto>();

        try
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == updatedEmployee.Id);

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

            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
            response.Data = _mapper.Map<GetEmployeeDto>(employee);
        }
        catch (Exception exception)
        {
            response.Success = false;
            response.Message = exception.Message;
        }

        return response;
    }
}