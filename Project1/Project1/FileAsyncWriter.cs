using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Project1
{
    class FileAsyncWriter
    {
        private StreamWriter sw;
        private ManualResetEvent ev;
        public FileAsyncWriter(string path, ManualResetEvent ev) {
            sw = File.CreateText(path);
            this.ev = ev;
        }
        public void Write(object text)
        {
            sw.WriteLine((string)text);
            sw.Flush();
            ev.Set();
        }
    }
}
