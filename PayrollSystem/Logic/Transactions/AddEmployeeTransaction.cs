using Logic.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Transactions
{
    public abstract class AddEmployeeTransaction:Transaction
    {
        private int _empId;
        private string _name;
        private string _address;

        protected abstract PaymentClassification MakeClassification();

        public AddEmployeeTransaction(int empId,string name,string address)
        {
            this._empId = empId;
            this._name = name;
            this._address = address;
        }

        public void Execute()
        {
            PaymentClassification pc = MakeClassification();
            Employee e = new Employee(_name, _address, pc);
            PayrollDatabase.AddEmployee(_empId, e);
        }
    }
}
