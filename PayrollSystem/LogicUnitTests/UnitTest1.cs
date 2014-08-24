using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic.Transactions;
using Logic;

namespace LogicUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddSalariedEmployee_shouldAddTheEmployee()
        {
            int empId = 1;
            AddSalariedEmployee t = new AddSalariedEmployee(empId, "Bob", "Home", 1000.00);
            t.Execute();

            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.AreEqual("Bob", e.Name);

        }
    }
}
