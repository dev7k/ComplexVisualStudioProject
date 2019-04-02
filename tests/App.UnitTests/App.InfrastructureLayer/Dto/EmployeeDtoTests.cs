using App.InfrastructureLayer.Dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace App.UnitTests
{
    [TestClass]
    public class EmployeeDtoTests
    {
        public List<string> StringList { get; set; }

        [TestInitialize]
        public void Setup()
        {
            StringList = new List<string>();
            StringList.Add("Hello");
            StringList.Add("World");
        }

        [TestMethod]
        public void ListOfStringVerification()
        {
            Assert.IsNotNull(StringList);
            Assert.AreEqual(2, StringList.Count);
        }

        [TestMethod]
        public void EmployeeDtoConstructorTest()
        {
            var defaultEmployee = new EmployeeDto();
            var createdEmployee = new EmployeeDto(0, "999999999", "John", "Snow", DateTime.Now, DateTime.Now);

            Assert.IsNotNull(defaultEmployee);
            Assert.AreEqual("John", defaultEmployee.FirstName);
            Assert.AreEqual("Wayne", defaultEmployee.LastName);

            Assert.IsNotNull(createdEmployee);
            Assert.AreEqual("John", createdEmployee.FirstName);
            Assert.AreEqual("Snow", createdEmployee.LastName);
        }

    }
}
