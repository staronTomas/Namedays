using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namedays
{
    // Record
    public record DayMonth(int Day, int month);


    // Record
    struct DayMonth
    {
        public int Day { get; }
        public int Month { get; }

        public DayMonth(int day, int month)
        {
            Day = day;
            Month = month;
        }

        public DayMonth() : this(1, 1) { }

        public DateTime ToDateTime()
        {
            return new DateTime(DateTime.Now.Year, Month, Day);
        }
    }

    struct Nameday
    {
        public string Name { get; }
        public DayMonth DayMonth { get; }

        public Nameday(string name, DayMonth dayMonth)
        {
            Name = name;
            DayMonth = dayMonth;
        }

        public Nameday() : this("", new DayMonth()) { }
    }


}
