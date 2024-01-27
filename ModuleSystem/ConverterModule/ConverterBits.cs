using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConverterModule
{
    class ConverterBits
    {
        public static byte[] ToDecArray(ref byte[] array)
        {
            int k = 0;
            byte[] temp = new byte[array.Length / 8];
            for (int i = 0; i < array.Length - 7; i += 8)
            {
                temp[k] = Convert.ToByte(array[i + 7] << 7);
                for (int j = 6; j >= 0; j--)
                {
                    temp[k] |= Convert.ToByte(array[i + j] << j);
                }
                k++;
            }
            return temp;
        }

        public static byte[] ToHexArray(ref byte[] array)
        {

            byte[] temp = new byte[(array.Length / 8) * 2];
            int k = 0;
            for (int i = 0; i < array.Length - 3; i += 4)
            {
                temp[k] = Convert.ToByte(array[i + 3] << 3);
                for (int j = 2; j >= 0; j--)
                {
                    temp[k] |= Convert.ToByte(array[i + j] << j);
                }
                k++;

            }

            return temp;
        }

    }
}
