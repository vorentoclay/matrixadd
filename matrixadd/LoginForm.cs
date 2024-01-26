using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrixadd
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.password.AutoSize = false;
            this.password.Size = new Size(this.password.Size.Width, 70);

            nameuser.Text = "Введите логин";
            nameuser.ForeColor = Color.Gray;

            password.Text = "Введите пароль";
            password.ForeColor = Color.Gray;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Green;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.White;
        }



        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            String Login_User = nameuser.Text;
            String Pass_User = password.Text;

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @LU AND `password` = @PU", db.GetConnection());

            command.Parameters.Add("@LU", MySqlDbType.VarChar).Value = Login_User;
            command.Parameters.Add("@PU", MySqlDbType.VarChar).Value = Pass_User;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                
                if ((nameuser.Text == "Введите логин" || nameuser.Text == "") && (password.Text == "Введите пароль" || password.Text == ""))
                {
                    MessageBox.Show("Введите логин и пароль!");
                }
            
                if ((nameuser.Text == "Введите логин" || nameuser.Text == "") && (password.Text != "Введите пароль"))
                {
                    MessageBox.Show("Введите логин!");
                }
                
                if ((password.Text == "Введите пароль" || password.Text == "") && (nameuser.Text != "Введите логин"))
                {
                    MessageBox.Show("Введите пароль!");
                }
                
                if (nameuser.Text != "Введите логин" && password.Text != "Введите пароль")
                {
                    MessageBox.Show("Пользователь не авторизован.");
                }
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

        private void RegisterLable_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm1 registerForm = new RegisterForm1();
            registerForm.Show();
        }

        private void nameuser_TextChanged(object sender, EventArgs e)
        {

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
    }
}
