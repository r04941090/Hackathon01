using System;
using System.Collections.Generic;
using System.Text;

namespace 生命靈數
{
    class Constellation
    {
        public string Name { get; set; }
        public Time StartTime { get; set; }
        public Time EndTime { get; set; }
        public Constellation(string Name, Time StartTime, Time EndTime)
        {
            this.Name = Name;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
        }
    }
    class Time
    {
        public int Month { set; get; }
        public int Day { set; get; }
        public Time(int Month, int Day)
        {
            this.Month = Month;
            this.Day = Day;
        }
    }
}
