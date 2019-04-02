namespace App.Infrastructure.Dto
{
    public class EmployeeDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public EmployeeDto() : this("John", "Wayne", 55)
        {
        }

        public EmployeeDto(string firstname, string lastName, int age)
        {
            FirstName = firstname;
            LastName = lastName;
            Age = age;
        }
    }
}
