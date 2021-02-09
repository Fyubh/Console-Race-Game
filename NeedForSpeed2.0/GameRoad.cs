using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed2._0
{
    class GameRoad : Road
    {
        private Car car = new MyCar();
        private List<Barrier> barriers = new List<Barrier>();

        public override Car GetCar()
        {
            return car;
        }
        public override List<Barrier> GetBarriers()
        {
            return barriers;
        }
        public override void AddBarrier()
        {
            Random rnd = new Random();
            int chance = rnd.Next(0, 100);

            if (chance < 10)
            {
                barriers.Add(new Fence());
            }
            else if (chance < 20)
            {
                barriers.Add(new Bonus());
            }
            else
            {
                barriers.Add(new AnotherCar());
            }
        }
        public override void DeleteBarrier()
        {
            for (int i = 0; i < barriers.Count; i++)
            {
                if (barriers[i].GetCor().Key == car.GetCor().Key && barriers[i].GetCor().Value == car.GetCor().Value
                    || barriers[i].GetCor().Key == car.GetCor().Key - 2 && barriers[i].GetCor().Value == car.GetCor().Value - 1
                    || barriers[i].GetCor().Key == car.GetCor().Key - 2 && barriers[i].GetCor().Value == car.GetCor().Value
                    || barriers[i].GetCor().Key == car.GetCor().Key - 1 && barriers[i].GetCor().Value == car.GetCor().Value
                    || barriers[i].GetCor().Key == car.GetCor().Key && barriers[i].GetCor().Value == car.GetCor().Value - 2
                    || barriers[i].GetCor().Key == car.GetCor().Key && barriers[i].GetCor().Value == car.GetCor().Value - 1
                    || barriers[i].GetCor().Key == car.GetCor().Key && barriers[i].GetCor().Value == car.GetCor().Value + 1
                    || barriers[i].GetCor().Key == car.GetCor().Key + 1 && barriers[i].GetCor().Value == car.GetCor().Value - 2
                    || barriers[i].GetCor().Key == car.GetCor().Key + 1 && barriers[i].GetCor().Value == car.GetCor().Value - 1
                    || barriers[i].GetCor().Key == car.GetCor().Key + 1 && barriers[i].GetCor().Value == car.GetCor().Value
                    || barriers[i].GetCor().Key == car.GetCor().Key + 1 && barriers[i].GetCor().Value == car.GetCor().Value + 1
                    || barriers[i].GetCor().Key == car.GetCor().Key + 2 && barriers[i].GetCor().Value == car.GetCor().Value
                    || barriers[i].GetCor().Key == car.GetCor().Key + 3 && barriers[i].GetCor().Value == car.GetCor().Value - 1
                    || barriers[i].GetCor().Key == car.GetCor().Key + 3 && barriers[i].GetCor().Value == car.GetCor().Value)
                {
                        barriers.RemoveAt(i);
                }
                if (barriers[i].GetCor().Value == Globals.Height)
                {
                    barriers.RemoveAt(i);
                }
            }
        }
        public override void MoveBarrier()
        {
            for (int i = 0; i < barriers.Count; i++)
            {
                barriers[i].Move();
            }
        }
        public override void MoveCar()
        {
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                //while (Console.KeyAvailable) Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    Console.Beep(784, 50);
                    if (car.GetCor().Key >= 3)
                    {
                        car.MoveLeft();
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    Console.Beep(784, 30);
                    if (car.GetCor().Key < Globals.Width - 1)
                    {
                        car.MoveRight();
                    }
                }
            }
        }
        public override int IsCollision()
        {
            for (int i = 0; i < barriers.Count; i++)
            {
                if (barriers[i].GetCor().Key == car.GetCor().Key && barriers[i].GetCor().Value == car.GetCor().Value
                    || barriers[i].GetCor().Key == car.GetCor().Key - 2 && barriers[i].GetCor().Value == car.GetCor().Value - 1
                    || barriers[i].GetCor().Key == car.GetCor().Key - 2 && barriers[i].GetCor().Value == car.GetCor().Value
                    || barriers[i].GetCor().Key == car.GetCor().Key - 1 && barriers[i].GetCor().Value == car.GetCor().Value
                    || barriers[i].GetCor().Key == car.GetCor().Key && barriers[i].GetCor().Value == car.GetCor().Value - 2
                    || barriers[i].GetCor().Key == car.GetCor().Key && barriers[i].GetCor().Value == car.GetCor().Value - 1
                    || barriers[i].GetCor().Key == car.GetCor().Key && barriers[i].GetCor().Value == car.GetCor().Value + 1
                    || barriers[i].GetCor().Key == car.GetCor().Key + 1 && barriers[i].GetCor().Value == car.GetCor().Value - 2
                    || barriers[i].GetCor().Key == car.GetCor().Key + 1 && barriers[i].GetCor().Value == car.GetCor().Value - 1
                    || barriers[i].GetCor().Key == car.GetCor().Key + 1 && barriers[i].GetCor().Value == car.GetCor().Value
                    || barriers[i].GetCor().Key == car.GetCor().Key + 1 && barriers[i].GetCor().Value == car.GetCor().Value + 1
                    || barriers[i].GetCor().Key == car.GetCor().Key + 2 && barriers[i].GetCor().Value == car.GetCor().Value
                    || barriers[i].GetCor().Key == car.GetCor().Key + 3 && barriers[i].GetCor().Value == car.GetCor().Value - 1
                    || barriers[i].GetCor().Key == car.GetCor().Key + 3 && barriers[i].GetCor().Value == car.GetCor().Value)
                {
                    switch (barriers[i].GetType().ToString())
                    {
                        case "NeedForSpeed2._0.Bonus":
                            return 1;
                        case "NeedForSpeed2._0.Fence":
                            return 2;
                        case "NeedForSpeed2._0.AnotherCar":
                            return 3;
                    }
                }
            }
            return 0;
        }
        public void TEST()
        {
            Console.Clear();
            for (int i = (int)Globals.Height; i >= 0; i--)
            {
                for (int j = (int)Globals.Width; j >= 0; j--)
                {
                    if (i == 0 && j == car.GetCor().Key)
                    {
                        Console.Write('@');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                    for (int z = 0; z < barriers.Count; z++)
                    {
                        if (barriers[z].GetCor().Key == j && barriers[z].GetCor().Value == i && i != 0)
                        {
                            switch (barriers[z].GetType().ToString())
                            {
                                case "NeedForSpeed2._0.Bonus":
                                    Console.Write('$');
                                    break;
                                case "NeedForSpeed2._0.Fence":
                                    Console.Write('#');
                                    break;
                                case "NeedForSpeed2._0.AnotherCar":
                                    Console.Write('+');
                                    break;
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
            //for (int i = 0; i < Globals.Width + 1; i++)
            //{
            //    if (i == car.GetCor().Key)
            //    {
            //        Console.Write('@');
            //    }
            //    else
            //    {
            //        Console.Write(' ');
            //    }
            //}
            //Console.WriteLine($"\n\nМашина: {car.GetCor()}");
            //for (int i = 0; i < barriers.Count; i++)
            //{
            //    Console.WriteLine($"Барьер {i}: {barriers[i].GetCor()}\n\n");
            //}
        }
    }
}
