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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_Email = new TextBox();
            txt_Password = new TextBox();
            button1 = new Button();
            cb_pass = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(78, 43);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(175, 23);
            txt_Email.TabIndex = 3;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(78, 80);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(175, 23);
            txt_Password.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(92, 147);
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
            cb_pass.Location = new Point(78, 109);
            cb_pass.Name = "cb_pass";
            cb_pass.Size = new Size(108, 19);
            cb_pass.TabIndex = 6;
            cb_pass.Text = "Show Password";
            cb_pass.UseVisualStyleBackColor = true;
            cb_pass.CheckedChanged += cb_pass_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 508);
            Controls.Add(cb_pass);
            Controls.Add(button1);
            Controls.Add(txt_Password);
            Controls.Add(txt_Email);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_Email;
        private TextBox txt_Password;
        private Button button1;
        private CheckBox cb_pass;
    }
}
