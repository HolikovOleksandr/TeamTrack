namespace TeamTrackApi.Dtos.Employee;

public class UpdateEmployeeDto
{
    public int Id { get; set; } = 0;

    public string Name { get; set; } = "First";

    public string Surname { get; set; } = "Emplyee";

    public string Position { get; set; } = "Employee";

    public DateTime? BirthDate { get; set; } = null;

    public string Adress { get; set; } = "Ukraie, Kyiv";

    public string Email { get; set; } = "awesome_employee@gmail.com";

    public string PhoneNumber { get; set; } = "+380 111 111 111";

    public decimal Salary { get; set; } = 1111111;

    public DateTime? HireDate { get; set; } = null;

    public DateTime? LiveDate { get; set; } = null;

    public Departments Department { get; set; } = Departments.First;
}