using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseModule;


public class Converter_Module : IModule
{
    private ConverterModule.MainForm mainForm = new ConverterModule.MainForm();

    public string moduleName
    {
        get { return "Конвертер данных"; }
    }

    public string moduleVersion
    {
        get { return "Версия 1.0"; }
    }

    public string moduleDesc
    {
        get { return "Модуль, позволяющий посмотреть данные в двоичном, десятичном и шестнадцетиричном форматах"; }
    }

    public Bitmap icon
    {
        get { return ConverterModule.Resources.ConverterIcon; }
    }

    public void LoadSubModule(Control subModule, string target)
    {
        throw new NotImplementedException();
    }

    public void Proceed(ref byte[] array, params string[] lines)
    {
        int lStr = Convert.ToInt32(lines[0]);
        mainForm.setData(ref array, lStr);
    }

    public void Run(IHost host)
    {
        host.AddControlToMainForm(mainForm.converterPanel);
    }
}

