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
    public async Task<ActionResult<ServiceResponse<List<GetEmployeeDto>>>> Get()
    {
        return Ok(await _employeeService.GetAllEmployees());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<GetEmployeeDto>>> GetEmployeeById(int id)
    {
        return Ok(await _employeeService.GetEmployeeById(id));
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<List<GetEmployeeDto>>>> AddEmployee(AddEmployeeDto newEployee)
    {
        return Ok(await _employeeService.AddEmployee(newEployee));
    }

    [HttpPut]
    public async Task<ActionResult<ServiceResponse<List<GetEmployeeDto>>>> UpdateEmployee(UpdateEmployeeDto updateEployee)
    {
        var response = await _employeeService.UpdateEmployee(updateEployee);
        return response.Data is null ? NotFound(response) : Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ServiceResponse<GetEmployeeDto>>> DeleteEmployeeById(int id)
    {
        var response = await _employeeService.DeleteEmployees(id);
        return response.Data is null ? NotFound(response) : Ok(response);
    }
}