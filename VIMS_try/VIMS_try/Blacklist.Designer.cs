namespace VIMS_try
{
    partial class Blacklist
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            Reason = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(265, 45);
            label1.TabIndex = 0;
            label1.Text = "Blacklist Visitors";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 1;
            label2.Text = "Track | Blacklist\r\n";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 117);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, name, date, Reason });
            dataGridView1.Location = new Point(79, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(593, 315);
            dataGridView1.TabIndex = 7;
            // 
            // ID
            // 
            ID.FillWeight = 150F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // name
            // 
            name.FillWeight = 150F;
            name.HeaderText = "Name ";
            name.Name = "name";
            name.Width = 150;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.Name = "date";
            // 
            // Reason
            // 
            Reason.FillWeight = 150F;
            Reason.HeaderText = "Reasons";
            Reason.Name = "Reason";
            Reason.Width = 150;
            // 
            // Blacklist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Blacklist";
            Size = new Size(777, 464);
            Load += Blacklist_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn Reason;
    }
}
