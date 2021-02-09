using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NeedForSpeed2._0
{
    class Model
    {
        public (uint X, uint Y, string Color, char Symbol) car;
        public List<(uint X, uint Y, string Color, char Symbol, string Type)> barrier = new List<(uint X, uint Y, string Color, char Symbol, string Type)>();
        private Road road = new GameRoad();

        private void Read() 
        {
            barrier.Clear();
            car = (road.GetCar().GetCor().Key, road.GetCar().GetCor().Value, "White", '|');
            for (int i = 0; i < road.GetBarriers().Count; i++)
            {
                if (road.GetBarriers()[i].GetType().ToString().Equals("NeedForSpeed2._0.Bonus"))
                {
                    barrier.Add((road.GetBarriers()[i].GetCor().Key, road.GetBarriers()[i].GetCor().Value, "White", '$', "NeedForSpeed2._0.Bonus"));
                }
                else if (road.GetBarriers()[i].GetType().ToString().Equals("NeedForSpeed2._0.Fence"))
                {
                    barrier.Add((road.GetBarriers()[i].GetCor().Key, road.GetBarriers()[i].GetCor().Value, "White", '░', "NeedForSpeed2._0.Fence"));
                }
                else if (road.GetBarriers()[i].GetType().ToString().Equals("NeedForSpeed2._0.AnotherCar"))
                {
                    barrier.Add((road.GetBarriers()[i].GetCor().Key, road.GetBarriers()[i].GetCor().Value, "White", '*', "NeedForSpeed2._0.AnotherCar"));
                }
            }
        }
        public KeyValuePair<(uint X, uint Y, string Color, char Symbol), List<(uint X, uint Y, string Color, char Symbol, string Type)>> GetData()
        {

            road.AddBarrier();
            road.MoveBarrier();
            road.MoveCar();
            Read();
            switch (road.IsCollision())
            {

                case 1:
                    Console.Beep(900, 100);
                    Globals.Health++;
                    Globals.Score += 10;
                    break;
                case 2:
                    Console.Beep(400, 100);
                    Globals.Speed += 10;
                    break;
                case 3:
                    Console.Beep(300, 100);
                    if (Globals.Health == 1)
                    {
                        Art.GameOver();


                        Record.Write("Records.xml");
                        Environment.Exit(0);
                    }
                    Globals.Health--;
                    break;
                default:
                    break;
            }
            road.DeleteBarrier();
            return new KeyValuePair<(uint X, uint Y, string Color, char Symbol), List<(uint X, uint Y, string Color, char Symbol, string Type)>>(car, barrier);
        }
    }
}

            /*
             * FOR MODEL()
             * Car = (road.GetCar().GetCor().Key, road.GetCar().GetCor().Value, "White", '@');
            for (int i = 0; i < road.GetBarriers().Count; i++)
            {
                if (road.GetBarriers()[i].GetType().ToString().Equals("NeedForSpeed2._0.Bonus"))
                {
                    Barrier[i] = (road.GetBarriers()[i].GetCor().Key, road.GetBarriers()[i].GetCor().Value, "White", '$');
                }
                else if (road.GetBarriers()[i].GetType().ToString().Equals("NeedForSpeed2._0.Fence"))
                {
                    Barrier[i] = (road.GetBarriers()[i].GetCor().Key, road.GetBarriers()[i].GetCor().Value, "White", '#');
                }
                else if (road.GetBarriers()[i].GetType().ToString().Equals("NeedForSpeed2._0.AnotherCar"))
                {
                    Barrier[i] = (road.GetBarriers()[i].GetCor().Key, road.GetBarriers()[i].GetCor().Value, "White", '|');
                }
            }
            */