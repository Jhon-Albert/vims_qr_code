using System.Data;
using Microsoft.Data.SqlClient;

namespace VIMS_try
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jhon Albert Ogana\source\repos\VIMS_try\VIMS.mdf"";Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                //Roles
                string role = rbtn_employee.Checked ? "Employee" : rbtn_admin.Checked ? "Admin" : string.Empty;
                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Please select a role (Employee or Admin).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    return;
                }

                string tableName = role == "Employee" ? "Employee" : "Admin";
                SqlCommand cmd = new SqlCommand($"select * from {tableName} where Email = @Email and Password = @Password", con);
                cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                cmd.Parameters.AddWithValue("@Password", txt_Password.Text);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count > 0)
                {
                    //Employee.Name = dataTable.Rows[0]["Name"]?.ToString() ?? string.Empty;
                    MessageBox.Show("Login Successfully");
                    if (role == "Employee")
                    {
                        Main dash = new Main();
                        this.Hide();
                        dash.Show();
                    }
                    else if (role == "Admin")
                    {

                        AdminMain dash_admin = new AdminMain();
                        this.Hide();
                        dash_admin.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Email.Clear();
                    txt_Password.Clear();
                    txt_Email.Focus();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message: " + ex);
            }



            //Main dash = new Main();
            //dash.Show();
            //this.Hide();
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

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
