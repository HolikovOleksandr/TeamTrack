namespace TeamTrackApi.Dtos.Employee;

public class AddEmployeeDto
{
    public string Name { get; set; } = "First";

    public string Surname { get; set; } = "Emplyee";

    public string Position { get; set; } = "Employee";

    public DateOnly BirthDate { get; set; } = DateOnly.MinValue;

    public string Adress { get; set; } = "Ukraie, Kyiv";

    public string Email { get; set; } = "awesome_employee@gmail.com";

    public string PhoneNumber { get; set; } = "+380 111 111 111";

    public decimal Salary { get; set; } = 1111111;

    public DateOnly HireDate { get; set; } = DateOnly.MinValue;

    public DateOnly? LiveDate { get; set; } = null;

    public Departments Department { get; set; } = Departments.First;
}