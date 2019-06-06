using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Team
    {
        public int id { get; set; }
        public string country { get; set; }
        public string alternate_name { get; set; }
        public string fifa_code { get; set; }
        public string group_id { get; set; }
        public string group_letter { get; set; }

        public string FileFormat() => $"{id},{country},{alternate_name},{fifa_code},{group_id},{group_letter}";

        public string StockNameFormat { get => $"{country} ( {fifa_code} )";}
    }
}
