using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryStructureModuleGraph
{
    public class ParamParser
    {
        public static byte[] StringToMarker(string str)
        {
            byte[] temp = new byte[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals('0') || str[i].Equals('1'))
                {
                    temp[i] = Convert.ToByte(str[i]);
                    temp[i] -= 48;
                }
                else
                {
                    return null;
                }
                
            }
            return temp;
        }



        public static string ParseMarker(ref byte[] marker)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < marker.Length; i++)
            {
                temp.Append(marker[i]);
            }
            return temp.ToString();
        }

        public unsafe static string _ParseMarker(byte* marker, int length)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                temp.Append(marker[i]);
            }
            return temp.ToString();
        }
    }
}
