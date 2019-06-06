using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
     public class Player
    {
        public string name { get; set; }
        public bool captain { get; set; }
        public int shirt_number { get; set; }
        public string position { get; set; }
        public bool favorite { get; set; }

        //public override string ToString()=>$"{name}, {shirt_number},{position}, Captain: {captain.ToString()}";
        public override string ToString() => $"{name}, {shirt_number}";

        public string OutputFormat() => $"{name}|{captain}|{shirt_number}|{position}";
    }
}
