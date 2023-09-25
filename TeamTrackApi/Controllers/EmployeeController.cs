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
    public async Task<ActionResult<List<Employee>>> Get()
    {
        return Ok(await _employeeService.GetAllEmployees());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Employee>> GetSingle(int id)
    {
        return Ok(await _employeeService.GetEmployeeById(id));
    }

    [HttpPost]
    public async Task<ActionResult<List<Employee>>> AddEmployee(Employee neweEployee)
    {
        return Ok(await _employeeService.AddEmployee(neweEployee));
    }
}