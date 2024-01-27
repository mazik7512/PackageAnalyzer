using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IpPackageParser
{
    public class IPPackageParser
    {
        private byte[] data;
        private List<IPHeader> iPHeaders;
        private List<UDPHeader> udpHeaders;
        private List<NMEAData> nmeaData;

        public IPPackageParser(ref byte[] _data)
        {
            data = _data;
        }


        public List<IPHeader> GetIPHeaders()
        {
            iPHeaders = new List<IPHeader>();
            for (int i = 0; i < data.Length; i++)
            {
                IPHeader iPHeader = new IPHeader();
                if (iPHeader.SetData(ref data, ref i))
                {
                    iPHeaders.Add(iPHeader);
                }
                
            }
            return iPHeaders;
        }

        public List<UDPHeader> GetUDPHeaders()
        {
            udpHeaders = new List<UDPHeader>();
            for (int i = 0; i < iPHeaders.Count; i++)
            {
                UDPHeader udpHeader = new UDPHeader();
                udpHeader.parseUDPBlock(ref data, iPHeaders.ElementAt(i).NextBlockIndex);
                udpHeaders.Add(udpHeader);
            }
            return udpHeaders;
        }
        
        public List<NMEAData> GetNMEAData()
        {
            nmeaData = new List<NMEAData>();
            for (int i = 0; i < udpHeaders.Count; i++)
            {
                try
                {
                    NMEAData _nmeaData = new NMEAData();
                    _nmeaData.parseDataBlock(ref data, udpHeaders.ElementAt(i).NextBlockIndex, udpHeaders.ElementAt(i).UdpLength);
                    nmeaData.Add(_nmeaData);
                }
                catch (Exception)
                {
                    Console.WriteLine("err at " + i);
                    iPHeaders.Remove(iPHeaders.ElementAt(i));
                    udpHeaders.Remove(udpHeaders.ElementAt(i));
                    i -= 1;
                }

            }
            return nmeaData;
        }

    }
}
