using Logic.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Transactions
{
    public class AddSalariedEmployee : AddEmployeeTransaction
    {
        private double _salary;

        public AddSalariedEmployee(int empId, string name, string address, double salary)
            : base(empId, name, address)
        {
            this._salary = salary;
        }


        protected override PaymentClassification MakeClassification()
        {
            return new SalariedClassification(_salary);
        }
    }
}
