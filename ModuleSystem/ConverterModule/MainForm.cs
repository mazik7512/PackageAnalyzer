using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConverterModule
{
    public partial class MainForm : Form
    {
        private byte[] array;
        private int lStr;

        private delegate void FunctionPointer();

        private FunctionPointer CurrentMode;

        public MainForm()
        {
            InitializeComponent();
        }

        public void setData(ref byte[] arr, int _lStr)
        {
            array = arr;
            lStr = _lStr;
        }

        private void printBinaryDataInTextBox()
        {
            StringBuilder stringBuilder = new StringBuilder();
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (j == lStr - 1)
                {
                    stringBuilder.Append(Environment.NewLine);
                    j = 0;
                }
                stringBuilder.Append(array[i]);
                j++;
            }
            DataTextBox.Text = stringBuilder.ToString();
            //stringBuilder.Clear();
            stringBuilder.Remove(0, stringBuilder.Length);
        }

        private void printDecDataInTextBox()
        {
            StringBuilder stringBuilder = new StringBuilder();
            int j = 0;
            byte[] arr = ConverterBits.ToDecArray(ref array);
            for (int i = 0; i < arr.Length; i++)
            {
                if (j == (lStr / 8) - 1)
                {
                    stringBuilder.Append(Environment.NewLine);
                    j = 0;
                }
                stringBuilder.Append(arr[i]).Append(' ');
                j++;
            }
            DataTextBox.Text = stringBuilder.ToString();
            stringBuilder.Remove(0, stringBuilder.Length);
        }

        private void printHexDataInTextBox()
        {
            byte[] arr = ConverterBits.ToHexArray(ref array);
            char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            StringBuilder stringBuilder = new StringBuilder();
            int j = 0;
            for (int i = 0; i < arr.Length - 1; i += 2)
            {
                if (j == (lStr / 8) - 1)
                {
                    stringBuilder.Append(Environment.NewLine);
                    j = 0;
                }
                stringBuilder.Append(symbols[arr[i + 1] % 16]).Append(symbols[arr[i] % 16]);
                j++;
            }
            DataTextBox.Text = stringBuilder.ToString();
            stringBuilder.Remove(0, stringBuilder.Length);
        }

        public void Print_Data()
        {
            if (CurrentMode != null && array != null)
            {
                CurrentMode.Invoke();
            }
        }

        private void binaryDataButton_Click(object sender, EventArgs e)
        {
            CurrentMode = new FunctionPointer(printBinaryDataInTextBox);
            Print_Data();
        }

        private void decDataButton_Click(object sender, EventArgs e)
        {
            CurrentMode = new FunctionPointer(printDecDataInTextBox);
            Print_Data();
        }

        private void hexDataButton_Click(object sender, EventArgs e)
        {
            CurrentMode = new FunctionPointer(printHexDataInTextBox);
            Print_Data();
        }
    }
}
