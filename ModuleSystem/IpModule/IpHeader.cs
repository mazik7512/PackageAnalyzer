using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BinaryConverter;


namespace IpModule
{
    /// <summary>
    /// Не используется, перенесено в библиотеку IpPackageParser
    /// </summary>
    [Obsolete("Перенесен в библиотеку IpPackageParser")]
    public class IpHeader
    {

        private byte[] ipMarker = { 1, 0, 1, 0, 0, 0, 1, 0 };
        public bool verified = false;
        public int NextBlockIndex { get; set; }

        private ushort[] blocks = new ushort[10];

        public byte IpVersionNumber { get; set; }
        public byte IpHeaderLength { get; set; }
        public byte IpTOS { get; set; }
        public ushort IpTotalLength { get; set; }
        public ushort IpPackageID { get; set; }
        public bool IpDfFlag { get; set; }
        public bool IpMfFlag { get; set; }
        public ushort IpFragmentOffset { get; set; }
        public byte IpTTL { get; set; }
        public byte IpProtocol { get; set; }
        public ushort _IpCheckSum { get; set; }
        public string IpCheckSum { get; set; }
        public uint _IpSource { get; set; }
        public string IpSource { get; set; }
        public uint _IpDestination { get; set; }
        public string IpDestination { get; set; }

        public IpHeader()
        {
            IpVersionNumber = 0;
            IpHeaderLength = 0;
            IpTOS = 0;
            IpTotalLength = 0;
            IpPackageID = 0;
            IpDfFlag = false;
            IpMfFlag = false;
            IpFragmentOffset = 0;
            IpTTL = 0;
            IpProtocol = 0;
            IpCheckSum = "";
            _IpCheckSum = 0;
            IpSource = "";
            _IpSource = 0;
            IpDestination = "";
            _IpDestination = 0;
            NextBlockIndex = 0;
        }



        public void verifyCheckSum()
        {
            uint checksum = 0;
            for (int i = 0; i < blocks.Length; i++)
            {
                checksum += blocks[i];
            }
            checksum = ~((checksum >> 16) + (checksum & 0xffff));
            if ((ushort)checksum == 0)
            {
                verified = true;
            }
        }

        private void ParseIPBlock(ref byte[] array, int index)
        {

            int _index = index;
            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = (ushort)Binary_Converter.ConvertToShort(ref array, _index, 16);
                _index += 16;
            }
            verifyCheckSum();
            //биты идут наоборот
            IpVersionNumber = (byte)(blocks[0] >> 12 & 0x0f);
            IpHeaderLength = (byte)(blocks[0] >> 8 & 0x0f);
            IpTOS = (byte)(blocks[0] & 0xff);
            IpTotalLength = blocks[1];
            ///

            IpPackageID = blocks[2];
            IpDfFlag = Convert.ToBoolean(blocks[3] >> 14 & 0x1);
            IpMfFlag = Convert.ToBoolean(blocks[3] >> 13 & 0x1);
            IpFragmentOffset = (ushort)(blocks[3] & 0x0d);
            ///
            IpTTL = (byte)(blocks[4] >> 8 & 0xff);
            IpProtocol = (byte)(blocks[4] & 0xff);

            IpCheckSum = "0x" + blocks[5].ToString("X");
            _IpCheckSum = blocks[5];

            ///
            IpSource = (blocks[6] >> 8) + "." + (blocks[6] & 0xff) + "."
                + (blocks[7] >> 8) + "." + (blocks[7] & 0xff);
            _IpSource = (uint)((blocks[6] << 16) | blocks[7]);
            ///
            IpDestination = (blocks[8] >> 8) + "." + (blocks[8] & 0xff) + "."
                + (blocks[9] >> 8) + "." + (blocks[9] & 0xff);
            _IpDestination = (uint)((blocks[8] << 16) | blocks[9]);
            NextBlockIndex = index + (IpHeaderLength * 32);


        }


        public bool SetData(ref byte[] array, ref int index)
        {
            int portOffset = 72;
            try
            {
                for (int i = index; i < array.Length /*- 224*/; i++)
                {
                    //Проверка на ip
                    if (array[i] == ipMarker[0] && array[i + 1] == ipMarker[1])
                    {
                        for (int j = 2; j < ipMarker.Length; j++)
                        {
                            if (array[i + j] != ipMarker[j])
                            {
                                break;
                            }
                            else if (j == ipMarker.Length - 1 && array[i + j] == ipMarker[j])
                            {
                                if (Binary_Converter.ConvertToByte(ref array, i + portOffset, 8) == 17
                                    || Binary_Converter.ConvertToByte(ref array, i + portOffset, 8) == 6)
                                {
                                    ParseIPBlock(ref array, i);
                                    index = i + (IpTotalLength * 8);
                                    return true;
                                }

                            }
                        }
                    }
                }

            }
            catch
            {
                
            }
            return false;
        }


    }
}
