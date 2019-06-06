using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Weather
    {
        public int humidity { get; set; }
        public int temp_celsius { get; set; }
        public int temp_farenheit { get; set; }
        public int wind_speed { get; set; }
        public string description { get; set; }
    }
}
