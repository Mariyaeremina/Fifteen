using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsUniversity
{
    class University
    {
        public Faculty[] Faculties;

        public University(int value)
        {
            Faculties = new Faculty[value];
        }

        public static University CreateUniversity()
        {
            University tempUni = new University(2);
            //заполнение факультетов
            tempUni.Faculties[0] = new Faculty() { Name = "ИИТ" };
            tempUni.Faculties[1] = new Faculty() { Name = "Филфак" };

            //заполнение направлений
            tempUni.Faculties[0].Directions[0] = new Direction() { Name = "Бизнес-информатика" };
            tempUni.Faculties[0].Directions[1] = new Direction() { Name = "Информатика и вычислительная техника" };
            tempUni.Faculties[0].Directions[2] = new Direction() { Name = "Прикладная информатика" };

            //заполнение групп
            tempUni.Faculties[0].Directions[0].Groups[0] = new Group() { Name = "БИ-101" };
            tempUni.Faculties[0].Directions[0].Groups[1] = new Group() { Name = "БИ-202" };
            tempUni.Faculties[0].Directions[0].Groups[2] = new Group() { Name = "БИ-303" };

            tempUni.Faculties[0].Directions[1].Groups[0] = new Group() { Name = "ИВТ-101" };
            tempUni.Faculties[0].Directions[1].Groups[1] = new Group() { Name = "ИВТ-202" };
            tempUni.Faculties[0].Directions[1].Groups[2] = new Group() { Name = "ИВТ-303" };

            tempUni.Faculties[0].Directions[2].Groups[0] = new Group() { Name = "ПИ-101" };
            tempUni.Faculties[0].Directions[2].Groups[1] = new Group() { Name = "ПИ-202" };
            tempUni.Faculties[0].Directions[2].Groups[2] = new Group() { Name = "ПИ-303" };

            //заполнение направлений
            tempUni.Faculties[1].Directions[0] = new Direction() { Name = "История литературы" };
            tempUni.Faculties[1].Directions[1] = new Direction() { Name = "Отечественая филология" };
            tempUni.Faculties[1].Directions[2] = new Direction() { Name = "Культурология" };

            //заполнение групп
            tempUni.Faculties[1].Directions[0].Groups[0] = new Group() { Name = "ИЛ-101" };
            tempUni.Faculties[1].Directions[0].Groups[1] = new Group() { Name = "ИЛ-202" };
            tempUni.Faculties[1].Directions[0].Groups[2] = new Group() { Name = "ИЛ-303" };

            tempUni.Faculties[1].Directions[1].Groups[0] = new Group() { Name = "ОФ-101" };
            tempUni.Faculties[1].Directions[1].Groups[1] = new Group() { Name = "ОФ-202" };
            tempUni.Faculties[1].Directions[1].Groups[2] = new Group() { Name = "ОФ-303" };

            tempUni.Faculties[1].Directions[2].Groups[0] = new Group() { Name = "K-101" };
            tempUni.Faculties[1].Directions[2].Groups[1] = new Group() { Name = "K-202" };
            tempUni.Faculties[1].Directions[2].Groups[2] = new Group() { Name = "K-303" };

            return tempUni;
        }
    }
}
