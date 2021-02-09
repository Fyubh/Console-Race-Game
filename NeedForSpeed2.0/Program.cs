using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NeedForSpeed2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller Game = new Controller();
            Game.Run();
            //GameRoad Run = new GameRoad(new MyCar());
            //int i = 0;
            //Random rnd = new Random();
            //while (true)
            //{
            //    i = rnd.Next(3);
            //    if (i == 2)
            //    {
            //        Run.AddBarrier();
            //    }
            //    Run.DeleteBarrier();
            //    Run.MoveBarrier();
            //    Run.MoveCar();
            //    Run.TEST();
            //    if (Run.IsCollision() == true)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("ВЫ ПРОИГРАЛИ!!!");
            //        break;
            //    }
            //    i++;
            //}
            Console.ReadKey();
        }
    }
}
