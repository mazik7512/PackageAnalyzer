using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using BaseModule;
using System.Windows.Forms;


public class IpModuleConstructor : IModule
{
    private IpModule.MainForm mainForm = new IpModule.MainForm();
    public string moduleName
    {
        get { return "Анализ IP-пакетов"; }
    }

    public string moduleVersion
    {
        get { return "Версия 1.0"; }
    }

    public string moduleDesc
    {
        get { return "Модуль анализа IP-заголовков, рекомендуется использовать дополнительные модули"; }
    }

    public Bitmap icon
    {
        get { return IpModule.Resources.Analyze; }
    }

    public void LoadSubModule(Control subModule, string target)
    {
        throw new NotImplementedException();
    }

    public void Proceed(ref byte[] array, params string[] lines)
    {
        mainForm.setData(ref array);
    }

    public void Run(IHost host)
    {
        host.AddControlToMainForm(mainForm.IpPanel);
    }
}

