using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClientDevelopment
{
    public class IPCamera
    {
        private string cameraName;
        private int packetSequenceNumber; //Keeping track of the number of packets sent
        private DateTime dateTime;
        private int frameSize;
        private int height, width;

        public IPCamera() { } //default empty constructor

        //Constructor for initializing values of an IPCamera instance.
        public IPCamera(string protocolId, string cameraName, int packetSequenceNumber, DateTime dateTime, int frameSize, int height, int width)
        {
            this.ProtocolId = protocolId;
            this.cameraName = cameraName;
            this.packetSequenceNumber = packetSequenceNumber;
            this.dateTime = dateTime;
            this.frameSize = frameSize;
            this.height = height;
            this.width = width;
        }

        public string ProtocolId { get; set; }
        public string CameraName { get => cameraName; set => cameraName = value; }
        public int PacketSequenceNumber { get => packetSequenceNumber; set => packetSequenceNumber = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public int FrameSize { get => frameSize; set => frameSize = value; }
        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }
    }
}
