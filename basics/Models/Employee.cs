namespace basics.Models;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName.ToUpper()}";
    public int Age { get; set; }

    public Employee(int id, string firstName, string lastName, int age)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
}
