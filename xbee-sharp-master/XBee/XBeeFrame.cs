namespace XBee
{
    public abstract class XBeeFrame
    {
        protected XBeeAPICommandId CommandId;
        public byte FrameId { get; set; }
        public bool valid { get; set; }

        public XBeeAPICommandId GetCommandId()
        {
            return CommandId;
        }

        public abstract byte[] ToByteArray();
        public abstract void Parse();
    }
}
