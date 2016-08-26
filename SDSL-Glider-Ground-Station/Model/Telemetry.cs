using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using XBee;
using XBee.Frames;

namespace SDSL.GliderGroundStation.Model
{
    class Telemetry
    {
        private List<TelemetryPacket> packets;
        public int NumberOfPackets { get { return packets.Count; } }

        public Telemetry()
        {
            packets = new List<TelemetryPacket>();
        }

        public void addPacket(ZigBeeReceivePacket frame)
        {
            TelemetryPacket newPacket = new TelemetryPacket();
            String[] strings = Encoding.ASCII.GetString(frame.Data).Split(',');

            //Seperate each element
            try {
                newPacket.teamID = Convert.ToUInt16(strings[0]);
                newPacket.packetCount = Convert.ToUInt16(strings[1]);
                newPacket.altSensor = Convert.ToSingle(strings[2]);
                newPacket.pressure = Convert.ToSingle(strings[3]);
                newPacket.speed = Convert.ToSingle(strings[4]);
                newPacket.temp = Convert.ToSingle(strings[5]);
                newPacket.voltage = Convert.ToSingle(strings[6]);
                newPacket.latitudeGPS = Convert.ToSingle(strings[7]);
                newPacket.longitudeGPS = Convert.ToSingle(strings[8]);
                newPacket.altitudeGPS = Convert.ToSingle(strings[9]);
                newPacket.satellitesGPS = Convert.ToUInt16(strings[10]);
                newPacket.speedGPS = Convert.ToSingle(strings[11]);
                newPacket.lastImageCommandTime = Convert.ToUInt16(strings[12]);
                newPacket.imageCommandCount = Convert.ToUInt16(strings[13]);

                packets.Add(newPacket);
            } catch(Exception e)
            {

            }
        }

        public List<TelemetryPacket> getPackets(int firstIndex, int count)
        {
            if (firstIndex + count <= NumberOfPackets)
                return packets.GetRange(firstIndex, count);
            else
                throw new ArgumentOutOfRangeException();
        }
    }
}
