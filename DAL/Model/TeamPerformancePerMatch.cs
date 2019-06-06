using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class TeamPerformancePerMatch
    {
        public string country { get; set; }
        public string code { get; set; }
        public int goals { get; set; }
        public int penalties { get; set; }
    }
}
