using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsUniversity
{
    class Scedule
    {
        public Day[] Week;
        public string GroupName;

        public Scedule()
        {
            Week = new Day[6];
        }

        public static Scedule CreateScedule(string groupName)
        {
            var MyScedule = new Scedule();


            return MyScedule;
        }
    }
}
