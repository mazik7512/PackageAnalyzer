using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseModule;

public class Help_Module : IModule , Internal
{
    private string[] modules;

    public string moduleName
    {
        get { return "Справка"; }
    }

    public string moduleVersion
    {
        get { return "Версия 1.0"; }
    }

    public string moduleDesc
    {
        get { return "Модуль справки, предоставляющий информацию о приложении"; }
    }

    public System.Drawing.Bitmap icon
    {
        get { return HelpModule.Resources.Info; }
    }

    public void LoadSubModule(System.Windows.Forms.Control subModule, string target)
    {
        throw new NotImplementedException();
    }

    public void Proceed(ref byte[] array, params string[] lines)
    {
        modules = lines;
    }

    public void Run(IHost host)
    {
        ToolStripMenuItem help = new ToolStripMenuItem("Справка");
        help.Image = HelpModule.Resources.Info;
        help.Click += Help_Click;

        host.AddNewMenuStripToMainForm(help);
    }

    private void Help_Click(object sender, EventArgs e)
    {
        HelpModule.AboutBox aboutBox = new HelpModule.AboutBox(modules);
        aboutBox.ShowDialog();
    }

}

