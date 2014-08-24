using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Payment
{
    public class SalariedClassification:PaymentClassification
    {
        public SalariedClassification(double salary)
        {
            Salary = salary;
        }
    }
}
