using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCetApp.Model.Master
{
    public class Chain
    {
        public int chain_id { get; set; }
        public string blockchain { get; set; }
        public string network { get; set; }
        public string native_currency { get; set; }
        public string block_explorer { get; set; }
    }
}
