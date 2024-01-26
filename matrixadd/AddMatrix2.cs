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
    public partial class AddMatrix2 : Form
    {
        public AddMatrix2()
        {
            InitializeComponent();
        }

        public void Result_Click(object sender, EventArgs e)
        {
            string a11 = mean111.Text;
            string a12 = mean112.Text;
            string a21 = mean121.Text;
            string a22 = mean122.Text;

            string b11 = mean211.Text;
            string b12 = mean212.Text;
            string b21 = mean221.Text;
            string b22 = mean222.Text;

            int a11_1 = 0; int a12_1 = 0; int a21_1 = 0; int a22_1 = 0;
            int b11_1 = 0; int b12_1 = 0; int b21_1 = 0; int b22_1 = 0;
            int ab11 = 0; int ab12 = 0; int ab21 = 0; int ab22 = 0;

            if (mean111.Text == "" || mean112.Text == "" || mean121.Text == "" || mean122.Text == "" || mean211.Text == "" || mean212.Text == "" || mean221.Text == "" || mean222.Text == "")
            {
                MessageBox.Show("Введите значения!");

                return;
            }
            try
            {
                a11_1 = Convert.ToInt32(a11);
                a12_1 = Convert.ToInt32(a12);
                a21_1 = Convert.ToInt32(a21);
                a22_1 = Convert.ToInt32(a22);

                b11_1 = Convert.ToInt32(b11);
                b12_1 = Convert.ToInt32(b12);
                b21_1 = Convert.ToInt32(b21);
                b22_1 = Convert.ToInt32(b22);

                ab11 = a11_1 + b11_1;
                ab12 = a12_1 + b12_1;
                ab21 = a21_1 + b21_1;
                ab22 = a22_1 + b22_1;

                res11.Text = ab11.ToString();
                res12.Text = ab12.ToString();
                res21.Text = ab21.ToString();
                res22.Text = ab22.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Введите численные значения!");
                Console.WriteLine("{0} Expection caught.", err);
            }
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


        public void reset_Click(object sender, EventArgs e)
        {

            string a11 = "";
            mean111.Text = a11.ToString();
            string a12 = "";
            mean112.Text = a12.ToString();
            string a21 = "";
            mean121.Text = a21.ToString();
            string a22 = "";
            mean122.Text = a22.ToString();

            string b11 = "";
            mean211.Text = b11.ToString();
            string b12 = "";
            mean212.Text = b12.ToString();
            string b21 = "";
            mean221.Text = b21.ToString();
            string b22 = "";
            mean222.Text = b22.ToString();

            string ab11 = "";
            res11.Text = ab11.ToString();
            string ab12 = "";
            res12.Text = ab12.ToString();
            string ab21 = "";
            res21.Text = ab21.ToString();
            string ab22 = "";
            res22.Text = ab22.ToString();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
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
    }
}
