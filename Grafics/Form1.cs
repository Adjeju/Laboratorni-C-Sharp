using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            int n = (int)numericUpDown1.Value;
            chart1.Series[0].Points.Clear();
            double h = (b - a) / n;
            double x = a;
            while (x <= b)
            {
                chart1.Series[0].Points.AddXY(x, Math.Sin(x));
                x += h;
            }

        }
    }
}
