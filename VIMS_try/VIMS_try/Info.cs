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

namespace VIMS_try
{
    public partial class Info : UserControl
    {
        SqlConnection con = new SqlConnection();
        DataTable dataTable = new DataTable();
        public Info()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*
            if (txt_search.Text.Length > 0 && char.IsDigit(txt_search.Text[0]))
            {
                ((DataTable)dgv_logs.DataSource).DefaultView.RowFilter = string.Format("Name like '{0}%' or Name like '% {0}%'", txt_search.Text);
            }
            else
            {
                ((DataTable)dgv_logs.DataSource).DefaultView.RowFilter = string.Format("Name like '{0}%' or Name like '% {0}%'", txt_search.Text);
            }
            */
        }
        public void displayData()
        {
            /*
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Stocks", con);
            dataAdapter.Fill(dataTable);
            dgv_logs.DataSource = dataTable;
            */
        }

        private void Info_Load(object sender, EventArgs e)
        {
            //displayData();
        }
    }
}
