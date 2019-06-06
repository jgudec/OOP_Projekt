using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    

    public class Match
    {
        public string venue { get; set; }
        public string location { get; set; }
        public string status { get; set; }
        public string time { get; set; }
        public int fifa_id { get; set; }
        public Weather weather { get; set; }
        public int attendance { get; set; }
        public List<string> officials { get; set; }
        public string stage_name { get; set; }
        public string home_team_country { get; set; }
        public string away_team_country { get; set; }
        public DateTime datetime { get; set; }
        public string winner { get; set; }
        public string winner_code { get; set; }
        public TeamPerformancePerMatch home_team { get; set; }
        public TeamPerformancePerMatch away_team { get; set; }
        public List<TeamEvent> home_team_event { get; set; }
        public List<TeamEvent> away_team_event { get; set; }
        public TeamStatistics home_team_statistics { get; set; }
        public TeamStatistics away_team_statistics { get; set; }
    }
}
