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
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = null;

        SqlDataAdapter adapter = null;

        DataTable table = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=LAPTOP-1GB64A2N;Initial Catalog=church;Integrated Security=True ");
            sqlConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM car", sqlConnection);

            table = new DataTable();
            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            string comDel = "DELETE FROM car WHERE id = " + tb_Id.Text;
            adapter = new SqlDataAdapter(comDel, sqlConnection);
            table = new DataTable();
            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (tb_CN.Text != "")
            {
                string comChange = "UPDATE car SET carName ='" +tb_CN.Text + "' WHERE id =" +tb_Id.Text;
                adapter = new SqlDataAdapter(comChange, sqlConnection);
                table = new DataTable();
                table.Clear();

                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            if (tb_CC.Text != "")
            {
                string comChange = "UPDATE car SET carCreate = " + tb_CC.Text + " WHERE id =" + tb_Id.Text;
                adapter = new SqlDataAdapter(comChange, sqlConnection);
                table = new DataTable();
                table.Clear();

                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            if (rt_CI.Text != "")
            {
                string comChange = "UPDATE car SET carIfno = '" + rt_CI.Text + "' WHERE id =" + tb_Id.Text;
                adapter = new SqlDataAdapter(comChange, sqlConnection);
                table = new DataTable();
                table.Clear();

                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string comCreate = $"INSERT INTO car (id, carName, carCreate, carInfo) VALUES ('{tb_Id.Text}', '{tb_CN.Text}', '{tb_CC.Text}', '{rt_CI.Text}')";
            adapter = new SqlDataAdapter(comCreate, sqlConnection);
            table = new DataTable();
            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
