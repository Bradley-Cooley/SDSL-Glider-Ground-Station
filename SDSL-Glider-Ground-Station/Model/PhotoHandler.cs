using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using XBee.Frames;
using System.IO;
using System.Drawing.Imaging;

namespace SDSL.GliderGroundStation.Model
{
    class PhotoHandler
    {
        private List<Image> images;
        private byte[] rawData;
        private bool[] frameStuff;
        private byte currentPhotoNumber;
        private UInt16 currentNumberPackets;
        private UInt16 receivedPackets;
        private UInt16 currentPhotoLength;

        public PhotoHandler()
        {
            images = new List<Image>();
            rawData = null;
        }

        public void newPhoto(ZigBeeReceivePacket frame)
        {
            currentPhotoNumber = Convert.ToByte(frame.Data[1]);
            currentNumberPackets = BitConverter.ToUInt16(frame.Data, 2);
            currentPhotoLength = BitConverter.ToUInt16(frame.Data, 4);

            rawData = new byte[currentPhotoLength];
            frameStuff = new bool[currentNumberPackets];
            receivedPackets = 0;
        }

        public void addPacket(ZigBeeReceivePacket frame)
        {
            UInt16 packetNumber = BitConverter.ToUInt16(frame.Data, 1);
            frameStuff[packetNumber] = true;
            byte dataLength = Convert.ToByte(frame.Data[3]);
            for(int i = 4; i < frame.Data.Length; i++)
            {
                rawData[(packetNumber * 210) + (i - 4)] = frame.Data[i];
            }

            if(checkAllReceived())
                assembleImage();

            Console.WriteLine("Recieved: " + packetNumber.ToString() + "\tTotal packets: " + receivedPackets.ToString());
        }

        private void assembleImage()
        {
            String filename = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyDoc‌​uments), "GliderGroundStation", "image_" +
                (DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")) + "");

            using (Image image = Image.FromStream(new MemoryStream(rawData)))
            {
                image.Save(filename, ImageFormat.Jpeg);
            }
        }

        private bool checkAllReceived()
        {
            foreach(bool b in frameStuff)
            {
                if (!b)
                    return false;
            }

            return true;
        }
    }
}
