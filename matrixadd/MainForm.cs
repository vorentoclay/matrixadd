using Mysqlx.Session;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void matrix2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMatrix2 add2 = new AddMatrix2();
            add2.Show();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void matrix3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMatrix3 add3 = new AddMatrix3();
            add3.Show();
        }

        private void matrix4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMatrix4 add4 = new AddMatrix4();
            add4.Show();
        }
    }
}
