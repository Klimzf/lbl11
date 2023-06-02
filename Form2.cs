using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lbl11
{
    public partial class Form2 : Form
    {
        SqlConnection sqlConnection = null;

        SqlDataAdapter adapter = null;

        DataTable Tables = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=LAPTOP-1GB64A2N;Initial Catalog=church;Integrated Security=True ");
            sqlConnection.Open();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM car", sqlConnection);

            DataSet ds = new DataSet("car");
            DataTable dt = new DataTable("car");
            ds.Tables.Add(dt);
            adapter.Fill(ds.Tables["Car"]);

            ds.WriteXml("cardb.xml");
            Console.WriteLine("Данные сохранены в файл");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("cardb.xml");
            Tables = new DataTable();
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
