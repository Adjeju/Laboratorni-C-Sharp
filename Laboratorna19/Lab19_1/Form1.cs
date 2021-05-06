using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab19_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string[] row = sr.ReadLine().Split();
                double[] numbers = new double[row.Length];
                double maxNum = -100000;
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToDouble(row[i]);
                }
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < 0 && maxNum < numbers[i]) maxNum = numbers[i];
                }
                label2.Text = maxNum.ToString();
                label1.Visible = true;
                label2.Visible = true;

            }
        }
    }
}
