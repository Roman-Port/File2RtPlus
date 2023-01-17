using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File2RtPlus.Config
{
    public class StationConfigFile
    {
        public string Name { get; set; } = "";
        public string RdsFilename { get; set; } = "";
        public string EncoderAddress { get; set; } = "192.168.1.1";
        public int EncoderPort { get; set; } = 10003;
    }
}
