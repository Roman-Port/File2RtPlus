namespace File2RtPlus.Gui
{
    partial class IpBox
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
            this.IpOctet1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.IpOctet2 = new System.Windows.Forms.NumericUpDown();
            this.IpOctet3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.IpOctet4 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ipPort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IpOctet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpOctet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpOctet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpOctet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipPort)).BeginInit();
            this.SuspendLayout();
            // 
            // IpOctet1
            // 
            this.IpOctet1.Location = new System.Drawing.Point(0, 0);
            this.IpOctet1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IpOctet1.Name = "IpOctet1";
            this.IpOctet1.Size = new System.Drawing.Size(47, 20);
            this.IpOctet1.TabIndex = 0;
            this.IpOctet1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = ".";
            // 
            // IpOctet2
            // 
            this.IpOctet2.Location = new System.Drawing.Point(69, 0);
            this.IpOctet2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IpOctet2.Name = "IpOctet2";
            this.IpOctet2.Size = new System.Drawing.Size(47, 20);
            this.IpOctet2.TabIndex = 2;
            this.IpOctet2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // IpOctet3
            // 
            this.IpOctet3.Location = new System.Drawing.Point(138, 0);
            this.IpOctet3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IpOctet3.Name = "IpOctet3";
            this.IpOctet3.Size = new System.Drawing.Size(47, 20);
            this.IpOctet3.TabIndex = 4;
            this.IpOctet3.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = ".";
            // 
            // IpOctet4
            // 
            this.IpOctet4.Location = new System.Drawing.Point(207, 0);
            this.IpOctet4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IpOctet4.Name = "IpOctet4";
            this.IpOctet4.Size = new System.Drawing.Size(47, 20);
            this.IpOctet4.TabIndex = 6;
            this.IpOctet4.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = ".";
            // 
            // ipPort
            // 
            this.ipPort.Location = new System.Drawing.Point(276, 0);
            this.ipPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.ipPort.Name = "ipPort";
            this.ipPort.Size = new System.Drawing.Size(80, 20);
            this.ipPort.TabIndex = 8;
            this.ipPort.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // IpBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ipPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IpOctet4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IpOctet3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IpOctet2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpOctet1);
            this.Name = "IpBox";
            this.Size = new System.Drawing.Size(356, 20);
            ((System.ComponentModel.ISupportInitialize)(this.IpOctet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpOctet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpOctet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IpOctet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IpOctet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IpOctet2;
        private System.Windows.Forms.NumericUpDown IpOctet3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown IpOctet4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ipPort;
        private System.Windows.Forms.Label label4;
    }
}
