using Logic.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Transactions
{
    public class AddHourlyEmployee : AddEmployeeTransaction
    {
        private double _paymentPerHour;

        public AddHourlyEmployee(int empId,string name,string address,double paymentPerHour)
            :base(empId,name,address)
        {
            _paymentPerHour = paymentPerHour;
        }

        protected override Payment.PaymentClassification MakeClassification()
        {
            return new HourlyClassification(_paymentPerHour);
        }
    }
}
