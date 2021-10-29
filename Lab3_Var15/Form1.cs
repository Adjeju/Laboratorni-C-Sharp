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
using System.Data.SqlClient;

namespace Lab3_Var15
{
    public partial class Form1 : Form
    {
        private List<Auto> autoList = new List<Auto>();
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Laboratorni-C-Sharp\Lab3_Var15\Database1.mdf;Integrated Security=True";
        private SqlConnection sqlConnection = new SqlConnection(connectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //using(AutoContex autoDB = new AutoContex())
            //{
            //    autoList = autoDB.Autoes.ToList<Auto>();
            //}
            //dataGridView1.DataSource = autoList;
            SqlCommand getAll = new SqlCommand(
                "SELECT * FROM Auto", sqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(getAll);

            DataTable dataTable = new DataTable();

            sqlConnection.Open();
            adapter.Fill(dataTable);
            sqlConnection.Close();

            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            //using (AutoContex autoDB = new AutoContex())
            //{
            //    autoList = autoDB.Autoes.ToList<Auto>()
            //        .Where((auto)=> auto.Year == "2020").ToList<Auto>();
            //}

            //dataGridView1.DataSource = autoList;

            SqlCommand getByYear = new SqlCommand(
                "SELECT * FROM Auto WHERE Year = @Year ", sqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(getByYear);
            DataTable dataTable = new DataTable();

            getByYear.Parameters.AddWithValue("Year", "2020");

            sqlConnection.Open();
            adapter.Fill(dataTable);
            sqlConnection.Close();

            dataGridView1.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            //using (AutoContex autoDB = new AutoContex())
            //{
            //    autoList = autoDB.Autoes.ToList<Auto>().
            //        OrderByDescending((auto)=>auto.Volume)
            //        .Take(1)
            //        .ToList<Auto>();
            //}

            //dataGridView1.DataSource = autoList;

            SqlCommand getMax = new SqlCommand(
                "SELECT TOP (1) * FROM Auto ORDER BY Volume DESC ", sqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(getMax);
            DataTable dataTable = new DataTable();

            sqlConnection.Open();
            adapter.Fill(dataTable);
            sqlConnection.Close();

            dataGridView1.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            //using (AutoContex autoDB = new AutoContex())
            //{
            //    var autoList = autoDB.Autoes.ToList<Auto>()
            //        .GroupBy((auto) => auto.Price);

            //    dataGridView1.DataSource = null;

            //    dataGridView1.Columns.Add("GroupBy price", null);
            //    dataGridView1.Columns.Add("Count", null);

            //    foreach(var auto in autoList)
            //    {
            //        dataGridView1.Rows.Add(auto.Key, auto.Count());
            //    }
            //}

            SqlCommand groupBy = new SqlCommand(
                "SELECT COUNT(Code), Price FROM Auto GROUP BY Price", sqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(groupBy);
            DataTable dataTable = new DataTable();

            sqlConnection.Open();
            adapter.Fill(dataTable);
            sqlConnection.Close();

            dataGridView1.DataSource = dataTable;


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

            //using (AutoContex autoDB = new AutoContex())
            //{
            //    autoList = autoDB.Autoes.ToList<Auto>();
            //    autoList.ForEach(auto => auto.Price += 15);

            //}
            //MessageBox.Show("File -> Save");
            //dataGridView1.DataSource = autoList;
            SqlCommand increase = new SqlCommand(
                "UPDATE Auto SET Price = Price + @Value", sqlConnection);

            SqlCommand getAll = new SqlCommand(
                "SELECT * FROM Auto", sqlConnection);

            increase.Parameters.AddWithValue("Value", 15);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(getAll);
            DataTable dataTable = new DataTable();

            sqlConnection.Open();
            increase.ExecuteNonQuery();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            dataGridView1.DataSource = dataTable;
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

            //using (AutoContex autoDB = new AutoContex())
            //{
            //    autoList = autoDB.Autoes.ToList<Auto>()
            //        .OrderBy(auto=> auto.Volume).Skip(1).ToList<Auto>();
            //}
            //dataGridView1.DataSource = autoList;

            SqlCommand delete = new SqlCommand(
                "WITH db AS (SELECT TOP(1) * FROM Auto ORDER BY Volume) DELETE FROM db", sqlConnection);

            sqlConnection.Open();
            delete.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deleted");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //using (AutoContex autoDB = new AutoContex())
            //{
            //    MessageBox.Show($"price > 10: {autoDB.Autoes.ToList<Auto>().All(auto=> auto.Price == 10)}");
            //}

            dataGridView1.Columns.Clear();

            DataTable dataTable1 = new DataTable();
            DataTable dataTable2 = new DataTable();

            SqlCommand all = new SqlCommand(
                "SELECT Price FROM Auto WHERE Price > @Price",
                sqlConnection
                );

            all.Parameters.AddWithValue("Price", 10);

            SqlCommand getAll = new SqlCommand(
                "SELECT * FROM Auto",
                sqlConnection
                );

            SqlDataAdapter adaptAll = new SqlDataAdapter(all);
            SqlDataAdapter adaptGetAll = new SqlDataAdapter(getAll);

            sqlConnection.Open();
            adaptAll.Fill(dataTable1);
            adaptGetAll.Fill(dataTable2);

            MessageBox.Show($"Price > 10(all): {dataTable1.Rows.Count == dataTable2.Rows.Count}");

            sqlConnection.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //using (AutoContex autoDB = new AutoContex())
            //{
            //    MessageBox.Show($"price > 10: {autoDB.Autoes.ToList<Auto>().Any(auto => auto.Price == 10)}");
            //}

            dataGridView1.Columns.Clear();

            DataTable dataTable1 = new DataTable();
            DataTable dataTable2 = new DataTable();

            SqlCommand all = new SqlCommand(
                "SELECT Price FROM Auto WHERE Price > @Price",
                sqlConnection
                );

            all.Parameters.AddWithValue("Price", 10);

            SqlCommand getAll = new SqlCommand(
                "SELECT * FROM Auto",
                sqlConnection
                );

            SqlDataAdapter adaptAll = new SqlDataAdapter(all);
            SqlDataAdapter adaptGetAll = new SqlDataAdapter(getAll);

            sqlConnection.Open();

            adaptAll.Fill(dataTable1);
            adaptGetAll.Fill(dataTable2);

            MessageBox.Show($"Price > 10(any): {dataTable1.Rows.Count > 0}");

            sqlConnection.Close();
        }
    }
}
