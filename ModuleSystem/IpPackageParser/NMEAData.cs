using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BinaryConverter;

namespace IpPackageParser
{
    public class NMEAData
    {
        private string[] dataBlock;
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
        ///

        public void parseDataBlock(ref byte[] array, int index, int transportHeaderLength)
        {
            byte[] temp = new byte[1];
            StringBuilder sb = new StringBuilder();

            try
            {
                for (int i = index; i < index + transportHeaderLength * 8 - 64; i += 8)
                {
                    temp[0] = Binary_Converter.ConvertToByte(ref array, i, 8);
                    sb.Append(Encoding.GetEncoding(1252).GetChars(temp));
                }
            }
            catch
            {

            }

            dataBlock = sb.ToString().Split(',');
            
            DataCallSign = dataBlock[0].Substring(3, dataBlock[0].IndexOf('$') - 5).Trim();
            Console.WriteLine(DataCallSign);
            NmeaId = dataBlock[0].Substring(dataBlock[0].IndexOf('$') + 1, 5);
            Console.WriteLine(NmeaId);
            NmeaTime = dataBlock[1].Insert(2, ":").Insert(5, ":").Insert(dataBlock[1].Length + 2, " UTC");
            
            NmeaCheck = (dataBlock[2] == "A") ? "Достоверны" : (dataBlock[2] == "V") ? "Не достоверны" : "Нет данных";
            Latitude = dataBlock[3].Insert(2, "°").Insert(dataBlock[3].Length + 1, "``").Replace(".", "`").TrimStart('0');
            Console.WriteLine(Latitude);
            LatitudeDirection = (dataBlock[4] == "N") ? "Север" : (dataBlock[4] == "S") ? "Юг" : "Нет данных";
            Longitude = dataBlock[5].Insert(3, "°").Insert(dataBlock[5].Length + 1, "``").Replace(".", "`");
            Console.WriteLine(Longitude);
            LongitudeDirection = (dataBlock[6] == "E") ? "Восток" : (dataBlock[6] == "W") ? "Запад" : "Нет данных";
            NmeaSpeed = dataBlock[7].TrimStart('0');
            NmeaFlowDirection = dataBlock[8].TrimStart('0');
            NmeaDate = dataBlock[9].Insert(2, ".").Insert(5, ".20");
            NmeaMode = (dataBlock[dataBlock.Length - 1].First() == 'E') ? "Аппроксимация" : (dataBlock[dataBlock.Length - 1].First() == 'A') ? "Автономный" : (dataBlock[dataBlock.Length - 1].First() == 'D') ? "Дифференциальный" : (dataBlock[dataBlock.Length - 1].First() == 'N') ? "Недостовернные данные" : "Отсутсвует";
        }
    }
}
