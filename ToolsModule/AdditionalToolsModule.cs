using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseModule;
using System.Drawing;

public class AdditionalToolsModule : IModule, Internal
{
    public string moduleName
    {
        get { return "Дополнительные настройки"; }
    }

    public string moduleVersion
    {
        get { return "Версия 1.0"; }
    }

    public string moduleDesc
    {
        get { return "Модуль, предоставляющий доп. возможности"; }
    }

    public Bitmap icon
    {
        get { return null; }
    }

    public void LoadSubModule(Control subModule, string target)
    {
        throw new NotImplementedException();
    }

    public void Proceed(byte[] array, params string[] lines)
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

