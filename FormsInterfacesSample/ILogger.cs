using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Enviroment;

namespace FormsInterfacesSample
{
    interface ILogger
    {
        void Log(string data);
    }

    class FileLogger : ILogger
    {
        public void Log(string data)
        {
            //Log data to documents folder
            //string path =
            //    Environment.GetFolderPath(
            //                Environment.SpecialFolder.MyDocuments);
            //path = System.IO.Path.Combine(path, "log.txt");

            string path = Environment.GetFolderPath(
                            Environment.SpecialFolder.MyDocuments);

            path = Path.Combine(path, "log.txt");

            File.AppendAllText(path, data);
        }
    }

    class ConsoleLogger : ILogger
    {
        /// <summary>
        /// Logs information to the Console
        /// </summary>
        /// <param name="data"></param>
        public void Log(string data)
        {
            Console.WriteLine(data);
        }
    }
}
