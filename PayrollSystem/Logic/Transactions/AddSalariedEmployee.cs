using Logic.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Transactions
{
    public class AddSalariedEmployee:Transaction
    {
        private int empId;
        private string _name;
        private string _address;
        private double _salary;

        public AddSalariedEmployee(int empId, string name, string address, double salary)
        {
            // TODO: Complete member initialization
            this.empId = empId;
            this._name = name;
            this._address = address;
            this._salary = salary;

        }
        public void Execute()
        {
            SalariedClassification sc = new SalariedClassification(_salary);

            Employee e = new Employee(_name, _address, sc);
            PayrollDatabase.AddEmployee(empId, e);
        }
    }
}
