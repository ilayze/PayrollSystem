using Logic.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logic
{
    public class Employee
    {
        private string _name;
        private string _address;
        private PaymentClassification _paymentClassification;

        public string Name { get { return _name; } }
        public string Address { get { return _address; } }
        public PaymentClassification Classification { get { return _paymentClassification; } }

        public Employee(string _name, string _address, PaymentClassification pc)
        {
            // TODO: Complete member initialization
            this._name = _name;
            this._address = _address;
            this._paymentClassification=pc;
        }
        
    }
}
