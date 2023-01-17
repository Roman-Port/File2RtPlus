using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File2RtPlus.Gui
{
    public partial class IpBox : UserControl
    {
        public IpBox()
        {
            InitializeComponent();
        }

        public string IpAddress
        {
            get
            {
                return IpOctet1.Value.ToString() + "." + IpOctet2.Value.ToString() + "." + IpOctet3.Value.ToString() + "." + IpOctet4.Value.ToString();
            }
            set
            {
                //Parse into octets array
                int[] octets = new int[4];
                string[] octetsRaw = value.Split('.');
                bool ok = true;
                if (octetsRaw.Length != octets.Length)
                    ok = false;
                for (int i = 0; i < Math.Min(octetsRaw.Length, octets.Length); i++)
                    ok = ok && int.TryParse(octetsRaw[i], out octets[i]) && octets[i] >= 0 && octets[i] <= 255;

                //Apply
                IpOctet1.Value = ok ? octets[0] : 0;
                IpOctet2.Value = ok ? octets[1] : 0;
                IpOctet3.Value = ok ? octets[2] : 0;
                IpOctet4.Value = ok ? octets[3] : 0;
            }
        }

        public int IpPort
        {
            get => (int)ipPort.Value;
            set => ipPort.Value = value;
        }
    }
}
