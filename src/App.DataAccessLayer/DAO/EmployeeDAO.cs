using App.DataAccessLayer.Models;
using App.InfrastructureLayer.Common;
using App.InfrastructureLayer.Dto;
using System;
using System.Linq;

namespace App.DataAccessLayer.DAO
{
    public class EmployeeDAO : ApplicationBase
    {
        public EmployeeDAO() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
        }

        public EmployeeDto CreateEmployee(EmployeeDto employeeDto)
        {
            try
            {
                using (var database = new EmployeeTrainingModelContainer())
                {
                    var employee = new Employee
                    {
                        EmployeeNumber = employeeDto.EmployeeNumber,
                        FirstName = employeeDto.FirstName,
                        LastName = employeeDto.LastName,
                        DateOfBirth = employeeDto.DateOfBirth,
                        DateOfHire = employeeDto.DateOfHire
                    };

                    database.EmployeeSet.Add(employee);
                    database.SaveChanges();

                    var query = from e in database.EmployeeSet
                                where e.EmployeeNumber == employeeDto.EmployeeNumber
                                select e;

                    employeeDto.Id = query.First().Id;
                }

            }
            catch (Exception ex)
            {
                LogError(ex);
            }

            return employeeDto;
        }

        public void DeleteEmployee(int id)
        {
            try
            {
                using (var database = new EmployeeTrainingModelContainer())
                {
                    Employee employee = (Employee)database.EmployeeSet.Where(e => e.Id == id).First();

                    database.EmployeeSet.Remove(employee);
                    database.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }
    }
}
