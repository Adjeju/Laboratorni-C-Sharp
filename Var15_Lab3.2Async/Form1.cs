using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Var15_Lab3._2Async
{
    public partial class Form1 : Form
    {
        private List<Car> carList = new List<Car>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(CarContext db = new CarContext())
            {
                carList = db.Cars.ToList<Car>();
            }
            dataGridView1.DataSource = carList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = carList;
        }

        private void saveAsJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using(CarContext db = new CarContext())
                {
                    string json = JsonConvert.SerializeObject(db.Cars.ToList<Car>(), Formatting.Indented);
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        sw.Write(json);
                    }
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using(CarContext db = new CarContext())
            {
                dataGridView1.DataSource = await Task
                    .Run(() => db.Cars
                    .ToList<Car>()
                    .Where(c => c.Year == 2020)
                    .ToList<Car>());
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            using (CarContext db = new CarContext())
            {
                MessageBox.Show(await Task
                    .Run(() => db.Cars
                    .ToList<Car>()
                    .Max(c => c.Volume).ToString()));
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            using(CarContext db = new CarContext())
            {
                var list = (await Task.Run(
                    () => db.Cars
                    .ToList<Car>()
                    .GroupBy(c => c.Year))).ToList();

                dataGridView1.DataSource = null;

                dataGridView1.Columns.Add("GroupBy year", null);
                dataGridView1.Columns.Add("Count", null);


                foreach (var car in list)
                {
                    dataGridView1.Rows.Add(car.Key, car.Count());
                }
            }
            
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            using (CarContext db = new CarContext())
            {
                dataGridView1.DataSource = await Task.Run(
                    () => db.Cars
                    .ToList<Car>()
                    .Select(c => new Car() { Id = c.Id, Color = c.Color, Name = c.Name, Price = c.Price + 15, Volume = c.Volume, Year = c.Year })
                    .ToList<Car>());
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            using (CarContext db = new CarContext())
            {
                dataGridView1.DataSource = await Task.Run(
                    () => db.Cars
                    .OrderBy(c=>c.Volume)
                    .Skip(1)
                    .OrderBy(c => c.Id)
                    .ToList<Car>());
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            using (CarContext db = new CarContext())
            {
                MessageBox.Show($"{ await Task.Run(() => db.Cars.All(c => c.Year > 2020))}");
            }
        }

        private async void button8_Click_1(object sender, EventArgs e)
        {
            using (CarContext db = new CarContext())
            {
                MessageBox.Show($"{await Task.Run(() => db.Cars.Any(c => c.Year > 1999))}");
            }
        }
    }
}
