using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0,01655";
            textBox2.Text = "-2,75";
            textBox3.Text = "0,15";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = Environment.NewLine;
            double x = double.Parse(textBox1.Text);
            richTextBox1.Text += Environment.NewLine+
                "x=" + x.ToString();
            double y = double.Parse(textBox2.Text);
            richTextBox1.Text += Environment.NewLine +
                "y=" + y.ToString();
            double z = double.Parse(textBox3.Text);
            richTextBox1.Text += Environment.NewLine +
                "z=" + z.ToString();
            double a = 10 * (Math.Pow(x, (1.0 / 3)) + Math.Pow(x, (y + 2)));
            double b = Math.Sqrt(a);
            double c = Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y);
            double d = b * c;
            richTextBox1.Text += Environment.NewLine;
            richTextBox1.Text += Environment.NewLine +
                 "1=" + b.ToString();
            richTextBox1.Text += Environment.NewLine +
                 "2=" + c.ToString();
            richTextBox1.Text += Environment.NewLine;
            richTextBox1.Text += Environment.NewLine +
                 "β=" + d.ToString();
            richTextBox1.Text += Environment.NewLine +
                 "____________________________________";
            textBox5.Text += Environment.NewLine +
                 d.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}