using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task2
{
    interface IMedia
    {
        void Stop();
        void Pause();
        void ShowStatus();
        void ShowItem();
    }
    interface IPlayable:IMedia
    {
        void Play();
    }
    interface IRecordable:IMedia
    {
        void Record();
    }
    class Playable : IPlayable
    {
        public string currentFile;
        public string status = "off";
        public Playable(string currentFile)
        {
            this.currentFile = currentFile;
            ShowStatus();
        }
        public void Pause()
        {
            status = "stopped";
            ShowStatus();
        }
        public void Play()
        {
            status = "playing";
            ShowStatus();
        }
        public void Stop()
        {
            status = "off";
            ShowStatus();
        }
        public void ShowStatus()
        {
            Console.WriteLine(status);
        }
        public void ShowItem()
        {
            Console.WriteLine(this.currentFile);
        }
    }
    class Recordable : IRecordable
    {
        public string currentFile;
        public string status="off";
        public Recordable(string currentFile)
        {
            this.currentFile = currentFile;
            ShowStatus();
        }
        public void Pause()
        {
            status = "stopped";
            ShowStatus();
        }
        public void Record()
        {
            status = "recording";
            ShowStatus();
        }
        public void Stop()
        {
            status = "off";
            ShowStatus();
        }
        public void ShowStatus()
        {
            Console.WriteLine(status);
        }
        public void ShowItem()
        {
            Console.WriteLine(this.currentFile);
        }
    }
    class PlayerItem
    {
        public List<IMedia> players=new List<IMedia>();
        public PlayerItem(string path)
        {
           var array= new DirectoryInfo(path).GetFiles();
            for (var i = 0; i <array.Length; i++)
            {
                var item = array[i] + "";
                var format= new FileInfo(item).Extension.Split('.')[1];
                if (format == "mp3") players.Add(new Recordable(item));
                else if (format == "mkv") players.Add(new Playable(item));
                else
                {
                    if (new Random().Next(0, 1)==0) players.Add(new Playable(item));
                    else players.Add(new Recordable(item));
                }
            }
        }
        public List<IMedia> GetControls()
        {
            return players;
        }
    }
}
