using System;
using System.Collections.Generic;
using System.Threading;
using XBee;
using XBee.Frames;

namespace SDSL.GliderGroundStation.Model
{
    class VehicleCommunication : IVehicleCommunication
    {
        public event EventHandler NewTelemetry;
        public event EventHandler NewPhoto;

        private PhotoHandler photoHandler;

        private Telemetry tel;
        private DataBackup backup;

        private XBee.XBee controller;
        private XBeeNode glider;
        private XBeeNode container;

        private bool connected = false;

        public VehicleCommunication()
        {
            //Ground station xbee settings
            controller = new XBee.XBee { ApiType = ApiTypeValue.EnabledWithEscape };
            controller.reader.FrameReceived += Reader_FrameReceived;

            //Glider xbee settings
            glider = new XBee.XBeeNode();
            glider.Address64 = new XBeeAddress64(0x13A20040F16C58);
            glider.Address16 = new XBeeAddress16(0xFFFE);

            //Container xbee settings
            container = new XBee.XBeeNode();
            container.Address64 = new XBeeAddress64(0x13A20040B1D2A1);
            container.Address16 = new XBeeAddress16(0xFFFE);

            tel = new Telemetry();
            backup = new DataBackup();
            photoHandler = new PhotoHandler();
        }

        public string filename
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public int NumberOfTelemetryPackets { get { return tel.NumberOfPackets; } }

        public void commandAudio()
        {
            if (connected)
            {
                TransmitDataRequest tx = new TransmitDataRequest(glider);

                byte[] data = BitConverter.GetBytes((int)Commands.ACTIVATE_AUDIO);

                tx.SetRFData(data);

                controller.Execute(tx);
            }
        }

        public void commandMissionStart()
        {
            if (connected)
            {
                TransmitDataRequest tx = new TransmitDataRequest(glider);

                byte[] data = BitConverter.GetBytes((int)Commands.SET_MODE);

                tx.SetRFData(data);

                controller.Execute(tx);
            }
        }

        public void commandPhoto(int angle)
        {
            if (connected)
            {
                TransmitDataRequest tx = new TransmitDataRequest(glider);

                byte[] data1 = BitConverter.GetBytes((int)Commands.TAKE_PHOTO);
                byte[] data2 = BitConverter.GetBytes(angle);

                byte[] dataFinal = new byte[8];
                Buffer.BlockCopy(data1, 0, dataFinal, 0, 4);
                Buffer.BlockCopy(data2, 0, dataFinal, 4, 4);

                tx.SetRFData(dataFinal);

                controller.Execute(tx);
            }
        }

        public void commandRelease()
        {
            if (connected)
            {
                RemoteATCommand tx = new RemoteATCommand( AT.DigitalIO1, container);
                tx.SetValue(new ATLongValue(5));//Set high
                tx.RemoteOptions = 2;

                controller.Execute(tx);

                TimerCallback callbackStop = new TimerCallback(endRelease);
                Timer stopRelease = new Timer(callbackStop, new TimerCallbackObject(controller, container), new TimeSpan(0, 0, 10), new TimeSpan(0, 0, 0));
            }
        }

        public static void endRelease(object obj)
        {
            TimerCallbackObject xbees = obj as TimerCallbackObject;

            RemoteATCommand tx = new RemoteATCommand(AT.DigitalIO1, xbees.node);
            tx.SetValue(new ATLongValue(4));//Set low
            tx.RemoteOptions = 2;

            xbees.bee.Execute(tx);
        }

        public List<TelemetryPacket> getRangeOfRecentPackets(int numberOfPackets)
        {
            try
            {
                return tel.getPackets((tel.NumberOfPackets - numberOfPackets), numberOfPackets);
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }

        public void openConnections()
        {
            if (!connected)
            {
                try
                {
                    controller.SetConnection(new SerialConnection("COM4", 57600)); //TODO COM port discovery
                    connected = true;
                }
                catch(Exception Exc)
                {
                    connected = false;
                }
            }

        }

        private void Reader_FrameReceived(object sender, FrameReceivedArgs args)
        {
            XBeeFrame frame = args.Response;
            switch (Convert.ToChar(((ZigBeeReceivePacket)frame).Data[0])) //Convert first byte of packet to char
            {
                case '4': //Telemetry data
                    if (frame.GetCommandId() == XBeeAPICommandId.RECEIVE_PACKET_RESPONSE)
                    {
                        tel.addPacket((ZigBeeReceivePacket) frame);
                        backup.saveTelemetryPacket((ZigBeeReceivePacket) frame);

                        if(NewTelemetry != null)
                            NewTelemetry.Invoke(this, new EventArgs());
                    }
                    break;

                case 'n': //New photo
                    if (frame.GetCommandId() == XBeeAPICommandId.RECEIVE_PACKET_RESPONSE)
                    {
                        photoHandler.newPhoto((ZigBeeReceivePacket)frame);

                        /*if (NewTelemetry != null)
                            NewTelemetry.Invoke(this, new EventArgs());*/
                    }
                    break;

                case 'p': //Photo packet
                    if (frame.GetCommandId() == XBeeAPICommandId.RECEIVE_PACKET_RESPONSE)
                    {
                        photoHandler.addPacket((ZigBeeReceivePacket)frame);

                        /*if (NewTelemetry != null)
                            NewTelemetry.Invoke(this, new EventArgs());*/
                    }
                    break;

                default:
                    break;
            }
        }

        private enum Commands
        {
            NONE = 1,
            SET_MODE = 2,
            RELEASE_PAYLOAD = 3,
            TAKE_PHOTO = 4,
            ACTIVATE_AUDIO = 5,
            ERROR = 6
        }

        class TimerCallbackObject
        {
            public TimerCallbackObject(XBee.XBee bee, XBeeNode node)
            {
                this.bee = bee;
                this.node = node;
            }

            public XBee.XBee bee;
            public XBeeNode node;
        }
    }
}
