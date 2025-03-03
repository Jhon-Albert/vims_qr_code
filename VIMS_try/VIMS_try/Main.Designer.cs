namespace VIMS_try
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            label2 = new Label();
            pbClose = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btn_logout = new Button();
            btn_blacklist = new Button();
            btn_notification = new Button();
            btn_info = new Button();
            btn_logs = new Button();
            button1 = new Button();
            pnlContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pbClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 47);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(855, 18);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Employee";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(btn_logout);
            panel2.Controls.Add(btn_blacklist);
            panel2.Controls.Add(btn_notification);
            panel2.Controls.Add(btn_info);
            panel2.Controls.Add(btn_logs);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 464);
            panel2.TabIndex = 1;
            // 
            // btn_logout
            // 
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
            btn_blacklist.Location = new Point(2, 198);
            btn_blacklist.Name = "btn_blacklist";
            btn_blacklist.Size = new Size(180, 38);
            btn_blacklist.TabIndex = 4;
            btn_blacklist.Text = "Blacklist Visitors";
            btn_blacklist.UseVisualStyleBackColor = true;
            btn_blacklist.Click += btn_blacklist_Click;
            // 
            // btn_notification
            // 
            btn_notification.Location = new Point(2, 154);
            btn_notification.Name = "btn_notification";
            btn_notification.Size = new Size(180, 38);
            btn_notification.TabIndex = 3;
            btn_notification.Text = "Notification";
            btn_notification.UseVisualStyleBackColor = true;
            btn_notification.Click += btn_notification_Click;
            // 
            // btn_info
            // 
            btn_info.Location = new Point(2, 110);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(180, 38);
            btn_info.TabIndex = 2;
            btn_info.Text = "Visitor Info";
            btn_info.UseVisualStyleBackColor = true;
            btn_info.Click += btn_info_Click;
            // 
            // btn_logs
            // 
            btn_logs.Location = new Point(2, 66);
            btn_logs.Name = "btn_logs";
            btn_logs.Size = new Size(180, 38);
            btn_logs.TabIndex = 1;
            btn_logs.Text = "Visitor Logs";
            btn_logs.UseVisualStyleBackColor = true;
            btn_logs.Click += btn_logs_Click;
            // 
            // button1
            // 
            button1.Location = new Point(2, 22);
            button1.Name = "button1";
            button1.Size = new Size(180, 38);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = SystemColors.GradientInactiveCaption;
            pnlContainer.Location = new Point(189, 47);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(777, 464);
            pnlContainer.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 511);
            Controls.Add(pnlContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private PictureBox pbClose;
        private Label label2;
        private Panel pnlContainer;
        private Button btn_logs;
        private Button btn_info;
        private Button btn_notification;
        private Button btn_logout;
        private Button btn_blacklist;
    }
}