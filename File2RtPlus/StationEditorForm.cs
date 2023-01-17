using File2RtPlus.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File2RtPlus
{
    public partial class StationEditorForm : Form
    {
        public StationEditorForm(StationConfigFile config)
        {
            this.config = config;
            InitializeComponent();
        }

        private readonly StationConfigFile config;

        private void StationEditorForm_Load(object sender, EventArgs e)
        {
            //Initialize fields
            fieldStationName.Text = config.Name;
            fieldRdsFilename.Text = config.RdsFilename;
            fieldEncoderIp.IpAddress = config.EncoderAddress;
            fieldEncoderIp.IpPort = config.EncoderPort;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Apply changes
            config.Name = fieldStationName.Text;
            config.RdsFilename = fieldRdsFilename.Text;
            config.EncoderAddress = fieldEncoderIp.IpAddress;
            config.EncoderPort = fieldEncoderIp.IpPort;

            //Exit
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void rapidBrowseBtn_Click(object sender, EventArgs e)
        {
            //Show file browser
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            fd.Title = "Choose Rapid RDS Output";
            if (fd.ShowDialog() != DialogResult.OK)
                return;

            //Apply
            fieldRdsFilename.Text = fd.FileName;
        }
    }
}
