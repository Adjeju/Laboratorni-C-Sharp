using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using System.IO;

namespace Var14
{
    public partial class Form1 : Form
    {
        private List<Auto> autoList = new List<Auto>();
        public Form1()
        {
            InitializeComponent();
        }
        private void setDataGrid()
        {
            dataGridView1.RowCount = autoList.Count;
            for (int i = 0; i < autoList.Count; i++)
            {
                dataGridView1[0, i].Value = autoList[i].Code;
                dataGridView1[1, i].Value = autoList[i].Mark;
                dataGridView1[2, i].Value = autoList[i].Color;
                dataGridView1[3, i].Value = autoList[i].Price;
                dataGridView1[4, i].Value = autoList[i].Year;
                dataGridView1[5, i].Value = autoList[i].Volume;
            }
            dataGridView1.RowCount++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            autoList.Add(new Auto()
            {
                Code = Convert.ToInt32(textBox1.Text),
                Mark = textBox2.Text,
                Color = textBox3.Text.ToLower(),
                Price = Convert.ToDouble(textBox4.Text),
                Year = textBox5.Text,
                Volume = Convert.ToDouble(textBox6.Text)
            });

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            setDataGrid();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.RowCount = 1;
            dataGridView1.Columns[0].HeaderText = "Code";
            dataGridView1.Columns[1].HeaderText = "Mark";
            dataGridView1.Columns[2].HeaderText = "Color";
            dataGridView1.Columns[3].HeaderText = "Price";
            dataGridView1.Columns[4].HeaderText = "Year";
            dataGridView1.Columns[5].HeaderText = "Volume";
        }

        private void saveAsXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string xmlFile = saveFileDialog1.FileName;
                using (XmlTextWriter writer = new XmlTextWriter(xmlFile, null))
                {
                    writer.Formatting = System.Xml.Formatting.Indented;
                    writer.Indentation = 3;
                    writer.WriteStartDocument();
                    writer.WriteStartElement("AutoList");
                    for (int i = 0; i < autoList.Count; i++)
                    {
                        writer.WriteStartElement("Auto");
                        writer.WriteElementString("Code", autoList[i].Code.ToString());
                        writer.WriteElementString("Mark", autoList[i].Mark.ToString());
                        writer.WriteElementString("Color", autoList[i].Color.ToString());
                        writer.WriteElementString("Price", autoList[i].Price.ToString());
                        writer.WriteElementString("Year", autoList[i].Year.ToString());
                        writer.WriteElementString("Volume", autoList[i].Volume.ToString());
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
            }
        }

        private void openXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string xmlFile = openFileDialog1.FileName;
                using (XmlTextReader reader = new XmlTextReader(xmlFile))
                {
                    reader.ReadStartElement("AutoList");
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Auto")
                        {
                            reader.ReadStartElement("Auto");
                            autoList.Add(new Auto()
                            {
                                Code = Convert.ToInt32(reader.ReadElementString("Code")),
                                Mark = reader.ReadElementString("Mark"),
                                Color = reader.ReadElementString("Color"),
                                Price = Convert.ToInt32(reader.ReadElementString("Price")),
                                Year = reader.ReadElementString("Year"),
                                Volume = Convert.ToDouble(reader.ReadElementString("Volume")),
                            });
                        }
                    }
                }
            }
            setDataGrid();
        }

        private void saveAsJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string json = JsonConvert.SerializeObject(autoList, Newtonsoft.Json.Formatting.Indented);
                using(StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.Write(json);
                }
            }
        }

        private void openJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    autoList = JsonConvert.DeserializeObject<List<Auto>>(sr.ReadToEnd());
                }
            }
            setDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            autoList = autoList.Where(item => item.Color != textBox7.Text).ToList<Auto>();
            setDataGrid();
        }
    }
}
