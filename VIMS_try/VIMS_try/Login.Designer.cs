namespace VIMS_try
{
    partial class Login
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
            label2 = new Label();
            label3 = new Label();
            txt_Email = new TextBox();
            txt_Password = new TextBox();
            button1 = new Button();
            cb_pass = new CheckBox();
            rbtn_employee = new RadioButton();
            rbtn_admin = new RadioButton();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 198);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(423, 235);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(489, 195);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(175, 23);
            txt_Email.TabIndex = 3;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(489, 232);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(175, 23);
            txt_Password.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(503, 299);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cb_pass
            // 
            cb_pass.AutoSize = true;
            cb_pass.Location = new Point(489, 261);
            cb_pass.Name = "cb_pass";
            cb_pass.Size = new Size(108, 19);
            cb_pass.TabIndex = 6;
            cb_pass.Text = "Show Password";
            cb_pass.UseVisualStyleBackColor = true;
            cb_pass.CheckedChanged += cb_pass_CheckedChanged;
            // 
            // rbtn_employee
            // 
            rbtn_employee.AutoSize = true;
            rbtn_employee.BackColor = SystemColors.Control;
            rbtn_employee.FlatStyle = FlatStyle.System;
            rbtn_employee.Location = new Point(423, 135);
            rbtn_employee.Name = "rbtn_employee";
            rbtn_employee.Size = new Size(83, 20);
            rbtn_employee.TabIndex = 7;
            rbtn_employee.TabStop = true;
            rbtn_employee.Text = "Employee";
            rbtn_employee.UseVisualStyleBackColor = false;
            // 
            // rbtn_admin
            // 
            rbtn_admin.AutoSize = true;
            rbtn_admin.FlatStyle = FlatStyle.System;
            rbtn_admin.Location = new Point(570, 135);
            rbtn_admin.Name = "rbtn_admin";
            rbtn_admin.Size = new Size(67, 20);
            rbtn_admin.TabIndex = 8;
            rbtn_admin.TabStop = true;
            rbtn_admin.Text = "Admin";
            rbtn_admin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 508);
            Controls.Add(rbtn_admin);
            Controls.Add(rbtn_employee);
            Controls.Add(cb_pass);
            Controls.Add(button1);
            Controls.Add(txt_Password);
            Controls.Add(txt_Email);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txt_Email;
        private TextBox txt_Password;
        private Button button1;
        private CheckBox cb_pass;
        private RadioButton rbtn_employee;
        private RadioButton rbtn_admin;
    }
}
