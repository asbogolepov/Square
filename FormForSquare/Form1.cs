using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormForSquare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                textBox4.Text = Square.Triangle.SquareTriangle(a, b, c).ToString("#.##");
                textBox5.Text = Square.Triangle.PerimHalf(a, b, c).ToString("#.##");

                label2.Text = Square.Triangle.IsRightTriangle(a, b, c).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Проверьте введенные данные" );
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double r = System.Double.Parse(textBox6.Text);
                label1.Text = Square.Circle.SquareCircle(r).ToString("#.##");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Проверьте введенные данные");
            }
        }
    }
}
