using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic.Transactions;
using Logic;

namespace LogicUnitTests
{
    [TestClass]
    public class DeleteEmployeeUnitTests
    {
        [TestMethod]
        public void DeleteEmployee_shouldDeleteTheEmployee()
        {
            int empId = 4;
            AddHourlyEmployee t = new AddHourlyEmployee(empId, "ilay", "cisco", 30);
            t.Execute();

            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.IsNotNull(e);

            DeleteEmployeeTransaction dt = new DeleteEmployeeTransaction(empId);
            dt.Execute();

            e = PayrollDatabase.GetEmployee(empId);
            Assert.IsNull(e);
        }
    }
}
