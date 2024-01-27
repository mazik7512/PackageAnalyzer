using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaseModule;


public class Binary_Converter : IModule, Internal
{
    public string moduleName
    {
        get { return "Бинарный конвертер"; }
    }

    public string moduleVersion
    {
        get { return "Версия 1.0"; }
    }

    public string moduleDesc
    {
        get { return "Внутренний модуль, позволяющий конвертировать биты в байты и наоборот"; }
    }

    public System.Drawing.Bitmap icon
    {
        get { return BinaryConverter.Resources.BinaryConverter; }
    }

    public static byte ConvertToByte(ref byte[] array, int index, int count)
    {
        byte res = 0;
        res = Convert.ToByte(array[index + (count - 1)] << (count - 1));
        for (int i = count - 2; i >= 0; i--)
        {
            res |= Convert.ToByte(array[index + i] << i);
        }
        return res;
    }

    public static ushort ConvertToShort(ref byte[] array, int index, int count)
    {
        int res = 0;
        int i1 = 7;
        for (int i = count - 1; i >= 0; i--, i1--)
        {
            if (i1 == -1)
            {
                i1 = 15;
            }
            res |= array[index + i1] << i;

        }
        return Convert.ToUInt16(res);
    }

    public static int ConvertToInt(ref byte[] array, int index, int count, int startIndex)
    {
        int res = 0;
        int i1 = startIndex;
        for (int i = count - 1; i >= 0; i--)
        {
            if (i1 == -1)
            {
                i1 = count - 1;
            }
            res |= array[index + i1] << i;
            i1--;

        }
        return res;
    }

    public static string ConvertToHexByte(ref byte[] array, int index, int count)
    {
        char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        StringBuilder sb = new StringBuilder();
        byte temp = 0;
        byte temp1 = 0;
        for (int i = count - 1; i >= 0; i -= 4)
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


    public static string ConvertToHexByte(ushort value)
    {
        char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        StringBuilder sb = new StringBuilder();
        byte temp = (byte)(value & 0xf000);
        byte temp1 = (byte)(value & 0x0f00);
        byte temp2 = (byte)(value & 0x00f0);
        byte temp3 = (byte)(value & 0x000f);
        sb.Append(symbols[temp % 16]).Append(symbols[temp1 % 16]).Append(symbols[temp2 % 16]).Append(temp3 % 16);
        return sb.ToString();
    }


    public int BooleanToInt(bool value)
    {
        return (value == false) ? 0 : 1;
    }
    public void Run(IHost host)
    {
        
    }

    public void LoadSubModule(System.Windows.Forms.Control subModule, string target)
    {
        throw new NotSupportedSubModulesException();
    }

    public void Proceed(ref byte[] array, params string[] lines)
    {
        
    }
}

