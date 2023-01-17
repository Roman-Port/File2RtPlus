using File2RtPlus.Config;
using File2RtPlus.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File2RtPlus
{
    public partial class StationBridge : UserControl
    {
        public StationBridge(StationConfigFile config, InovonicsEncoder encoder)
        {
            this.config = config;
            this.encoderComm = encoder;
            InitializeComponent();
        }

        private readonly StationConfigFile config;
        private readonly InovonicsEncoder encoderComm;

        private System.Timers.Timer updateTimer;

        private IPEndPoint encoderIp;
        private FileSystemWatcher watcher;

        public event BridgeEventArgs OnConfigUpdated;
        public event BridgeEventArgs OnDeleted;

        public delegate void BridgeEventArgs(StationBridge bridge, StationConfigFile config);

        private void StationBridge_Load(object sender, EventArgs e)
        {
            //Prepare update timer
            updateTimer = new System.Timers.Timer();
            updateTimer.AutoReset = false;
            updateTimer.Interval = 500;
            updateTimer.Elapsed += UpdateTimer_Elapsed;

            //Set up config
            ApplyConfig();
        }

        private void UpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                //Update
                ProcessRt();
            });
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                //Start timer to update it shortly
                updateTimer.Start();
            });
        }

        public void ApplyConfig()
        {
            //Stop if running
            Stop();

            //Set station name
            stationName.Text = config.Name;

            //Parse the encoder IP
            encoderIp = new IPEndPoint(IPAddress.Parse(config.EncoderAddress), config.EncoderPort);

            //Configure watcher on the file
            FileInfo fileInfo = new FileInfo(config.RdsFilename);
            watcher = new FileSystemWatcher();
            watcher.Path = fileInfo.Directory.FullName;
            watcher.Filter = fileInfo.Name;
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += Watcher_Changed;
            watcher.IncludeSubdirectories = false;
            watcher.EnableRaisingEvents = true;
        }

        private void Stop()
        {
            //If the watcher exists, stop it
            if (watcher != null)
            {
                watcher.Dispose();
                watcher = null;
            }
        }

        private void ProcessRt()
        {
            //Update status
            statusText.Text = "SENDING";
            statusText.BackColor = Color.FromArgb(128, 128, 255);

            //Check if file exists
            if (!File.Exists(config.RdsFilename))
            {
                SetErrorStatus($"The RDS file does not exist!");
                return;
            }

            //Read the RDS file
            string raw;
            try
            {
                raw = File.ReadAllText(config.RdsFilename);
            } catch
            {
                SetErrorStatus($"Could not read the RDS file.");
                return;
            }

            //Parse the RDS file
            RapidRtData data;
            try
            {
                data = JsonConvert.DeserializeObject<RapidRtData>(raw);
            }
            catch
            {
                SetErrorStatus($"Could not parse the RDS file: {raw}");
                return;
            }

            //Validate...this should never fail!
            if (data.DynamicPs == null || data.RadioText == null || data.RadioText.IsEmpty || data.RadioText.Text == null)
            {
                SetErrorStatus($"There is an unexpected error with the input from Rapid:\n\n{raw}");
                return;
            }

            //Prepare GUI
            previewBox.Clear();
            previewBox.Text = data.RadioText.Text;

            //Prepare RT+ tags and show them in the GUI
            RtpTag[] tags = new RtpTag[] { RtpTag.Blank, RtpTag.Blank };
            for (int i = 0; i < Math.Min(tags.Length, data.RadioText.Replacements.Length); i++)
            {
                //Determine the type
                int type = 0;
                switch (data.RadioText.Replacements[i].DlPlusFieldType)
                {
                    case "title": type = 1; break;
                    case "artist": type = 4; break;
                }

                //Apply to tags
                tags[i].Type = type;
                tags[i].Start = data.RadioText.Replacements[i].Start;
                tags[i].Length = data.RadioText.Replacements[i].Length;

                //Apply in GUI
                previewBox.Select(data.RadioText.Replacements[i].Start, data.RadioText.Replacements[i].Length);
                previewBox.SelectionBackColor = i == 0 ? Color.FromArgb(255, 186, 181) : Color.FromArgb(181, 207, 255);
            }
            previewBox.Select(0, 0);

            //Send off to the encoder
            try
            {
                encoderComm.SendRtPlus(encoderIp, data.DynamicPs, data.RadioText.Text, tags[0], tags[1], (bool success) =>
                {
                    Invoke((MethodInvoker)delegate
                    {
                        if (success)
                            ClearErrorStatus();
                        else
                            SetErrorStatus($"Network error while sending message to encoder.");
                    });
                });
            } catch (Exception ex)
            {
                SetErrorStatus($"Network error while sending message to encoder: {ex.Message}");
                return;
            }
        }

        private void ClearErrorStatus()
        {
            statusText.BackColor = Color.Lime;
            statusText.Text = "ONLINE";
            lastUpdatedTime.Text = "Last Updated at " + DateTime.Now.ToShortTimeString();
            statusToolTip.RemoveAll();
        }

        private void SetErrorStatus(string detail)
        {
            statusText.BackColor = Color.Red;
            statusText.Text = "ERROR";
            lastUpdatedTime.Text = "";
            statusToolTip.SetToolTip(statusText, detail);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            //Show settings dialog
            switch (new StationEditorForm(config).ShowDialog())
            {
                case DialogResult.OK:
                    //Settings were updated
                    ApplyConfig();
                    OnConfigUpdated?.Invoke(this, config);
                    break;
                case DialogResult.Abort:
                    //Requesting deletion of this item
                    Stop();
                    OnDeleted?.Invoke(this, config);
                    break;
            }
        }
    }
}
