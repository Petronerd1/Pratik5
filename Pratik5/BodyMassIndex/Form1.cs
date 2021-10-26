using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyMassIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height, weight, bmi;
            height = Convert.ToDouble(textBox1.Text);
            weight = Convert.ToDouble(textBox2.Text);
            bmi = weight / (height * height);
            label4.Text = bmi.ToString();
            if (bmi < 18)
            {
                label6.Text = "Thin";
            }
            else if (bmi >= 18 && bmi < 25)
            {
                label6.Text = "Normal";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                label6.Text = "Fat";
            }
            else if (bmi >= 30 && bmi < 35)
            {
                label6.Text = "Obese";
            }
            else
            {
                label6.Text = "Extremely Obese";
            }
        }
    }
}
