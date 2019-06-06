using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class TeamEvent
    {
        public int id { get; set; }
        public string type { get; set; }
        public string player { get; set; }
        public string time { get; set; }
    }
}
