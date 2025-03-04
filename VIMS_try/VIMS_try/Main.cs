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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            addUserControl(dashboard);

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
        private void AddButtonEffects(Button button)
        {
            button.MouseEnter += (sender, e) => button.BackColor = Color.LightBlue;
            button.MouseLeave += (sender, e) => button.BackColor = SystemColors.Control;
            button.MouseDown += (sender, e) => button.BackColor = Color.LightGreen;
            button.MouseUp += (sender, e) => button.BackColor = Color.LightBlue;
        }

        //BUTTONS
        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard uc = new Dashboard();
            addUserControl(uc);
        }

        private void btn_logs_Click(object sender, EventArgs e)
        {
            Logs uc = new Logs();
            addUserControl(uc);
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Info uc = new Info();
            addUserControl(uc);
        }

        private void btn_notification_Click(object sender, EventArgs e)
        {
            Notification uc = new Notification();
            addUserControl(uc);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.Hide();
            Login logIn = new Login();
            logIn.ShowDialog();
            this.Close();
        }

        private void btn_blacklist_Click(object sender, EventArgs e)
        {
            Blacklist uc = new Blacklist();
            addUserControl(uc);
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {

        }
    }
}
