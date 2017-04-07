using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsUniversity
{
    class Direction
    {
        public string Name;
        public Group[] Groups;
        public string FacultyName;
        public Course[] Courses;
        
        public Direction()
        {
            Groups = new Group[3];
            Courses = new Course[3];
        }
    }
}
