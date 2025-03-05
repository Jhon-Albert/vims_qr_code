using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIMS_try
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
            AdminDashboard admin_dashboard = new AdminDashboard();
            addUserControl(admin_dashboard);

            AddButtonEffects(btn_dashboard);
            AddButtonEffects(btn_logs);
            AddButtonEffects(btn_info);
            AddButtonEffects(btn_notification);
            AddButtonEffects(btn_logout);
            AddButtonEffects(btn_blacklist);
            AddButtonEffects(btn_scan);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {

        }

        private void AddButtonEffects(Button button)
        {
            button.MouseEnter += (sender, e) => button.BackColor = Color.LightYellow;
            button.MouseLeave += (sender, e) => button.BackColor = SystemColors.Control;
            button.MouseDown += (sender, e) => button.BackColor = Color.LightYellow;
            button.MouseUp += (sender, e) => button.BackColor = Color.LightYellow;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.Hide();
            Login logIn = new Login();
            logIn.ShowDialog();
            this.Close();
        }
    }
}
