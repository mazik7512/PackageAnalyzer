using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseModule
{

    public class NotSupportedSubModulesException : Exception
    {
        public NotSupportedSubModulesException() 
            : base("Не поддерживает загрузку саб - модулей")
        {

        }
    }

    public interface IModule
    {
        string moduleName { get; }
        string moduleVersion { get; }
        string moduleDesc { get; }
        Bitmap icon { get; }
        void Run(IHost host);
        void LoadSubModule(Control subModule, string target);
        void Proceed(ref byte[] array, params string[] lines);
    }
    public interface Internal
    {

    }
}
