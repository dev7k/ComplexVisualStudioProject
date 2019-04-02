using App.DataAccessLayer.DAO;
using App.InfrastructureLayer.Dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.UnitTests.App.DataAccessLayer.DAO
{
    [TestClass]
    public class EmployeeDAOTests
    {
        [TestMethod]
        public void InsertEmployeeTest()
        {
            EmployeeDto employeeDto = new EmployeeDto();
            EmployeeDAO employeeDAO = new EmployeeDAO();

            int originId = employeeDto.Id;
            employeeDto = employeeDAO.CreateEmployee(employeeDto);

            Assert.AreNotEqual(originId, employeeDto.Id);

            employeeDAO.DeleteEmployee(employeeDto.Id);
        }
    }
}
