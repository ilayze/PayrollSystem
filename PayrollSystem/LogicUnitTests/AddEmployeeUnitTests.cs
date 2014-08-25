using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic.Transactions;
using Logic;
using Logic.Payment;

namespace LogicUnitTests
{
    [TestClass]
    public class AddEmployeeUnitTests
    {
        [TestMethod]
        public void AddSalariedEmployee_shouldAddTheEmployee()
        {
            int empId = 1;
            AddSalariedEmployee t = new AddSalariedEmployee(empId, "Bob", "Home", 1000.00);
            t.Execute();

            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.AreEqual("Bob", e.Name);

            PaymentClassification pc = e.Classification;
            Assert.IsTrue(pc is SalariedClassification);
            var sc = pc as SalariedClassification;
            Assert.AreEqual(1000.00, sc.Salary);

        }

        [TestMethod]
        public void AddHourlyEmployee_shouldAddTheEmployee()
        {
            int empId = 5;

            AddHourlyEmployee t = new AddHourlyEmployee(empId, "Ilay", "Home", 60);
            t.Execute();

            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.AreEqual("Ilay", e.Name);
            Assert.AreEqual("Home", e.Address);

            PaymentClassification pc = e.Classification;
            Assert.IsTrue(pc is HourlyClassification);

            var hc = pc as HourlyClassification;
            Assert.AreEqual(60, hc.PaymentPerHour);
        }


    }
}
