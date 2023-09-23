using System.ComponentModel.DataAnnotations;

namespace TeamTrackApi.Models;

public class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Position { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    public string Adress { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public decimal Salary { get; set; }

    public DateOnly HireDate { get; set; }

    public DateOnly? LiveDate { get; set; }

    public Departments Department { get; set; }
}