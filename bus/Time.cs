using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApplication.bus
{
    class Time
    {
        private int numberOfHour;
        private int numberOfMinute;
        private int numberOfSecond;

        public int NumberOfHour { get => numberOfHour; set => numberOfHour = value; }
        public int NmuberOfMinute { get => numberOfMinute; set => numberOfMinute = value; }
        public int NumberOfSecond { get => numberOfSecond; set => numberOfSecond = value; }

        public Time()
        {
            this.numberOfHour = 0;
            this.NmuberOfMinute = 0;
            this.numberOfSecond = 0;
        }

        public Time(int numberOfHour, int numberOfMinute, int numberOfSecond)
        {
            this.numberOfHour = numberOfHour;
            this.numberOfMinute = numberOfMinute;
            this.numberOfSecond = numberOfSecond;
        }
    }
}
