using Microsoft.AspNetCore.Mvc;
using TeamTrackApi.Services;

namespace TeamTrackApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;

    }
    [HttpGet("GetAll")]
    public ActionResult<List<Employee>> Get()
    {
        return Ok(_employeeService.GetAllEmployees());
    }

    [HttpGet("{id}")]
    public ActionResult<Employee> GetSingle(int id)
    {
        return Ok(_employeeService.GetEmployeeById(id));
    }

    [HttpPost]
    public ActionResult<List<Employee>> AddEmployee(Employee neweEployee)
    {
        return Ok(_employeeService.AddEmployee(neweEployee));
    }
}
