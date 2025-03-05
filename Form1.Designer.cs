namespace Registration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            btnRegister = new Button();
            label6 = new Label();
            cmbPurpose = new ComboBox();
            label7 = new Label();
            pictureBoxQR = new PictureBox();
            btnSendEmail = new Button();
            label8 = new Label();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 201);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 205);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 257);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 257);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 3;
            label4.Text = "Contact number:";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(132, 198);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(218, 27);
            txtFName.TabIndex = 5;
            txtFName.TextChanged += textBox1_TextChanged;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(477, 202);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(211, 27);
            txtLName.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(132, 254);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(218, 27);
            txtAddress.TabIndex = 7;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(477, 250);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(211, 27);
            txtContact.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegister.BackColor = SystemColors.Window;
            btnRegister.Location = new Point(533, 368);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 54);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 9);
            label6.Name = "label6";
            label6.Size = new Size(253, 54);
            label6.TabIndex = 11;
            label6.Text = "Registration";
            // 
            // cmbPurpose
            // 
            cmbPurpose.FormattingEnabled = true;
            cmbPurpose.Items.AddRange(new object[] { "Guest of Resident ", "Property Inquiry", "Delivery", "Maintenance/Repair", "Business Meeting", "Emergency Assistance", "Others" });
            cmbPurpose.Location = new Point(480, 309);
            cmbPurpose.Name = "cmbPurpose";
            cmbPurpose.Size = new Size(208, 28);
            cmbPurpose.TabIndex = 12;
            cmbPurpose.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(361, 312);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 13;
            label7.Text = "Purpose of visit:";
            // 
            // pictureBoxQR
            // 
            pictureBoxQR.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxQR.Location = new Point(560, 12);
            pictureBoxQR.Name = "pictureBoxQR";
            pictureBoxQR.Size = new Size(141, 115);
            pictureBoxQR.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxQR.TabIndex = 14;
            pictureBoxQR.TabStop = false;
            pictureBoxQR.Click += pictureBox1_Click;
            // 
            // btnSendEmail
            // 
            btnSendEmail.Location = new Point(375, 368);
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.Size = new Size(143, 54);
            btnSendEmail.TabIndex = 15;
            btnSendEmail.Text = "Send QR via Email";
            btnSendEmail.UseVisualStyleBackColor = true;
            btnSendEmail.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(80, 142);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 16;
            label8.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(133, 139);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(217, 27);
            txtEmail.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(724, 462);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(btnSendEmail);
            Controls.Add(pictureBoxQR);
            Controls.Add(label7);
            Controls.Add(cmbPurpose);
            Controls.Add(label6);
            Controls.Add(btnRegister);
            Controls.Add(txtContact);
            Controls.Add(txtAddress);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Registration";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtAddress;
        private TextBox txtContact;
        private Button btnRegister;
        private Label label6;
        private ComboBox cmbPurpose;
        private Label label7;
        private PictureBox pictureBoxQR;
        private Button btnSendEmail;
        private Label label8;
        private TextBox txtEmail;
    }
}
