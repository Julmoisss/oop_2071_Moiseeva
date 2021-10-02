using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;

            bool result1 = int.TryParse(textBox1.Text, out number);
            bool result2 = int.TryParse(textBox2.Text, out number);
            bool result3 = int.TryParse(textBox3.Text, out number);
            bool result4 = int.TryParse(textBox4.Text, out number);

            int num1 = Convert.ToInt32(textBox1.Text);
            int den1 = Convert.ToInt32(textBox2.Text);
            int num2 = Convert.ToInt32(textBox3.Text);
            int den2 = Convert.ToInt32(textBox4.Text);

            Rational r1 = new Rational(num1, den1);
            Rational r2 = new Rational(num2, den2);
            if (den1 == 0 | den2 == 0)
                {
                    textBox7.Text = "Вычисления невозможны так как знаменатель равен 0";
                    textBox8.Text = "Вычисления невозможны так как знаменатель равен 0";
                    textBox9.Text = "Вычисления невозможны так как знаменатель равен 0";
                    textBox10.Text = "Вычисления невозможны так как знаменатель равен 0";
                    return;
                }

            Rational r3 = r1.Sum(r2);
            textBox7.Text = r3.ToString();

            Rational r4 = r1.Subtrac(r2);
            textBox8.Text = r4.ToString();

            Rational r5 = r1.Multiply(r2);
            textBox9.Text = r5.ToString();

            Rational r6 = r1.Divide(r2);
            textBox10.Text = r6.ToString();
        }
    }
}
