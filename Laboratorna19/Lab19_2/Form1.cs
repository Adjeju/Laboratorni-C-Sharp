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

namespace Lab19_2
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
                int rows = Convert.ToInt32(sr.ReadLine());
                int cols = Convert.ToInt32(sr.ReadLine());
                string[][] strMatrix = new string[rows][];
                int[,] matrix = new int[rows, cols];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    strMatrix[i] = sr.ReadLine().Split();
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = Convert.ToInt32(strMatrix[i][j]);
                    }
                }
                int maxElem = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (maxElem < matrix[i, j]) maxElem = matrix[i, j];
                    }
                }
                label1.Text = maxElem.ToString();
            }

        }
    }
}
