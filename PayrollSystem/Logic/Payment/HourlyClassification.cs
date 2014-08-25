using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Payment
{
    public class HourlyClassification: PaymentClassification
    {
        private double _paymentPerHour;

        public double PaymentPerHour { get { return _paymentPerHour; } }

        public HourlyClassification(double paymentPerHour)
        {
            this._paymentPerHour = paymentPerHour;
        }

    }
}
