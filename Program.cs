using System;
using System.IO;
using Taks1;
using Task2;
namespace Dead
{
     
    class Program
    {
        static public string path = "C:/My/Programesoft/C#/C# files/Dead/Dead/media";
        static void Task1()
        {
            var manageFiles = new AbstractHandler(path+"/big-waves.mkv", "lorem ipsum dolor");
            manageFiles.Open();
        }
        static void Task2()
        {
            var controls=new PlayerItem(path).GetControls();
            controls[0].Stop();
        }
        static void Task3()
        {
            var pongo = new PolarBear();
            for (var i = 0; i <4; i++)
            {
                pongo.Atack();
            }
            pongo.Sleep();
            var mirinda = new Owl();

            for (var i = 0; i <5; i++)
            {
                mirinda.Fly();
            }
            mirinda.Walk();
            mirinda.Sleep();
        }
        static void Main()
        {
           // Task1();
           // Task2();
            //Task3();
        }
    }
}
