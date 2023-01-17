using File2RtPlus.Config;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File2RtPlus
{
    public partial class Form1 : Form
    {
        public Form1(string configFilename)
        {
            this.configFilename = configFilename;
            InitializeComponent();
        }

        private readonly string configFilename;

        private AppConfigFile config;
        private InovonicsEncoder encoder = new InovonicsEncoder();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load the config file
            if (File.Exists(configFilename))
                config = JsonConvert.DeserializeObject<AppConfigFile>(File.ReadAllText(configFilename));
            else
                config = new AppConfigFile();

            //Create all stations in the configuration file
            foreach (var s in config.Stations)
                AddBridgeToGui(s);
        }

        private void SaveConfigFile()
        {
            //Create temporary filenames
            string configFilenameTmp = configFilename + ".tmp";
            string configFilenameBak = configFilename + ".bak";

            //Save to backup
            File.WriteAllText(configFilenameTmp, JsonConvert.SerializeObject(config));

            //Replace original
            if (File.Exists(configFilenameBak))
                File.Delete(configFilenameBak);
            if (File.Exists(configFilename))
                File.Move(configFilename, configFilenameBak);
            File.Move(configFilenameTmp, configFilename);
        }

        private void AddBridgeToGui(StationConfigFile config)
        {
            //Create bridge
            StationBridge bridge = new StationBridge(config, encoder);
            bridge.OnDeleted += Bridge_OnDeleted;
            bridge.OnConfigUpdated += Bridge_OnConfigUpdated;

            //Add it to the table
            int index = tableLayoutPanel1.RowStyles.Add(new RowStyle
            {
                SizeType = SizeType.Absolute,
                Height = 39
            });
            bridge.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(bridge, 0, index);
        }

        private void Bridge_OnConfigUpdated(StationBridge bridge, StationConfigFile configItem)
        {
            //Save updated configuration file
            SaveConfigFile();
        }

        private void Bridge_OnDeleted(StationBridge bridge, StationConfigFile configItem)
        {
            //Delete from the list of stations in the configuration file and save
            config.Stations.Remove(configItem);
            SaveConfigFile();

            //Remove from the list of stations in the GUI
            tableLayoutPanel1.Controls.Remove(bridge);
        }

        private void addStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create config and open editor on it
            StationConfigFile configItem = new StationConfigFile();
            if (new StationEditorForm(configItem).ShowDialog() != DialogResult.OK)
                return;

            //Add to file and save it
            config.Stations.Add(configItem);
            SaveConfigFile();

            //Add to the GUI
            AddBridgeToGui(configItem);
        }
    }
}
