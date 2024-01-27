using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BinaryConverter;

namespace IpPackageParser
{
    public class UDPHeader
    {
        public int NextBlockIndex;
        private ushort[] blocks = new ushort[4];

        public ushort UdpSourcePort { get; set; }
        public ushort UdpDestinationPort { get; set; }
        public ushort UdpLength { get; set; }
        public string UdpCheckSum { get; set; }
        public ushort _UdpCheckSum { get; set; }

        public UDPHeader()
        {
            UdpSourcePort = 0;
            UdpDestinationPort = 0;
            UdpLength = 0;
            UdpCheckSum = "";
            _UdpCheckSum = 0;
        }
        public void parseUDPBlock(ref byte[] array, int index)
        {
            int _index = index;
            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = (ushort)Binary_Converter.ConvertToShort(ref array, _index, 16);
                _index += 16;
            }
            NextBlockIndex = index + 64;
            UdpSourcePort = blocks[0];
            UdpDestinationPort = blocks[1];
            UdpLength = blocks[2];
            UdpCheckSum = "0x" + blocks[3].ToString("X");
            _UdpCheckSum = blocks[3];
        }


    }
}
