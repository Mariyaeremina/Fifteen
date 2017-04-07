using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsUniversity
{
    class Faculty
    {
        public string Name;
        public Auditory[] Auditories;
        public Direction[] Directions;

        public Faculty()
        {
            Directions = new Direction[3];
            Auditories = new Auditory[3];
        }
    }
}
