﻿namespace VIMS_try
{
    partial class ScanQR
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
            btn_camera = new Button();
            pb_scan = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btn_scan_qr = new Button();
            cmb_camera = new ComboBox();
            label3 = new Label();
            txt_firstName = new TextBox();
            txt_lastName = new TextBox();
            label4 = new Label();
            txt_email = new TextBox();
            label5 = new Label();
            txt_purpose = new TextBox();
            label6 = new Label();
            txt_number = new TextBox();
            label7 = new Label();
            txt_address = new TextBox();
            label8 = new Label();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_scan).BeginInit();
            SuspendLayout();
            // 
            // btn_camera
            // 
            btn_camera.Location = new Point(97, 324);
            btn_camera.Name = "btn_camera";
            btn_camera.Size = new Size(89, 23);
            btn_camera.TabIndex = 14;
            btn_camera.Text = "Open Camera";
            btn_camera.UseVisualStyleBackColor = true;
            btn_camera.Click += btn_camera_Click;
            // 
            // pb_scan
            // 
            pb_scan.Location = new Point(26, 141);
            pb_scan.Name = "pb_scan";
            pb_scan.Size = new Size(228, 177);
            pb_scan.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_scan.TabIndex = 13;
            pb_scan.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 12;
            label2.Text = "Manage | Scanner";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(229, 45);
            label1.TabIndex = 11;
            label1.Text = "Scan QR Code";
            // 
            // btn_scan_qr
            // 
            btn_scan_qr.Location = new Point(97, 353);
            btn_scan_qr.Name = "btn_scan_qr";
            btn_scan_qr.Size = new Size(89, 23);
            btn_scan_qr.TabIndex = 15;
            btn_scan_qr.Text = "Scan QR";
            btn_scan_qr.UseVisualStyleBackColor = true;
            // 
            // cmb_camera
            // 
            cmb_camera.FormattingEnabled = true;
            cmb_camera.Location = new Point(80, 112);
            cmb_camera.Name = "cmb_camera";
            cmb_camera.Size = new Size(121, 23);
            cmb_camera.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(309, 109);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 17;
            label3.Text = "First Name:";
            // 
            // txt_firstName
            // 
            txt_firstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_firstName.Location = new Point(398, 105);
            txt_firstName.Name = "txt_firstName";
            txt_firstName.Size = new Size(130, 27);
            txt_firstName.TabIndex = 18;
            // 
            // txt_lastName
            // 
            txt_lastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_lastName.Location = new Point(655, 106);
            txt_lastName.Name = "txt_lastName";
            txt_lastName.Size = new Size(130, 27);
            txt_lastName.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(567, 109);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 19;
            label4.Text = "Last Name:";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(398, 138);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(130, 27);
            txt_email.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(343, 141);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 21;
            label5.Text = "Email:";
            // 
            // txt_purpose
            // 
            txt_purpose.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_purpose.Location = new Point(655, 139);
            txt_purpose.Name = "txt_purpose";
            txt_purpose.Size = new Size(130, 27);
            txt_purpose.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(534, 141);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 27;
            label6.Text = "Purpose of Visit:";
            // 
            // txt_number
            // 
            txt_number.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_number.Location = new Point(398, 174);
            txt_number.Name = "txt_number";
            txt_number.Size = new Size(130, 27);
            txt_number.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(271, 177);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 25;
            label7.Text = "Contact Number:";
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_address.Location = new Point(398, 207);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(218, 100);
            txt_address.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(327, 210);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 23;
            label8.Text = "Address:";
            // 
            // btn_back
            // 
            btn_back.Location = new Point(97, 382);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(89, 23);
            btn_back.TabIndex = 29;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // ScanQR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back);
            Controls.Add(txt_purpose);
            Controls.Add(label6);
            Controls.Add(txt_number);
            Controls.Add(label7);
            Controls.Add(txt_address);
            Controls.Add(label8);
            Controls.Add(txt_email);
            Controls.Add(label5);
            Controls.Add(txt_lastName);
            Controls.Add(label4);
            Controls.Add(txt_firstName);
            Controls.Add(label3);
            Controls.Add(cmb_camera);
            Controls.Add(btn_scan_qr);
            Controls.Add(btn_camera);
            Controls.Add(pb_scan);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ScanQR";
            Text = "ScanQR";
            FormClosing += ScanQR_FormClosing;
            Load += ScanQR_Load;
            ((System.ComponentModel.ISupportInitialize)pb_scan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_camera;
        private PictureBox pb_scan;
        private Label label2;
        private Label label1;
        private Button btn_scan_qr;
        private ComboBox cmb_camera;
        private Label label3;
        private TextBox txt_firstName;
        private TextBox txt_lastName;
        private Label label4;
        private TextBox txt_email;
        private Label label5;
        private TextBox txt_purpose;
        private Label label6;
        private TextBox txt_number;
        private Label label7;
        private TextBox txt_address;
        private Label label8;
        private Button btn_back;
    }
}