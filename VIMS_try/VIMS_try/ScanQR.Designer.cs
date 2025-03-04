namespace VIMS_try
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
            btn_scan_qr.Location = new Point(97, 377);
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
            // ScanQR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}