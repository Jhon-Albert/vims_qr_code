namespace VIMS_try
{
    partial class Logs
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
            label2 = new Label();
            label1 = new Label();
            dgv_logs = new DataGridView();
            txt_search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_logs).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 4;
            label2.Text = "Track | Logs";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(197, 45);
            label1.TabIndex = 3;
            label1.Text = "Visitor Logs";
            // 
            // dgv_logs
            // 
            dgv_logs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_logs.Location = new Point(17, 127);
            dgv_logs.Name = "dgv_logs";
            dgv_logs.Size = new Size(750, 321);
            dgv_logs.TabIndex = 7;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(17, 98);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Search";
            txt_search.Size = new Size(203, 23);
            txt_search.TabIndex = 0;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // Logs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txt_search);
            Controls.Add(dgv_logs);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Logs";
            Size = new Size(777, 464);
            Load += Logs_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_logs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView dgv_logs;
        private TextBox txt_search;
    }
}
