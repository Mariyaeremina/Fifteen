using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsUniversity
{
    class AuthorizationForm : Form
    {
        private Label login;
        private Label password;
        private TextBox inputLogin;
        private TextBox inputPassword;
        private CheckBox student;
        private CheckBox teacher;
        private CheckBox admin;
        private Button exit;
        private Button entry;

        private void initialization()
        {
            login = new Label();
            login.Text = "Логин:";
            Controls.Add(login);

            password = new Label();
            password.Text = "Пароль:";
            Controls.Add(password);

            inputLogin = new TextBox();
            Controls.Add(inputLogin);

            inputPassword = new TextBox();
            Controls.Add(inputPassword);

            student = new CheckBox();
            student.Text = "Студент";
            Controls.Add(student);

            teacher = new CheckBox();
            teacher.Text = "Преподаватель";
            Controls.Add(teacher);

            admin = new CheckBox();
            admin.Text = "Администатор";
            Controls.Add(admin);

            exit = new Button();
            exit.Text = "Выход";
            Controls.Add(exit);

            entry = new Button();
            entry.Text = "Войти";
            Controls.Add(entry);
        }
        

        public AuthorizationForm()
        {
            initialization();
            MinimumSize = new Size(500, 400);
            CenterToScreen();
            Text = "Авторизация";
            
            Load += (sender, args) => OnSizeChanged(EventArgs.Empty);
            SizeChanged += (sender, args) =>
            {
                changePosition(login, 50, 30, (ClientSize.Width - 50) / 2, (ClientSize.Height - 250) / 2);
                changePosition(inputLogin, 200, 50, (ClientSize.Width - 200) / 2, login.Bottom);
                changePosition(password, login.Width, login.Height, (ClientSize.Width - login.Width) / 2, inputLogin.Bottom + 20);
                changePosition(inputPassword, 200, 50, (ClientSize.Width - 200) / 2, password.Bottom);
                changePosition(student, 150, 20, (ClientSize.Width - 200) / 2, inputPassword.Bottom);
                changePosition(teacher, 150, 20, (ClientSize.Width - 200) / 2, student.Bottom);
                changePosition(admin, 150, 20, (ClientSize.Width - 200) / 2, teacher.Bottom);
                changePosition(exit, 50, 30, (ClientSize.Width - inputLogin.Width) / 2, admin.Bottom + 20);
                changePosition(entry, 50, 30, (ClientSize.Width - inputLogin.Width) / 2 + 150, admin.Bottom + 20);
            };

            student.Click += (sender, args) =>
            {
                admin.Checked = false;
                teacher.Checked = false;
                Authorization.User = "student";
            };

            teacher.Click += (sender, args) =>
            {
                admin.Checked = false;
                student.Checked = false;
                Authorization.User = "teacher";
            };

            admin.Click += (sender, args) =>
            {
                student.Checked = false;
                teacher.Checked = false;
                Authorization.User = "admin";
            };

            entry.Click += (sender, args) =>
            {
                if (Authorization.RightAuthorize(inputLogin.Text, inputPassword.Text))
                {
                    if (Authorization.User == "student")
                    {
                        GroupForm form = new GroupForm();
                        form.Show();
                    }

                    else if (Authorization.User == "teacher")
                    {
                        GroupForm form = new GroupForm();
                        form.Show();
                    }

                    else if (Authorization.User == "admin")
                    {
                        GroupForm form = new GroupForm();
                        form.Show();
                    }
                }
                else
                {
                    var result = MessageBox.Show("Введенные данные не верны. Попробуйте еще раз.", "", MessageBoxButtons.OK);
                }
            };

            exit.Click += (sender, args) =>
            {
                Close();
            };
        }

        private void changePosition(Control control, int width, int height, int x, int y)
        {
            control.Size = new Size(width, height);
            control.Location = new Point(x, y);
        }
    }
}
