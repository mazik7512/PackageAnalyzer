using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseModule;


public class UDPHeaderModule : IModule, Internal
{
    public string moduleName
    {
        get { return "UDP-модуль"; }
    }

    public string moduleVersion
    {
        get { return "Версия 1.0"; }
    }

    public string moduleDesc
    {
        get { return "Саб-модуль для IP, реализующий поиск UDP"; }
    }

    public System.Drawing.Bitmap icon
    {
        get { return null; }
    }

    public void LoadSubModule(System.Windows.Forms.Control subModule, string target)
    {
        throw new NotImplementedException();
    }

    public void Proceed(ref byte[] array, params string[] lines)
    {
        throw new NotImplementedException();
    }

    public void Run(IHost host)
    {
        throw new NotImplementedException();
    }
}

