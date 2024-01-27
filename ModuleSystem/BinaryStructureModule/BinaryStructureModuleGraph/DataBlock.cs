using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryStructureModuleGraph
{
    public class DataBlock
    {
        public int blockSize;
        public int StartIndex { get; set; }
        public int Length { get; set; }
        
        public DataBlock(int _blockSize)
        {
            blockSize = _blockSize;
        }

        public void setDataBlock(int start, int end)
        {
            if (start < end)
            {
                int _blockSize = (end < blockSize) ? end : blockSize;
                _blockSize = ((start + blockSize) > end) ? (end - start) : _blockSize;
                StartIndex = start;
                Length = _blockSize;
            }
            else
            {
                Console.WriteLine("[ОШИБКА] Индекс начала блока данных превышает размеры массива");
            }
        }
        /*
        private byte[] dataBlock;

        public DataBlock(int _blockSize)
        {
            blockSize = _blockSize;
            dataBlock = new byte[blockSize];
        }

        public void setDataBlock(ref byte[] data, int start)
        {
            if (start < data.Length)
            {
                int _blockSize = (data.Length < blockSize) ? data.Length : blockSize;
                _blockSize = ((start + blockSize) > data.Length) ? (data.Length - start) : _blockSize;
                Array.ConstrainedCopy(data, start, dataBlock, 0, _blockSize);
            }

        }

        public byte[] getData()
        {
            return dataBlock;
        }

        public byte getElem(int i)
        {
            return dataBlock[i];
        }
        */
    }
}
