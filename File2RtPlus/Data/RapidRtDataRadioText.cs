using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File2RtPlus.Data
{
    public class RapidRtDataRadioText
    {
        public bool IsEmpty { get; set; }
        public string Text { get; set; }
        public RapidRtDataTag[] Replacements { get; set; }
    }
}
