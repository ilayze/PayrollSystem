﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TimeCard
    {
        private readonly DateTime date;
        private readonly double hours;

        public TimeCard(DateTime date,double hours)
        {
            this.date = date;
            this.hours = hours;
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
        }

        public double Hours
        {
            get
            {
                return hours;
            }
        }
    }
}
