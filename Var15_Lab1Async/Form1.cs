using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Var15_Lab1Async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (CarContext db = new CarContext())
            {
                dataGridView1.DataSource = db.Cars.ToList<Car>();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CarContext db = new CarContext())
            {
                Car newCar = new Car()
                {
                    Id = db.Cars.ToList<Car>().Last().Id,
                    Mark = textBox1.Text,
                    Color = textBox2.Text.ToLower(),
                    Price = Convert.ToDouble(textBox3.Text),
                    Year = Convert.ToInt32(textBox4.Text),
                    Volume = Convert.ToDouble(textBox5.Text)
                };

                db.Cars.Add(newCar);

                //db.SaveChanges();

                dataGridView1.DataSource = db.Cars.ToList<Car>();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (CarContext db = new CarContext())
            {
                dataGridView1.DataSource = db.Cars
                    .Where(car => car.Color != textBox6.Text)
                    .ToList<Car>();
            }
        }

        private void saveXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string xmlFile = saveFileDialog1.FileName;
                using(CarContext db = new CarContext())
                {
                    using (XmlTextWriter writer = new XmlTextWriter(xmlFile, null))
                    {
                        writer.Formatting = System.Xml.Formatting.Indented;
                        writer.Indentation = 3;
                        writer.WriteStartDocument();
                        writer.WriteStartElement("CarList");
                        foreach (Car c in db.Cars.ToList<Car>())
                        {
                            writer.WriteStartElement("Car");
                            writer.WriteElementString("Id", c.Id.ToString());
                            writer.WriteElementString("Mark", c.Mark.ToString());
                            writer.WriteElementString("Color", c.Color.ToString());
                            writer.WriteElementString("Price", c.Price.ToString());
                            writer.WriteElementString("Year", c.Year.ToString());
                            writer.WriteElementString("Volume", c.Volume.ToString());
                            writer.WriteEndElement();
                        }
                    }
                }

            }
        }

        private void openXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string xmlFile = openFileDialog1.FileName;
                List<Car> carList = new List<Car>();
                using (CarContext db = new CarContext())
                {
                    using (XmlTextReader reader = new XmlTextReader(xmlFile))
                    {
                        reader.ReadStartElement("CarList");
                        while (reader.Read())
                        {
                            if (reader.NodeType == XmlNodeType.Element && reader.Name == "Car")
                            {
                                reader.ReadStartElement("Car");
                                carList.Add(new Car()
                                {
                                    Id = Convert.ToInt32(reader.ReadElementString("Id")),
                                    Mark = reader.ReadElementString("Mark"),
                                    Color = reader.ReadElementString("Color"),
                                    Price = Convert.ToInt32(reader.ReadElementString("Price")),
                                    Year = Convert.ToInt32(reader.ReadElementString("Year")),
                                    Volume = Convert.ToDouble(reader.ReadElementString("Volume")),
                                });
                            }
                        }
                    }
                }
                dataGridView1.DataSource = carList;
            }
        }

        private void openJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<Car> carList = new List<Car>();

            using (CarContext db = new CarContext())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        carList = JsonConvert.DeserializeObject<List<Car>>(sr.ReadToEnd());
                    }
                }
            }

            dataGridView1.DataSource = carList;
        }

        private async void saveJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(CarContext db = new CarContext())
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string json = JsonConvert.SerializeObject(db.Cars.ToList<Car>(), Newtonsoft.Json.Formatting.Indented);
                    using(StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        await sw.WriteAsync(json);
                    }
                }
            }
        }
    }
}
