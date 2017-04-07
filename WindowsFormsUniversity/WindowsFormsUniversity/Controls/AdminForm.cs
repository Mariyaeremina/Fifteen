using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUniversity
{
    public partial class AdminForm : Form
    {
        private TabControl main;
        private TabPage addSubject;
        private TabPage changeSceduele;
        private TabPage seeSceduele;
        private Button saveAll;
        private Button saveChange;
        private Button saveAdd;
        private Button exit;

        private void initialization()
        {
            main = new TabControl();
            Controls.Add(main);

            addSubject = new TabPage();
            addSubject.Text = "Добавить занятие";
            main.Controls.Add(addSubject);

            changeSceduele = new TabPage();
            changeSceduele.Text = "Внести изменения";
            main.Controls.Add(changeSceduele);

            seeSceduele = new TabPage();
            seeSceduele.Text = "Посмотреть расписание";
            main.Controls.Add(seeSceduele);

            saveAdd = new Button();
            saveAdd.Text = "Добавить занятие";
            addSubject.Controls.Add(saveAdd);

            saveChange = new Button();
            saveChange.Text = "Изменить";
            changeSceduele.Controls.Add(saveChange);

            saveAll = new Button();
            saveAll.Text = "Сохранить";
            Controls.Add(saveAll);

            exit = new Button();
            exit.Text = "Выход";
            Controls.Add(exit);
        }
        public AdminForm()
        {
            initialization();
        }
    }
}
