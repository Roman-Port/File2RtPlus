namespace File2RtPlus
{
    partial class StationEditorForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fieldStationName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldRdsFilename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fieldEncoderIp = new File2RtPlus.Gui.IpBox();
            this.rapidBrowseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(241, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(12, 257);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Station Name";
            // 
            // fieldStationName
            // 
            this.fieldStationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldStationName.Location = new System.Drawing.Point(12, 25);
            this.fieldStationName.Name = "fieldStationName";
            this.fieldStationName.Size = new System.Drawing.Size(357, 20);
            this.fieldStationName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rapid RDS Filename";
            // 
            // fieldRdsFilename
            // 
            this.fieldRdsFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldRdsFilename.Location = new System.Drawing.Point(12, 64);
            this.fieldRdsFilename.Name = "fieldRdsFilename";
            this.fieldRdsFilename.Size = new System.Drawing.Size(276, 20);
            this.fieldRdsFilename.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inovonics 730 IP/Port (UDP)";
            // 
            // fieldEncoderIp
            // 
            this.fieldEncoderIp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldEncoderIp.IpAddress = "255.255.255.255";
            this.fieldEncoderIp.IpPort = 255;
            this.fieldEncoderIp.Location = new System.Drawing.Point(12, 103);
            this.fieldEncoderIp.Name = "fieldEncoderIp";
            this.fieldEncoderIp.Size = new System.Drawing.Size(357, 20);
            this.fieldEncoderIp.TabIndex = 7;
            // 
            // rapidBrowseBtn
            // 
            this.rapidBrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rapidBrowseBtn.Location = new System.Drawing.Point(294, 62);
            this.rapidBrowseBtn.Name = "rapidBrowseBtn";
            this.rapidBrowseBtn.Size = new System.Drawing.Size(75, 24);
            this.rapidBrowseBtn.TabIndex = 8;
            this.rapidBrowseBtn.Text = "Browse...";
            this.rapidBrowseBtn.UseVisualStyleBackColor = true;
            this.rapidBrowseBtn.Click += new System.EventHandler(this.rapidBrowseBtn_Click);
            // 
            // StationEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 292);
            this.Controls.Add(this.rapidBrowseBtn);
            this.Controls.Add(this.fieldEncoderIp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fieldRdsFilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fieldStationName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StationEditorForm";
            this.Text = "Edit Station";
            this.Load += new System.EventHandler(this.StationEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fieldStationName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fieldRdsFilename;
        private System.Windows.Forms.Label label3;
        private Gui.IpBox fieldEncoderIp;
        private System.Windows.Forms.Button rapidBrowseBtn;
    }
}