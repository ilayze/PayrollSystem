using Logic.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Transactions
{
    public class TimeCardTransaction:Transaction
    {
        private DateTime dateTime;
        private double hours;
        private int empId;

        public TimeCardTransaction(DateTime dateTime, double hours, int empId)
        {
            // TODO: Complete member initialization
            this.dateTime = dateTime;
            this.hours = hours;
            this.empId = empId;
        }
        public void Execute()
        {
            Employee e = PayrollDatabase.GetEmployee(empId);

            if(e!=null)
            {
                HourlyClassification hc=e.Classification as HourlyClassification;
                if(hc!=null)
                {
                    hc.AddTimeCard(dateTime, hours);
                }
                else
                {
                    throw new InvalidOperationException("Try to add time card to non hourly employee");
                }
            }
            else
            {
                throw new InvalidOperationException(String.Format("Employee {0} not exists in database",empId));
            }
        }
    }
}
