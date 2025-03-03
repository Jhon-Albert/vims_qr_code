namespace VIMS_try
{
    partial class Info
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            checkin = new DataGridViewTextBoxColumn();
            checkout = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, ID, date, checkin, checkout });
            dataGridView1.Location = new Point(17, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(750, 321);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            // 
            // ID
            // 
            ID.FillWeight = 150F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // date
            // 
            date.FillWeight = 150F;
            date.HeaderText = "Date";
            date.Name = "date";
            date.Width = 150;
            // 
            // checkin
            // 
            checkin.FillWeight = 150F;
            checkin.HeaderText = "Check-In";
            checkin.Name = "checkin";
            checkin.Width = 150;
            // 
            // checkout
            // 
            checkout.FillWeight = 150F;
            checkout.HeaderText = "Check-Out";
            checkout.Name = "checkout";
            checkout.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(279, 45);
            label1.TabIndex = 1;
            label1.Text = "Information Logs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 2;
            label2.Text = "Track | Logs";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 98);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Info";
            Size = new Size(777, 464);
            Load += Info_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn checkin;
        private DataGridViewTextBoxColumn checkout;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
    }
}
