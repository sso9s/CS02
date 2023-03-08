using System;
using System.Windows.Forms;

namespace _002_bmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height, weight;

            height = double.Parse(textBox1.Text);
            weight = double.Parse(textBox2.Text);

            double bmi = weight / (height / 100 * height / 100);
            label3.Text = "BMI = " + bmi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
