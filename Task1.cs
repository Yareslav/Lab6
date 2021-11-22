using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Taks1
{
    class AbstractHandler
    {
        public string path;
        public string text;
        public AbstractHandler(string path, string text = "")
        {
            this.path = path;
            this.text = text;
        }
        public void GetFormat()
        {
            Console.WriteLine(new FileInfo(path).Extension);
        }
        public void Open()
        {
            new FileStream(path, FileMode.Open);
        }
        public void Create()
        {
            new FileStream(path, FileMode.Create);
        }
        public void Edit()
        {
            File.WriteAllText(path, File.ReadAllText(path) + text);
        }
    }
}
