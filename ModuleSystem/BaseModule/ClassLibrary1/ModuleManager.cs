using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace BaseModule
{
    public class ModuleManager
    {
        public List<IModule> modules = new List<IModule>();

        public void ScanModules(string directory)
        {
            
            
            foreach (var file in Directory.EnumerateFiles(directory, "*.dll", SearchOption.AllDirectories))
            {
                try
                {

                    Assembly assembly = Assembly.LoadFile(file);
                    
                    foreach (var type in assembly.GetTypes())
                    {
                        var i = type.GetInterface("IModule");
                        if (i != null)
                        {
                            modules.Add(assembly.CreateInstance(type.FullName) as IModule);
                        }
                    }


                }
                catch (Exception e)
                {
                    MessageBox.Show("Не удалось загрузить модуль " + file);
                    Console.WriteLine(e.StackTrace);
                }
            }

        }
    }
}
