using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIMS_try
{
    public partial class Logs : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\VIMS_try\VIMS.mdf"";Integrated Security=True;Connect Timeout=30");
        DataTable dataTable = new DataTable();
        public Logs()
        {
            InitializeComponent();
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            //displayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void displayData()
        {
            
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Logs", con);
            dataAdapter.Fill(dataTable);
            dgv_logs.DataSource = dataTable;
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            
            if (txt_search.Text.Length > 0 && char.IsDigit(txt_search.Text[0]))
            {
                ((DataTable)dgv_logs.DataSource).DefaultView.RowFilter = string.Format("Name like '{0}%' or Name like '% {0}%'", txt_search.Text);
            }
            else
            {
                ((DataTable)dgv_logs.DataSource).DefaultView.RowFilter = string.Format("Name like '{0}%' or Name like '% {0}%'", txt_search.Text);
            }
            
        }
    }
}
