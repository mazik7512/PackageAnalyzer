using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace PackageAnalyzer
{
    class NMEAPackage
    {
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
        //Широта
        public string Latitude { get; set; }
        public double LatitudeMinutes { get; set; }
        public double LatitudeSeconds { get; set; }
        public string LatitudeDirection { get; set; }
        //Долгота
        public string Longitude { get; set; }
        public double LongitudeMinutes { get; set; }
        public double LongitudeSeconds { get; set; }
        public string LongitudeDirection { get; set; }
        //////////////////////////////////
        //////////////////////////////////

        private byte[] ipMarker = { 1, 0, 1, 0, 0, 0, 1, 0 };
        private byte[] udpMarker = { 1, 0, 0, 0, 1, 0, 0, 0 };
        private byte[] tcpMarker = { 0, 1, 1, 0, 0, 0, 0, 0 };

        public NMEAPackage()
        {

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
            //Console.WriteLine(res);

            //res = Convert.ToInt32(str.ToString(), 2);
            //Console.WriteLine(res + " " + str.ToString());
            return res;
        }

        private double convertToDouble(byte[] array, int index, int count)
        {
            double res = 0.0d;
            byte[] temp = new byte[1];
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                temp[0] = 0;
                for (int j = 0; j < 8 ; j++)
                {
                    temp[0] |= Convert.ToByte(array[index + i + j] << j);
                }
                stringBuilder.Append(Encoding.GetEncoding(1252).GetChars(temp));
                i += 7;
            }
            res = Convert.ToDouble(stringBuilder.ToString());
            return res;
        }


        public void SetData(byte[] array)
        {
            byte[] temp = new byte[1];
            int portOffset = 72;

            for (int i = 0; i < array.Length - 400; i++)
            {
                //Проверка на ip
                if (array[i] == ipMarker[0] && array[i + 1] == ipMarker[1])
                {
                    for (int j = 2; j < ipMarker.Length; j++)
                    {
                        if (array[i + j]!=ipMarker[j])
                        {
                            break;
                        }
                        else if (j == ipMarker.Length - 1 && array[i + j] == ipMarker[j])
                        {
                            if (convertToByte(array, i + portOffset, 8) == 17)
                            {
                                //биты идут наоборот
                                IpVersionNumber = Convert.ToByte(convertToByte(array, i + 4, 4));
                                IpHeaderLength = Convert.ToByte(convertToByte(array, i, 4));
                                IpTOS = Convert.ToByte(convertToByte(array, i + 8, 8));
                                IpTotalLength = convertToShort(array, i + 16, 16);
                                ///
                                
                                IpPackageID = convertToShort(array, i + 32, 16);
                                IpDfFlag = Convert.ToBoolean(array[i + 63]);
                                IpMfFlag = Convert.ToBoolean(array[i + 62]);
                                IpFragmentOffset = convertToShort(array, i + 48, 13);
                                ///
                                IpTTL = Convert.ToByte(convertToByte(array, i + 64, 8));
                                IpProtocol = Convert.ToByte(convertToByte(array, i + 72, 8));
                                IpCheckSum = (convertToShort(array, i + 80, 16).ToString());
                                ///
                                IpSource = (convertToByte(array, i + 96, 8).ToString() + "."
                                    + convertToByte(array, i + 104, 8).ToString() + "."
                                    + convertToByte(array, i + 112, 8).ToString() + "."
                                    + convertToByte(array, i + 120, 8).ToString());
                                ///
                                IpDestination = (convertToByte(array, i + 128, 8).ToString() + "."
                                    + convertToByte(array, i + 136, 8).ToString() + "."
                                    + convertToByte(array, i + 144, 8).ToString() + "."
                                    + convertToByte(array, i + 152, 8).ToString());
                                ///
                                UdpSourcePort = convertToShort(array, i + 160, 16).ToString();
                                UdpDestinationPort = convertToShort(array, i + 176, 16).ToString();
                                UdpLength = convertToShort(array, i + 192, 16);
                                UdpCheckSum = convertToShort(array, i + 208, 16).ToString();
                                ///
                                //ИДЕЯ: ПЕРЕВЕСТИ ВЕСЬ БЛОК ДАННЫХ В ТЕКСТ И ТАМ УЖЕ ИСКАТЬ
                                for (int l = 0, offset = 0; l < 7; l++, offset+=8)
                                {
                                    temp[0] = convertToByte(array, i + 256 + offset, 8);
                                    DataCallSign += Encoding.GetEncoding(1252).GetString(temp);
                                }
                                ///
                                for (int l = 0, offset = 0; l < 5; l++, offset += 8)
                                {
                                    temp[0] = convertToByte(array, i + 336 + offset, 8);
                                    NmeaId += Encoding.GetEncoding(1252).GetString(temp);
                                }
                                ///
                                temp[0] = convertToByte(array, i + 552, 8);
                                Latitude += Encoding.GetEncoding(1252).GetString(temp);
                                temp[0] = convertToByte(array, i + 560, 8);
                                Latitude += Encoding.GetEncoding(1252).GetString(temp);
                            }

                        }
                    }
                }
            }
        }

       
    }
}
