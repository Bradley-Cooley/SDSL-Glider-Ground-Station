using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDSL.GliderGroundStation.Model
{
    public struct TelemetryPacket
    {
        public ushort teamID { get; set; }
        
        public ushort packetCount { get; set; }

        public float altSensor { get; set; }

        public float pressure { get; set; }

        public float speed { get; set; }

        public float temp { get; set; }

        public float voltage { get; set; }

        public float latitudeGPS { get; set; }

        public float longitudeGPS { get; set; }

        public float altitudeGPS { get; set; }

        public ushort satellitesGPS { get; set; }

        public float speedGPS { get; set; }

        public ushort lastImageCommandTime { get; set; }

        public ushort imageCommandCount { get; set; }
    }
}
