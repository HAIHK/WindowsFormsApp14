using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txt1.Text);
            b = Convert.ToDouble(txt2.Text);
            c = Convert.ToDouble(txt3.Text);
            if (a == 0)
            {
                if (b == 0)
                    {
                        txt4.Text = "Phuong trinh vo nghiem";
                    }
                    else
                    {
                        txt4.Text = "Phuong trinh co mot nghiem la " + ((-c / b));
                    }
                }
                else
                {
                    double delta = b * b - 4 * a * c;
                    double x1;
                    double x2;

                    if (delta < 0)
                    {
                        txt4.Text = "Phuong trinh vo nghiem";
                    }
                    else if (delta == 0)
                    {
                        txt4.Text = "Phuong trinh co mot nghiem " + ((-b) / (2 * a));
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                        txt4.Text = "Phuong trinh co hai nghiem" + " X1 = " + x1 + " , " + " X2 = " + x2;
                    }
                }
            }
            private void label4_Click(object sender, EventArgs e)
            {

            }
        }
    }
