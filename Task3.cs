using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dead
{
    interface IBird
    {
        public void Fly();
        public int wingSize { get; }
    }
    interface IBear
    {
        public void Atack();
        public int damage { get; }
    }
    interface IAnimal {
        public  string Name { get; }
        public  string Type { get; }
        public  int Age { get; }
        public void Walk();
        public void Sleep();
    }
    class PolarBear : IAnimal, IBear
    {
        public string Name => "Frodo";

        public string Type => "Killer";

        public int Age => 23;

        public int damage => 8;

        public void Atack()
        {
            Console.WriteLine($"damage -{damage*Age/10} HP");    
        }
        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }
        public void Walk()
        {
            Console.WriteLine("walk walk walk");
        }
    }
    class Owl : IAnimal, IBird
    {
        public string Name => "willa";

        public string Type => "defender";

        public int Age => 8;

        public int wingSize => 14;

        public void Fly()
        {

            Console.WriteLine($"flight{Age*wingSize/10}");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }

        public void Walk()
        {
            Console.WriteLine("walk walk walk");
        }
    }
}
