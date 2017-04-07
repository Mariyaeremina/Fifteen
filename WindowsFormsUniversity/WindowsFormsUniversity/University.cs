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
            tempUni.Faculties[0] = new Faculty();
            tempUni.Faculties[1] = new Faculty();
            //заполнение факультетов
            tempUni.Faculties[0].Name = "ИИТ";
            tempUni.Faculties[1].Name = "Филфак";

            //заполнение направлений
            tempUni.Faculties[0].Directions[0].Name = "Бизнес-информатика";
            tempUni.Faculties[0].Directions[1].Name = "Информатика и вычислительная техника";
            tempUni.Faculties[0].Directions[2].Name = "Прикладная информатика";

            //заполнение групп
            tempUni.Faculties[0].Directions[0].Groups[0].Name = "БИ-101";
            tempUni.Faculties[0].Directions[0].Groups[2].Name = "БИ-202";
            tempUni.Faculties[0].Directions[0].Groups[3].Name = "БИ-303";

            tempUni.Faculties[0].Directions[1].Groups[0].Name = "ИВТ-101";
            tempUni.Faculties[0].Directions[1].Groups[2].Name = "ИВТ-202";
            tempUni.Faculties[0].Directions[1].Groups[3].Name = "ИВТ-303";

            tempUni.Faculties[0].Directions[2].Groups[0].Name = "ПИ-101";
            tempUni.Faculties[0].Directions[2].Groups[2].Name = "ПИ-202";
            tempUni.Faculties[0].Directions[2].Groups[3].Name = "ПИ-303";

            tempUni.Faculties[1].Directions[0].Name = "История литературы";
            tempUni.Faculties[1].Directions[1].Name = "Отечественая филология";
            tempUni.Faculties[1].Directions[2].Name = "Культурология";

            //заполнение групп
            tempUni.Faculties[1].Directions[0].Groups[0].Name = "ИЛ-101";
            tempUni.Faculties[1].Directions[0].Groups[2].Name = "ИЛ-202";
            tempUni.Faculties[1].Directions[0].Groups[3].Name = "ИЛ-303";

            tempUni.Faculties[1].Directions[1].Groups[0].Name = "ОФ-101";
            tempUni.Faculties[1].Directions[1].Groups[2].Name = "ОФ-202";
            tempUni.Faculties[1].Directions[1].Groups[3].Name = "ОФ-303";

            tempUni.Faculties[1].Directions[2].Groups[0].Name = "К-101";
            tempUni.Faculties[1].Directions[2].Groups[2].Name = "К-202";
            tempUni.Faculties[1].Directions[2].Groups[3].Name = "К-303";

            return tempUni;
        }
    }
}
