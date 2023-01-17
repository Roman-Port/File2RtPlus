namespace File2RtPlus
{
    partial class StationBridge
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
            this.components = new System.ComponentModel.Container();
            this.statusText = new System.Windows.Forms.Label();
            this.statusToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.stationName = new System.Windows.Forms.Label();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.previewBox = new File2RtPlus.Gui.RichTextLabel();
            this.lastUpdatedTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusText
            // 
            this.statusText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusText.BackColor = System.Drawing.Color.Yellow;
            this.statusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusText.Location = new System.Drawing.Point(453, 0);
            this.statusText.Name = "statusText";
            this.statusText.Padding = new System.Windows.Forms.Padding(5);
            this.statusText.Size = new System.Drawing.Size(106, 36);
            this.statusText.TabIndex = 5;
            this.statusText.Text = "WAITING";
            this.statusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stationName
            // 
            this.stationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationName.Location = new System.Drawing.Point(-3, 0);
            this.stationName.Name = "stationName";
            this.stationName.Size = new System.Drawing.Size(109, 13);
            this.stationName.TabIndex = 6;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBtn.Image = global::File2RtPlus.Properties.Resources.settings_icon;
            this.settingsBtn.Location = new System.Drawing.Point(414, 0);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(36, 36);
            this.settingsBtn.TabIndex = 7;
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // previewBox
            // 
            this.previewBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewBox.DetectUrls = false;
            this.previewBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewBox.Location = new System.Drawing.Point(0, 16);
            this.previewBox.MaxLength = 96;
            this.previewBox.Multiline = false;
            this.previewBox.Name = "previewBox";
            this.previewBox.ReadOnly = true;
            this.previewBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.previewBox.ShortcutsEnabled = false;
            this.previewBox.Size = new System.Drawing.Size(411, 20);
            this.previewBox.TabIndex = 0;
            this.previewBox.TabStop = false;
            this.previewBox.Text = "";
            // 
            // lastUpdatedTime
            // 
            this.lastUpdatedTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastUpdatedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastUpdatedTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lastUpdatedTime.Location = new System.Drawing.Point(112, 0);
            this.lastUpdatedTime.Name = "lastUpdatedTime";
            this.lastUpdatedTime.Size = new System.Drawing.Size(299, 13);
            this.lastUpdatedTime.TabIndex = 8;
            this.lastUpdatedTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StationBridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lastUpdatedTime);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.stationName);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.previewBox);
            this.MinimumSize = new System.Drawing.Size(200, 39);
            this.Name = "StationBridge";
            this.Size = new System.Drawing.Size(559, 39);
            this.Load += new System.EventHandler(this.StationBridge_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Gui.RichTextLabel previewBox;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.ToolTip statusToolTip;
        private System.Windows.Forms.Label stationName;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Label lastUpdatedTime;
    }
}
