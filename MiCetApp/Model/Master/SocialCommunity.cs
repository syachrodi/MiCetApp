using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCetApp.Model.Master
{
    public class SocialCommunity
    {
        public int sosial_community_id { get; set; }
        public int coin_id { get; set; }
        [Write(false)]
        public Coin Coin { get; set; }
        public int sosmed_id { get; set; }
        [Write(false)]
        public MediaSocial MediaSocial { get; set; }
        public string value { get; set; }
        public string link { get; set; }
    }
}
