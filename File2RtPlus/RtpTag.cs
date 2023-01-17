using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File2RtPlus
{
    public class RtpTag
    {
        public RtpTag(int type, int start, int length)
        {
            Type = type;
            Start = start;
            Length = length;
        }

        public int Type { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }

        public static RtpTag Blank => new RtpTag(0, 0, 0);
    }
}
