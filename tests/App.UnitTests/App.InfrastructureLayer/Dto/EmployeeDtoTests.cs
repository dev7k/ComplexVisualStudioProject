using App.InfrastructureLayer.Dto;
using NUnit.Framework;
using System.Collections.Generic;

namespace App.UnitTests.App.Infrastructure.Dto
{
    public class EmployeeDtoTests
    {
        public List<string> StringList { get; set; }

        [SetUp]
        public void Setup()
        {
            StringList = new List<string>();
            StringList.Add("Hello");
            StringList.Add("World");
        }

        [Test]
        public void ListOfStringVerification()
        {
            Assert.IsNotNull(StringList);
            Assert.AreEqual(2, StringList.Count);
        }

        [Test]
        public void EmployeeDtoConstructorTest()
        {
            var defaultEmployee = new EmployeeDto();
            var createdEmployee = new EmployeeDto("John", "Snow", 35);

            Assert.IsNotNull(defaultEmployee);
            Assert.AreEqual("John", defaultEmployee.FirstName);
            Assert.AreEqual("Wayne", defaultEmployee.LastName);
            Assert.AreEqual(55, defaultEmployee.Age);

            Assert.IsNotNull(createdEmployee);
            Assert.AreEqual("John", createdEmployee.FirstName);
            Assert.AreEqual("Snow", createdEmployee.LastName);
            Assert.AreEqual(35, createdEmployee.Age);
        }
    }
}
