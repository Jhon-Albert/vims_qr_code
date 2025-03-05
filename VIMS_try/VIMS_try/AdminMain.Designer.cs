namespace VIMS_try
{
    partial class AdminMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            lbl_name = new Label();
            pbClose = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btn_scan = new Button();
            btn_logout = new Button();
            btn_blacklist = new Button();
            btn_notification = new Button();
            btn_info = new Button();
            btn_logs = new Button();
            btn_dashboard = new Button();
            pnlContainer = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(855, 18);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(53, 20);
            lbl_name.TabIndex = 4;
            lbl_name.Text = "Admin";
            lbl_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbClose
            // 
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(816, 9);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(33, 32);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 3;
            pbClose.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(lbl_name);
            panel1.Controls.Add(pbClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 47);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(421, 37);
            label1.TabIndex = 0;
            label1.Text = "Visitor Identification Management";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Beige;
            panel2.Controls.Add(btn_scan);
            panel2.Controls.Add(btn_logout);
            panel2.Controls.Add(btn_blacklist);
            panel2.Controls.Add(btn_notification);
            panel2.Controls.Add(btn_info);
            panel2.Controls.Add(btn_logs);
            panel2.Controls.Add(btn_dashboard);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 464);
            panel2.TabIndex = 2;
            // 
            // btn_scan
            // 
            btn_scan.Location = new Point(2, 242);
            btn_scan.Name = "btn_scan";
            btn_scan.Size = new Size(180, 38);
            btn_scan.TabIndex = 6;
            btn_scan.Text = "Real Time Tracking";
            btn_scan.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            btn_logout.Image = (Image)resources.GetObject("btn_logout.Image");
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout.Location = new Point(2, 412);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(180, 38);
            btn_logout.TabIndex = 5;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_blacklist
            // 
            btn_blacklist.Image = (Image)resources.GetObject("btn_blacklist.Image");
            btn_blacklist.ImageAlign = ContentAlignment.MiddleLeft;
            btn_blacklist.Location = new Point(2, 198);
            btn_blacklist.Name = "btn_blacklist";
            btn_blacklist.Size = new Size(180, 38);
            btn_blacklist.TabIndex = 4;
            btn_blacklist.Text = "Blacklist Management";
            btn_blacklist.UseVisualStyleBackColor = true;
            // 
            // btn_notification
            // 
            btn_notification.Image = (Image)resources.GetObject("btn_notification.Image");
            btn_notification.ImageAlign = ContentAlignment.MiddleLeft;
            btn_notification.Location = new Point(2, 110);
            btn_notification.Name = "btn_notification";
            btn_notification.Size = new Size(180, 38);
            btn_notification.TabIndex = 3;
            btn_notification.Text = "Employee Management";
            btn_notification.UseVisualStyleBackColor = true;
            // 
            // btn_info
            // 
            btn_info.Image = (Image)resources.GetObject("btn_info.Image");
            btn_info.ImageAlign = ContentAlignment.MiddleLeft;
            btn_info.Location = new Point(2, 154);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(180, 38);
            btn_info.TabIndex = 2;
            btn_info.Text = "Visitor Reports";
            btn_info.UseVisualStyleBackColor = true;
            // 
            // btn_logs
            // 
            btn_logs.Image = (Image)resources.GetObject("btn_logs.Image");
            btn_logs.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logs.Location = new Point(2, 66);
            btn_logs.Name = "btn_logs";
            btn_logs.Size = new Size(180, 38);
            btn_logs.TabIndex = 1;
            btn_logs.Text = "Visitor Management";
            btn_logs.UseVisualStyleBackColor = true;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Image = (Image)resources.GetObject("btn_dashboard.Image");
            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.Location = new Point(2, 22);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(180, 38);
            btn_dashboard.TabIndex = 0;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = true;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.Beige;
            pnlContainer.Location = new Point(189, 47);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(777, 464);
            pnlContainer.TabIndex = 3;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 511);
            Controls.Add(pnlContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMain";
            Load += AdminMain_Load;
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_name;
        private PictureBox pbClose;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btn_scan;
        private Button btn_logout;
        private Button btn_blacklist;
        private Button btn_notification;
        private Button btn_info;
        private Button btn_logs;
        private Button btn_dashboard;
        private Panel pnlContainer;
    }
}