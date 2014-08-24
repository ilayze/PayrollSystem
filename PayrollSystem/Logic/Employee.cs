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
        private double _salary;

        public string Name { get { return _name; } }

        public Employee(string _name, string _address, double _salary)
        {
            // TODO: Complete member initialization
            this._name = _name;
            this._address = _address;
            this._salary = _salary;
        }
        
    }
}
