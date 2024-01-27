using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BinaryStructureModuleGraph
{
    public class DataContainer
    {

        private int blockSize;
        public int Length { get; set; }
        private byte[] _data;
        private int lStr;
        
        public DataBlock[] DataBlocks { get; set; }

        public DataContainer(ref byte[] data, int _lStr)
        {
            _data = data;
            lStr = _lStr;
        }
        private int CalculateImageHeight(ref byte[] array)
        {
            int screenHeight = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height * 0.8);
            return screenHeight;
        }
        private int CalculateBlockSize(ref byte[] array)
        {
            return CalculateImageHeight(ref array) * lStr;
        }
        private int CalculateBlockQuantity(ref byte[] array, int blockSize)
        {
            int res = array.Length / blockSize;
            if (res % blockSize == 0 && res != 0)
            {
                return res;
            }
            return array.Length / blockSize + 1;
        }

        public void proceedData()
        {
            blockSize = CalculateBlockSize(ref _data);
            int blockQuantity = CalculateBlockQuantity(ref _data, blockSize);
            DataBlocks = new DataBlock[blockQuantity];
            int _start = 0;
            for (int i = 0; i < blockQuantity; i++, _start += blockSize)
            { 
                DataBlocks[i] = new DataBlock(blockSize);
                DataBlocks[i].setDataBlock(_start, _data.Length);
            }
            Length = _data.Length;
        }

        public DataBlock getBlock(int index)
        {
            return DataBlocks[index];
        }

        public byte[] getBlockData(int blockIndex)
        {
            DataBlock temp_block = DataBlocks[blockIndex];
            int _blockSize = (blockSize > temp_block.Length) ? temp_block.Length : blockSize;
            byte[] temp_arr = new byte[_blockSize];
            Array.ConstrainedCopy(_data, temp_block.StartIndex, temp_arr, 0, _blockSize);
            return temp_arr;
        }

        public ref byte[] getData()
        {
            return ref _data;
        }

    }
}
