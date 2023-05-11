using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireStationApp.Models
{
    public class Locations
    {
        public int Id { get; set; }
        public string District { get; set; }
        public string StationName { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Tel { get; set; }
    }
}
