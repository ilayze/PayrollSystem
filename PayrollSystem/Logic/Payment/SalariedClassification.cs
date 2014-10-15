using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Payment
{
    public class SalariedClassification:PaymentClassification
    {
        private double _salary;

        public double Salary
        {
            get
            {
                return _salary;
            }

        }

        public SalariedClassification(double salary)
        {
            _salary = salary;
        }
    }
}
