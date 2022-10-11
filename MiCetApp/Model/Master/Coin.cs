using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCetApp.Model.Master
{
    public class Coin
    {
        public int coin_id { get; set; }
        public string coin_name { get; set; }
        public string coin_symbol { get; set; }
        public int chain_id { get; set; }
        public bool is_coin { get; set; }
        public string smart_contract { get; set; }
        public decimal total_supply { get; set; }
        public decimal circulation_supply { get; set; }
        public decimal market_cap { get; set; }
        public decimal price { get; set; }
        public decimal qnty_holders { get; set; }
        public decimal value_conv { get; set; }
        public List<SocialCommunity> list_social_community { get; set; }
    }
}
