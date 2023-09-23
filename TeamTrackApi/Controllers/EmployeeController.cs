using Microsoft.AspNetCore.Mvc;

namespace TeamTrackApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    public Employee firstEmployee = new Employee
    {
        Id = 0,
        Name = "First",
        Surname = "Emplyee",
        Position = "Employee",
        BirthDate = DateOnly.MinValue,
        Adress = "Ukraie, Kyiv",
        Email = "awesome_employee@gmail.com",
        PhoneNumber = "+380 111 111 111",
        Salary = 1111111,
        HireDate = DateOnly.MinValue,
        LiveDate = null,
        Department = Departments.First,
    };

    public static List<Employee> employees = new List<Employee>{
        new Employee(),
        new Employee{Id = 1, Name = "Second"}
    };

    [HttpGet("GetAll")]
    public ActionResult<List<Employee>> Get()
    {
        return Ok(employees);
    }

    [HttpGet]
    public ActionResult<Employee> GetSingle()
    {
        return Ok(employees[0]);
    }
}
