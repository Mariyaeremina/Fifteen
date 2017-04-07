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
    public partial class GroupForm : Form
    {

        private University csu;
        private Label text1;
        private Label text2;
        private Label text3;
        private Button choose;
        private ComboBox input1;
        private ComboBox input2;
        private ComboBox input3;

        private void initialization()
        {
            csu = University.CreateUniversity();

            text1 = new Label();
            text1.Text = "Выберите факультет";
            Controls.Add(text1);

            text2 = new Label();
            text2.Text = "Выберите направление";
            Controls.Add(text2);

            text3 = new Label();
            text3.Text = "Выберите группу";
            Controls.Add(text3);

            choose = new Button();
            choose.Text = "Далее";
            Controls.Add(choose);

            input1 = new ComboBox();
            foreach (Faculty f in csu.Faculties)
            {
                input1.Items.Add(f.Name);
            }
            Controls.Add(input1);

            input2 = new ComboBox();
            input2.Enabled = false;
            Controls.Add(input2);

            input3 = new ComboBox();
            input3.Enabled = false;
            Controls.Add(input3);
        }
        public GroupForm()
        {
            initialization();
            MinimumSize = new Size(500, 400);
            CenterToScreen();
            Text = "Выбор группы";

            Load += (sender, args) => OnSizeChanged(EventArgs.Empty);
            SizeChanged += (sender, args) =>
            {
                changePosition(text1, 200, 20, (ClientSize.Width - 200) / 2, (ClientSize.Height - 250) / 2);
                changePosition(input1, 200, 50, (ClientSize.Width - 200) / 2, text1.Bottom);
                changePosition(text2, 200, 20, (ClientSize.Width - 200) / 2, input1.Bottom + 15);
                changePosition(input2, 200, 50, (ClientSize.Width - 200) / 2, text2.Bottom);
                changePosition(text3, 200, 20, (ClientSize.Width - 200) / 2, input2.Bottom + 15);
                changePosition(input3, 200, 50, (ClientSize.Width - 200) / 2, text3.Bottom);
                changePosition(choose, 100, 30, (ClientSize.Width - 100) / 2, input3.Bottom + 15);
            };

            input1.SelectedIndexChanged += (sender, args) =>
            {
                input2.Enabled = true;
                input2.Items.Clear();
                for (int i = 0; i < csu.Faculties.Length; i++)
                {
                    if (input1.Text == csu.Faculties[i].Name)
                    {
                        foreach (Direction d in csu.Faculties[i].Directions)
                        {
                            input2.Items.Add(d.Name);
                        }
                    }
                }
            };

        }

        private void changePosition(Control control, int width, int height, int x, int y)
        {
            control.Size = new Size(width, height);
            control.Location = new Point(x, y);
        }
    }
}
