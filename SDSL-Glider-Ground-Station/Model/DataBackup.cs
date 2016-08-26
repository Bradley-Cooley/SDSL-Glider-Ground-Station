using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace SDSL.GliderGroundStation.Model
{
    class DataBackup
    {
        private String filename;
        private String path;
        private FileStream csv;

        public DataBackup()
        {
            filename = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyDoc‌​uments), "GliderGroundStation", "datalog_" + 
                (DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")) +".csv");

            path = Path.GetDirectoryName(filename);
            Directory.CreateDirectory(path);

            csv = new FileStream(filename, FileMode.Create);
        }

        public void saveTelemetryPacket(XBee.Frames.ZigBeeReceivePacket packet)
        {
            byte[] newline = { (byte)'\n' };

            csv.Write(packet.Data, 0, packet.Data.Length);
            csv.Write(newline, 0, 1);
        }

        public void savePhoto(Image image)
        {
            filename = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyDoc‌​uments), "GliderGroundStation", "datalog_" +
                (DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")) + "");

            path = Path.GetDirectoryName(filename);
            Directory.CreateDirectory(path);

            csv = new FileStream(filename, FileMode.Create);
        }
    }
}
