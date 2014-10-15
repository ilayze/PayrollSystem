using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic.Transactions;
using Logic;
using Logic.Payment;

namespace LogicUnitTests
{
    [TestClass]
    public class TimeCardUnitTests
    {
        [TestMethod]
        public void AddTimeCardToEmployee()
        {
            int empId = 1;
            AddHourlyEmployee t = new AddHourlyEmployee(empId, "ilay", "home", 30);
            t.Execute();

            DateTime dateTime = new DateTime(2014, 8, 26);
            double hours=8.0;
            TimeCardTransaction tct = new TimeCardTransaction(dateTime, hours, empId);
            tct.Execute();

            Employee e = PayrollDatabase.GetEmployee(empId);
            Assert.IsNotNull(e);

            HourlyClassification hc = e.Classification as HourlyClassification;
            TimeCard timeCard=hc.GetTimeCard(dateTime);

            Assert.IsNotNull(timeCard);
            Assert.AreEqual(hours, timeCard.Hours);
        }
    }
}
