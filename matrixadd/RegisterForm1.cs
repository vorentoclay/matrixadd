using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrixadd
{
    public partial class RegisterForm1 : Form
    {
        public RegisterForm1()
        {
            InitializeComponent();

            this.password.AutoSize = false;
            this.password.Size = new Size(this.password.Size.Width, 57);

            nameuser.Text = "Введите логин";
            nameuser.ForeColor = Color.Gray;

            password.Text = "Введите пароль";
            password.ForeColor = Color.Gray;

            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;

            userSurField.Text = "Введите фамилию";
            userSurField.ForeColor = Color.Gray;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя" && userSurField.Text == "Введите фамилию" && password.Text == "Введите пароль" && nameuser.Text == "Введите логин")
            {
                MessageBox.Show("Заполните все поля регистрации!");
                return;
            }
            if (userNameField.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя!");
                return;
            }
            if (userSurField.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию!");
                return;
            }
            if (password.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }
            if (nameuser.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (checkUser())

                return;

            DataBase db = new DataBase();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login, @password, @name, @surname)", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = nameuser.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurField.Text;

            db.OpenBD();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт успешно создан.");
            else
                MessageBox.Show("Аккаунт не был создан.");

            db.CloseBD();
        }

        public Boolean checkUser()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @LU", db.GetConnection());
            command.Parameters.Add("@LU", MySqlDbType.VarChar).Value = nameuser.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже зарегистрирован, введите другой.");
                return true;
            }
            else
                return false;
        }


       


        private void AutorizLable_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void nameuser_Enter(object sender, EventArgs e)
        {
            if (nameuser.Text == "Введите логин")
            {
                nameuser.Text = "";
                nameuser.ForeColor = Color.Black;
            }
        }

        private void nameuser_Leave(object sender, EventArgs e)
        {
            if (nameuser.Text == "")
            {
                nameuser.Text = "Введите логин";
                nameuser.ForeColor = Color.Gray;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Введите пароль";
                password.ForeColor = Color.Gray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Введите пароль")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userSurField_Enter(object sender, EventArgs e)
        {
            if (userSurField.Text == "Введите фамилию")
            {
                userSurField.Text = "";
                userSurField.ForeColor = Color.Black;
            }
        }

        private void userSurField_Leave(object sender, EventArgs e)
        {
            if (userSurField.Text == "")
            {
                userSurField.Text = "Введите фамилию";
                userSurField.ForeColor = Color.Gray;
            }
        }

        Point lastPoint;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void mainPanel_Click(object sender, EventArgs e)
        {

        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Green;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.White;
        }
    }
}
