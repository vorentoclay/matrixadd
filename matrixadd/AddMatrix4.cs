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
    public partial class AddMatrix4 : Form
    {
        public AddMatrix4()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Green;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.White;
        }

        private void Result_Click(object sender, EventArgs e)
        {
            string a11 = mean111.Text;
            string a12 = mean112.Text;
            string a13 = mean113.Text;
            string a14 = mean114.Text;
            string a21 = mean121.Text;
            string a22 = mean122.Text;
            string a23 = mean123.Text;
            string a24 = mean124.Text;
            string a31 = mean131.Text;
            string a32 = mean132.Text;
            string a33 = mean133.Text;
            string a34 = mean134.Text;
            string a41 = mean141.Text;
            string a42 = mean142.Text;
            string a43 = mean143.Text;
            string a44 = mean144.Text;

            string b11 = mean211.Text;
            string b12 = mean212.Text;
            string b13 = mean213.Text;
            string b14 = mean214.Text;
            string b21 = mean221.Text;
            string b22 = mean222.Text;
            string b23 = mean223.Text;
            string b24 = mean224.Text;
            string b31 = mean231.Text;
            string b32 = mean232.Text;
            string b33 = mean233.Text;
            string b34 = mean234.Text;
            string b41 = mean241.Text;
            string b42 = mean242.Text;
            string b43 = mean243.Text;
            string b44 = mean244.Text;

            int a11_1 = 0; int a12_1 = 0; int a13_1 = 0; int a14_1 = 0; int a21_1 = 0; int a22_1 = 0; int a23_1 = 0; int a24_1 = 0; int a31_1 = 0; int a32_1 = 0; int a33_1 = 0; int a34_1 = 0; int a41_1 = 0; int a42_1 = 0; int a43_1 = 0; int a44_1 = 0;
            int b11_1 = 0; int b12_1 = 0; int b13_1 = 0; int b14_1 = 0; int b21_1 = 0; int b22_1 = 0; int b23_1 = 0; int b24_1 = 0; int b31_1 = 0; int b32_1 = 0; int b33_1 = 0; int b34_1 = 0; int b41_1 = 0; int b42_1 = 0; int b43_1 = 0; int b44_1 = 0;
            int ab11 = 0; int ab12 = 0; int ab13 = 0; int ab14 = 0; int ab21 = 0; int ab22 = 0; int ab23 = 0; int ab24 = 0; int ab31 = 0; int ab32 = 0; int ab33 = 0; int ab34 = 0; int ab41 = 0; int ab42 = 0; int ab43 = 0; int ab44 = 0;

            if (mean111.Text == "" || mean112.Text == "" || mean113.Text == "" || mean114.Text == "" || mean121.Text == "" || mean122.Text == "" || mean123.Text == "" || mean124.Text == "" || mean131.Text == "" || mean132.Text == "" || mean133.Text == "" || mean134.Text == "" || mean141.Text == "" || mean142.Text == "" || mean143.Text == "" || mean144.Text == "" || mean211.Text == "" || mean212.Text == "" || mean213.Text == "" || mean214.Text == "" || mean221.Text == "" || mean222.Text == "" || mean223.Text == "" || mean224.Text == "" || mean231.Text == "" || mean232.Text == "" || mean233.Text == "" || mean234.Text == "" || mean241.Text == "" || mean242.Text == "" || mean243.Text == "" || mean244.Text == "")
            {
                MessageBox.Show("Введите значения!");

                return;
            }
            try
            {
                a11_1 = Convert.ToInt32(a11);
                a12_1 = Convert.ToInt32(a12);
                a13_1 = Convert.ToInt32(a13);
                a14_1 = Convert.ToInt32(a14);
                a21_1 = Convert.ToInt32(a21);
                a22_1 = Convert.ToInt32(a22);
                a23_1 = Convert.ToInt32(a23);
                a24_1 = Convert.ToInt32(a24);
                a31_1 = Convert.ToInt32(a31);
                a32_1 = Convert.ToInt32(a32);
                a33_1 = Convert.ToInt32(a33);
                a34_1 = Convert.ToInt32(a34);
                a41_1 = Convert.ToInt32(a41);
                a42_1 = Convert.ToInt32(a42);
                a43_1 = Convert.ToInt32(a43);
                a44_1 = Convert.ToInt32(a44);

                b11_1 = Convert.ToInt32(b11);
                b12_1 = Convert.ToInt32(b12);
                b13_1 = Convert.ToInt32(b13);
                b14_1 = Convert.ToInt32(b14);
                b21_1 = Convert.ToInt32(b21);
                b22_1 = Convert.ToInt32(b22);
                b23_1 = Convert.ToInt32(b23);
                b24_1 = Convert.ToInt32(b24);
                b31_1 = Convert.ToInt32(b31);
                b32_1 = Convert.ToInt32(b32);
                a33_1 = Convert.ToInt32(b33);
                a34_1 = Convert.ToInt32(b34);
                b41_1 = Convert.ToInt32(b41);
                b42_1 = Convert.ToInt32(b42);
                a43_1 = Convert.ToInt32(b43);
                a44_1 = Convert.ToInt32(b44);

                ab11 = a11_1 + b11_1;
                ab12 = a12_1 + b12_1;
                ab13 = a13_1 + b13_1;
                ab14 = a14_1 + b14_1;
                ab21 = a21_1 + b21_1;
                ab22 = a22_1 + b22_1;
                ab23 = a23_1 + b23_1;
                ab24 = a24_1 + b24_1;
                ab31 = a31_1 + b31_1;
                ab32 = a32_1 + b32_1;
                ab33 = a33_1 + b33_1;
                ab34 = a34_1 + b34_1;
                ab41 = a41_1 + b41_1;
                ab42 = a42_1 + b42_1;
                ab43 = a43_1 + b43_1;
                ab44 = a44_1 + b44_1;


                res11.Text = ab11.ToString();
                res12.Text = ab12.ToString();
                res13.Text = ab13.ToString();
                res14.Text = ab14.ToString();
                res21.Text = ab21.ToString();
                res22.Text = ab22.ToString();
                res23.Text = ab23.ToString();
                res24.Text = ab24.ToString();
                res31.Text = ab31.ToString();
                res32.Text = ab32.ToString();
                res33.Text = ab33.ToString();
                res34.Text = ab34.ToString();
                res41.Text = ab41.ToString();
                res42.Text = ab42.ToString();
                res43.Text = ab43.ToString();
                res44.Text = ab44.ToString();

            }
            catch (Exception err)
            {
                MessageBox.Show("Введите численные значения!");
                Console.WriteLine("{0} Expection caught.", err);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            string a11 = "";
            mean111.Text = a11.ToString();
            string a12 = "";
            mean112.Text = a12.ToString();
            string a13 = "";
            mean113.Text = a13.ToString();
            string a14 = "";
            mean114.Text = a14.ToString();
            string a21 = "";
            mean121.Text = a21.ToString();
            string a22 = "";
            mean122.Text = a22.ToString();
            string a23 = "";
            mean123.Text = a23.ToString();
            string a24 = "";
            mean124.Text = a24.ToString();
            string a31 = "";
            mean131.Text = a31.ToString();
            string a32 = "";
            mean132.Text = a32.ToString();
            string a33 = "";
            mean133.Text = a33.ToString();
            string a34 = "";
            mean134.Text = a34.ToString();
            string a41 = "";
            mean141.Text = a41.ToString();
            string a42 = "";
            mean142.Text = a42.ToString();
            string a43 = "";
            mean143.Text = a43.ToString();
            string a44 = "";
            mean144.Text = a44.ToString();


            string b11 = "";
            mean211.Text = b11.ToString();
            string b12 = "";
            mean212.Text = b12.ToString();
            string b13 = "";
            mean213.Text = b13.ToString();
            string b14 = "";
            mean214.Text = b14.ToString();
            string b21 = "";
            mean221.Text = b21.ToString();
            string b22 = "";
            mean222.Text = b22.ToString();
            string b23 = "";
            mean223.Text = b23.ToString();
            string b24 = "";
            mean224.Text = b24.ToString();
            string b31 = "";
            mean231.Text = b31.ToString();
            string b32 = "";
            mean232.Text = b32.ToString();
            string b33 = "";
            mean233.Text = b33.ToString();
            string b34 = "";
            mean234.Text = b34.ToString();
            string b41 = "";
            mean241.Text = b41.ToString();
            string b42 = "";
            mean242.Text = b42.ToString();
            string b43 = "";
            mean243.Text = b43.ToString();
            string b44 = "";
            mean244.Text = b44.ToString();


            string ab11 = "";
            res11.Text = ab11.ToString();
            string ab12 = "";
            res12.Text = ab12.ToString();
            string ab13 = "";
            res13.Text = ab13.ToString();
            string ab14 = "";
            res14.Text = ab14.ToString();
            string ab21 = "";
            res21.Text = ab21.ToString();
            string ab22 = "";
            res22.Text = ab22.ToString();
            string ab23 = "";
            res23.Text = ab23.ToString();
            string ab24 = "";
            res24.Text = ab24.ToString();
            string ab31 = "";
            res31.Text = ab31.ToString();
            string ab32 = "";
            res32.Text = ab32.ToString();
            string ab33 = "";
            res33.Text = ab33.ToString();
            string ab34 = "";
            res34.Text = ab34.ToString();
            string ab41 = "";
            res41.Text = ab41.ToString();
            string ab42 = "";
            res42.Text = ab42.ToString();
            string ab43 = "";
            res43.Text = ab43.ToString();
            string ab44 = "";
            res44.Text = ab44.ToString();
        }
    }
}
