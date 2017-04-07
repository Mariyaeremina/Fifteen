using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsUniversity
{
    class Day
    {
        public string Date;
        public DayOfWeek WeekDay;
        public Lesson[] Lessons;

        public Day()
        {
            Lessons = new Lesson[5];
        }
    }
}
