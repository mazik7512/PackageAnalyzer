using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BaseModule
{
    class Config
    {

        class EmptyConfigException : Exception
        {
            public EmptyConfigException() :
                base("[WARNING]: Config corrupted, applyed default params")
            { }
        }


        private static string[] defaultKeys = { "settings", "ip", "mode", "tcp_port", "http_hello_prefix", "http_settings_prefix", "http_info_prefix", "http_port" };
        private static string[] defaultValues = { "9", "0.0.0.0", "dual", "5151", "hello", "settings", "info", "5152" };

        public static Dictionary<string, string> config { get; set; }
        public static string configPath { get; set; }



        public static void writeParam(string key, string value)
        {
            
            FileStream fs = new FileStream(configPath, FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(fs);
            config[key] = value;
            foreach (var item in config)
            {
                writer.WriteLine(item.Key + "=" + item.Value);
            }
            fs.Close();
        }

        private static void _readParams(string[] lines)
        {
            
            for (int i = 0; i < lines.Length; i++)
            {
                if (!lines[i].Equals("") && !lines[i].StartsWith("#") && !lines[i].StartsWith("["))
                {
                    string[] keyValue = parseParam(lines[i]);
                    config.Add(keyValue[0], keyValue[1]);
                }

            }
        }

        public static void readParams()
        {
            config = new Dictionary<string, string>();
            try
            {
                string[] lines = File.ReadAllLines(configPath);
                if (lines.Length < 2)
                {
                    throw new EmptyConfigException();
                }
                _readParams(lines);

            }
            catch (Exception e)
            {
                Console.WriteLine("[CORE] Конфигурационный файл поврежден или отсутвует");
                Console.WriteLine("[CORE] Применены стандартные настройки...");
                try
                {

                    byte[] bytesConfigData = (byte[])Resources.Resources.ResourceManager.GetObject("config");
                    File.WriteAllBytes(configPath, bytesConfigData);
                    readParams();
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private static string[] parseParam(string line)
        {
            string[] temp = line.Split('=');
            return temp;
        }
    }
}
