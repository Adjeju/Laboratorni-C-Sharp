using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Lab3_Var15
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
            using(AutoContex autoDB = new AutoContex())
            {
                autoList = autoDB.Autoes.ToList<Auto>();
            }
            dataGridView1.DataSource = autoList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            using (AutoContex autoDB = new AutoContex())
            {
                autoList = autoDB.Autoes.ToList<Auto>()
                    .Where((auto)=> auto.Year == "2020").ToList<Auto>();
            }

            dataGridView1.DataSource = autoList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            using (AutoContex autoDB = new AutoContex())
            {
                autoList = autoDB.Autoes.ToList<Auto>().
                    OrderByDescending((auto)=>auto.Volume)
                    .Take(1)
                    .ToList<Auto>();
            }

            dataGridView1.DataSource = autoList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            using (AutoContex autoDB = new AutoContex())
            {
                var autoList = autoDB.Autoes.ToList<Auto>()
                    .GroupBy((auto) => auto.Price);

                dataGridView1.DataSource = null;

                dataGridView1.Columns.Add("GroupBy price", null);
                dataGridView1.Columns.Add("Count", null);

                foreach(var auto in autoList)
                {
                    dataGridView1.Rows.Add(auto.Key, auto.Count());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            using (AutoContex autoDB = new AutoContex())
            {
                autoList = autoDB.Autoes.ToList<Auto>();
            }
            dataGridView1.DataSource = autoList;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            using (AutoContex autoDB = new AutoContex())
            {
                autoList = autoDB.Autoes.ToList<Auto>();
                autoList.ForEach(auto => auto.Price += 15);

            }
            MessageBox.Show("File -> Save");
            dataGridView1.DataSource = autoList;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string json = JsonConvert.SerializeObject(autoList, Formatting.Indented);
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.Write(json);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            using (AutoContex autoDB = new AutoContex())
            {
                autoList = autoDB.Autoes.ToList<Auto>()
                    .OrderBy(auto=> auto.Volume).Skip(1).ToList<Auto>();
            }
            dataGridView1.DataSource = autoList;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (AutoContex autoDB = new AutoContex())
            {
                MessageBox.Show($"price > 10: {autoDB.Autoes.ToList<Auto>().All(auto=> auto.Price == 10)}");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (AutoContex autoDB = new AutoContex())
            {
                MessageBox.Show($"price > 10: {autoDB.Autoes.ToList<Auto>().Any(auto => auto.Price == 10)}");
            }
        }
    }
}
