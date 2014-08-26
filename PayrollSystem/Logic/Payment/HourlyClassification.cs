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
        private Dictionary<DateTime, TimeCard> timeCards;

        public double PaymentPerHour { get { return _paymentPerHour; } }

        public HourlyClassification(double paymentPerHour)
        {
            this._paymentPerHour = paymentPerHour;
            timeCards = new Dictionary<DateTime, TimeCard>();
        }


        public TimeCard GetTimeCard(DateTime dateTime)
        {
            return timeCards[dateTime];
        }

        internal void AddTimeCard(DateTime dateTime, double hours)
        {
            TimeCard tc = new TimeCard(dateTime, hours);
            timeCards[dateTime] = tc;
        }
    }
}
