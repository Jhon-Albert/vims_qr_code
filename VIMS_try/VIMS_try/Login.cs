using System.Data;
using System.Data.SqlClient;

namespace VIMS_try
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection();

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Account where Email = @Email and Password = @Password", con);
                cmd.Parameters.AddWithValue("Email", txt_Email);
                cmd.Parameters.AddWithValue("Password", txt_Password);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    User.FullName = dataTable.Rows[0]["FullName"]?.ToString() ?? string.Empty;
                    MessageBox.Show("Login Successfully");
                    Main dash = new Main();
                    this.Hide();
                    dash.Show();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex);
            }

            */


            Main dash = new Main();
            dash.Show();
            this.Hide();
        }

        private void cb_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_pass.Checked)
            {
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '*';
            }
        }
    }
}
