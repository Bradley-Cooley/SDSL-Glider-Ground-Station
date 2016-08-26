using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDSL.GliderGroundStation.Model
{
    public interface IVehicleCommunication
    {
        event EventHandler NewTelemetry;

        event EventHandler NewPhoto;

        string filename { set; }

        int NumberOfTelemetryPackets { get; }

        List<TelemetryPacket> getRangeOfRecentPackets(int numberOfPackets);

        void openConnections();

        void commandRelease();

        void commandAudio();

        void commandPhoto(int angle);
    }
}
