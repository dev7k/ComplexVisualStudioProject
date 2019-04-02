using System;

namespace App.InfrastructureLayer.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfHire { get; set; }


        public EmployeeDto() : this(0, "999999999", "John", "Wayne", DateTime.Now, DateTime.Now)
        {
        }

        public EmployeeDto(int id, string employeeNumber, string firstname, string lastName,
            DateTime dateOfBirth, DateTime dateOfHire)
        {
            Id = id;
            EmployeeNumber = employeeNumber;
            FirstName = firstname;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            DateOfHire = dateOfHire;
        }
    }
}
