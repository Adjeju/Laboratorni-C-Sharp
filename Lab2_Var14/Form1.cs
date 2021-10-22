using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Var14
{
    public partial class Form1 : Form
    {
        List<Auto> autoList = new List<Auto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (AutoContex autoDB = new AutoContex())
            {
                autoList = autoDB.Auto.ToList<Auto>();
            }

            dataGridView1.DataSource = autoList;
        }
    }
}
