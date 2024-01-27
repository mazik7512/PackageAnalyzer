using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace PackageAnalyzer
{
    public class NMEAPackage
    {
        
        private ushort[] blocks = new ushort[10];
        public bool verified = false;
        //IP
        //////////////////////////////////
        public byte IpVersionNumber { get; set; }
        public byte IpHeaderLength { get; set; }
        public byte IpTOS { get; set; }
        public int IpTotalLength { get; set; }
        public int IpPackageID { get; set; }
        public bool IpDfFlag { get; set; }
        public bool IpMfFlag { get; set; }
        public int IpFragmentOffset { get; set; }
        public byte IpTTL { get; set; }
        public byte IpProtocol { get; set; }
        public string IpCheckSum { get; set; }
        public string IpSource { get; set; }
        public string IpDestination { get; set; }
        //////////////////////////////////
        //UDP
        //////////////////////////////////
        public string UdpDestinationPort { get; set; }
        public string UdpSourcePort { get; set; }
        public int UdpLength { get; set; }
        public string UdpCheckSum { get; set; }
        //////////////////////////////////
        //Data block
        //////////////////////////////////
        public string DataCallSign { get; set; }
        //NMEA
        /////////////////////////////////
        public string NmeaId { get; set; }
        public string NmeaTime { get; set; }
        public string NmeaDate { get; set; }
        public string NmeaFlowDirection { get; set; }
        public string NmeaSpeed { get; set; }
        public string NmeaCheck { get; set; }
        public string NmeaMode { get; set; }
        //Широта
        public string Latitude { get; set; }
        public string LatitudeDirection { get; set; }
        //Долгота
        public string Longitude { get; set; }
        public string LongitudeDirection { get; set; }
        //////////////////////////////////
        //////////////////////////////////


        private string[] dataBlock;

        private byte[] ipMarker = { 1, 0, 1, 0, 0, 0, 1, 0 };
        private byte[] udpMarker = { 1, 0, 0, 0, 1, 0, 0, 0 };
        private byte[] tcpMarker = { 0, 1, 1, 0, 0, 0, 0, 0 };

        public NMEAPackage()
        {

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

        private byte convertToByte(byte[] array, int index, int count)
        {
            byte res = 0;
            StringBuilder str = new StringBuilder();
            for (int i = count - 1; i >= 0; i--)
            {
                str.Append(array[index + i]);
                //res |= Convert.ToByte(array[index + i] << i);
            }
            //Console.WriteLine(res);
            
            res = Convert.ToByte(str.ToString(), 2);
            //Console.WriteLine(res + " " + str.ToString());
            return res;
        }

        private int convertToShort(byte[] array, int index, int count)
        {
            int res = 0;
            StringBuilder str = new StringBuilder();
            int i1 = 7;
            for (int i = count - 1; i >= 0; i--)
            {
                if (i1 == -1)
                {
                    i1 = 15;
                }
                str.Append(array[index + i1]);
                res |= array[index + i1] << i;
                i1--;
               
            }
            return res;
        }

        private int convertToShort(byte[] array, int index, int count, int startIndex)
        {
            int res = 0;
            StringBuilder str = new StringBuilder();
            int i1 = startIndex;
            for (int i = count - 1; i >= 0; i--)
            {
                if (i1 == -1)
                {
                    i1 = count - 1;
                }
                str.Append(array[index + i1]);
                res |= array[index + i1] << i;
                i1--;

            }
            return res;
        }

        private string convertToHexByte(byte[] array, int index, int count)
        {
            char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            StringBuilder sb = new StringBuilder();
            byte temp = 0;
            byte temp1 = 0;
            for (int i = count - 1; i >= 0; i-=4)
            {
                temp = Convert.ToByte(array[index + 3] << 3);
                for (int j = 2; j >= 0; j--)
                {
                    temp |= Convert.ToByte(array[index + j] << j);
                }
                index += 4;
                i -= 4;
                temp1 = Convert.ToByte(array[index + 3] << 3);
                for (int j = 2; j >= 0; j--)
                {
                    temp1 |= Convert.ToByte(array[index + j] << j);
                }
                
            }
            sb.Append(symbols[temp1 % 16]).Append(symbols[temp % 16]);
            return sb.ToString();
        }

        private void parseIPBlock(byte[] array, int index)
        {
            int _index = index;
            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = (ushort)convertToShort(array, _index, 16);
                _index += 16;
            }
            verifyCheckSum();
            //биты идут наоборот

            IpVersionNumber = Convert.ToByte(convertToByte(array, index + 4, 4));
            IpHeaderLength = Convert.ToByte(convertToByte(array, index, 4));
            IpTOS = Convert.ToByte(convertToByte(array, index + 8, 8));
            IpTotalLength = convertToShort(array, index + 16, 16);
            ///
            Console.WriteLine("3 block: " + blocks[3]);
            IpPackageID = convertToShort(array, index + 32, 16);
            IpDfFlag = Convert.ToBoolean(array[index + 54]);
            IpMfFlag = Convert.ToBoolean(array[index + 53]);
            IpFragmentOffset = convertToShort(array, index + 48, 13, 5);
            ///
            IpTTL = Convert.ToByte(convertToByte(array, index + 64, 8));
            IpProtocol = Convert.ToByte(convertToByte(array, index + 72, 8));
            IpCheckSum = (convertToShort(array, index + 80, 16).ToString());
            IpCheckSum = "0x" + convertToHexByte(array, index + 80, 8) + convertToHexByte(array, index + 88, 8);
            ///
            IpSource = (convertToByte(array, index + 96, 8).ToString() + "."
                + convertToByte(array, index + 104, 8).ToString() + "."
                + convertToByte(array, index + 112, 8).ToString() + "."
                + convertToByte(array, index + 120, 8).ToString());
            ///

            IpDestination = (convertToByte(array, index + 128, 8).ToString() + "."
                + convertToByte(array, index + 136, 8).ToString() + "."
                + convertToByte(array, index + 144, 8).ToString() + "."
                + convertToByte(array, index + 152, 8).ToString());
            //IpSource = Convert.ToString((uint)(blocks[6] << 16) | blocks[7]);
            var test = (uint)(blocks[6] << 16) | (blocks[7]);
            var _test = test >> 16 & 0xff;
            //IpDestination = Convert.ToString((uint)(blocks[8] << 16) | blocks[9]);
            char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            StringBuilder sb = new StringBuilder();
            ushort value = 6422;
            Console.WriteLine("{0:X}", value);
            int temp = (int)(value & 0x0000f000);
            int temp1 = (int)(value & 0x00000f00);
            int temp2 = (int)(value & 0x000000f0);
            int temp3 = (int)(value & 0x0000000f);
            Console.WriteLine(temp + " : " + temp1 + " : " + temp2 + " : " + temp3);
            sb.Append(symbols[temp % 16]).Append(symbols[temp1 % 16]).Append(symbols[temp2 % 16]).Append(temp3 % 16);
            Console.WriteLine(sb.ToString());
        }

        private void parseUDPBlock(byte[] array, int index)
        {
            UdpSourcePort = convertToShort(array, index + 160, 16).ToString();
            UdpDestinationPort = convertToShort(array, index + 176, 16).ToString();
            UdpLength = convertToShort(array, index + 192, 16);
            //UdpCheckSum = convertToShort(array, index + 208, 16).ToString();
            UdpCheckSum = "0x" + convertToHexByte(array, index + 208, 8) + convertToHexByte(array, index + 216, 8);
        }

        private void parseDataBlock(byte[] array, int index)
        {
            byte[] temp = new byte[1];
            StringBuilder sb = new StringBuilder();
 
            for (int i = index; i < index + UdpLength * 8 - 64; i+=8)
            {
                temp[0] = convertToByte(array, i, 8);
                sb.Append(Encoding.GetEncoding(1252).GetChars(temp));
            }
            dataBlock = sb.ToString().Split(',');

            DataCallSign = dataBlock[0].Substring(3, dataBlock[0].IndexOf('$') - 5).Trim();
            NmeaId = dataBlock[0].Substring(dataBlock[0].IndexOf('$') + 1, 5);
            NmeaTime = dataBlock[1].Insert(2, ":").Insert(5, ":").Insert(dataBlock[1].Length + 2, " UTC");
            NmeaCheck = (dataBlock[2] == "A") ? "Достоверны" : (dataBlock[2] == "V") ? "Не достоверны" : "Нет данных";
            Latitude = dataBlock[3].Insert(2, "°").Insert(dataBlock[3].Length + 1, "``").Replace(".","`").TrimStart('0');
            LatitudeDirection = (dataBlock[4] == "N") ? "Север" : (dataBlock[4] == "S") ? "Юг" : "Нет данных";
            Longitude = dataBlock[5].Insert(3, "°").Insert(dataBlock[5].Length + 1, "``").Replace(".", "`");
            LongitudeDirection = (dataBlock[6] == "E") ? "Восток" : (dataBlock[6] == "W") ? "Запад" : "Нет данных";
            NmeaSpeed = dataBlock[7].TrimStart('0');
            NmeaFlowDirection = dataBlock[8].TrimStart('0');
            NmeaDate = dataBlock[9].Insert(2, ".").Insert(5, ".20");
            NmeaMode = (dataBlock[dataBlock.Length - 1].First() == 'E') ? "Аппроксимация" : (dataBlock[dataBlock.Length - 1].First() == 'A') ? "Автономный" : (dataBlock[dataBlock.Length - 1].First() == 'D') ? "Дифференциальный" : (dataBlock[dataBlock.Length - 1].First() == 'N') ? "Недостовернные данные" : "Отсутсвует";
        }


        public bool SetData(byte[] array, int index)
        {
            byte[] temp = new byte[1];
            int portOffset = 72;

            try
            {
                for (int i = index; i < array.Length - 224; i++)
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
                                if (convertToByte(array, i + portOffset, 8) == 17 || convertToByte(array, i + portOffset, 8) == 6)
                                {
                                    parseIPBlock(array, i);
                                    ///
                                    parseUDPBlock(array, i);
                                    ///
                                    MainForm.curIndex = i + 224;
                                    parseDataBlock(array, i + 224);
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
