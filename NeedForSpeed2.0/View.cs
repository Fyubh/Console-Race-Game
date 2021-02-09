using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed2._0
{
    class View
    {
        private void PrintOnPosition(uint x, uint y, char c, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition((int)x, (int)y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }
        private void PrintStringOnPosition(uint x, uint y, string str, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition((int)x, (int)y);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        public void Show(KeyValuePair<(uint X, uint Y, string Color, char Symbol), List<(uint X, uint Y, string Color, char Symbol, string Type)>> model)
        {
            Console.Clear();
            for (int i = 0; i < model.Value.Count; i++)
            {
                //if (model.Value[i].Type == "NeedForSpeed2._0.AnotherCar")
                //{
                //    PrintOnPosition(model.Value[i].X, model.Value[i].Y, model.Value[i].Symbol, ConsoleColor.Red);
                //    PrintOnPosition(model.Value[i].X + 1, model.Value[i].Y, model.Value[i].Symbol, ConsoleColor.Red);
                //}
                //else
                //{
            PrintOnPosition(model.Value[i].X, model.Value[i].Y, model.Value[i].Symbol, ConsoleColor.Red);
                //}
            }
            PrintOnPosition(model.Key.X - 2, model.Key.Y - 1, model.Key.Symbol, ConsoleColor.Green);
            PrintOnPosition(model.Key.X - 2, model.Key.Y, model.Key.Symbol, ConsoleColor.Green);

            PrintOnPosition(model.Key.X - 1, model.Key.Y, model.Key.Symbol, ConsoleColor.Green);

            PrintOnPosition(model.Key.X, model.Key.Y - 2, model.Key.Symbol, ConsoleColor.Green);
            PrintOnPosition(model.Key.X, model.Key.Y - 1, model.Key.Symbol, ConsoleColor.Green);
            PrintOnPosition(model.Key.X, model.Key.Y, model.Key.Symbol, ConsoleColor.Green);
            PrintOnPosition(model.Key.X, model.Key.Y + 1, '/', ConsoleColor.Green);

            PrintOnPosition(model.Key.X + 1, model.Key.Y - 2, model.Key.Symbol, ConsoleColor.Green);
            PrintOnPosition(model.Key.X + 1, model.Key.Y - 1, model.Key.Symbol, ConsoleColor.Green);
            PrintOnPosition(model.Key.X + 1, model.Key.Y, model.Key.Symbol, ConsoleColor.Green);
            PrintOnPosition(model.Key.X + 1, model.Key.Y + 1, '\\', ConsoleColor.Green);

            PrintOnPosition(model.Key.X + 2, model.Key.Y, model.Key.Symbol, ConsoleColor.Green);

            PrintOnPosition(model.Key.X + 3, model.Key.Y - 1, model.Key.Symbol, ConsoleColor.Green);
            PrintOnPosition(model.Key.X + 3, model.Key.Y, model.Key.Symbol, ConsoleColor.Green);

            PrintStringOnPosition(Globals.Width + 6, 1, "Speed: " + Globals.Speed, ConsoleColor.White);
            PrintStringOnPosition(Globals.Width + 6, 2, "Acceleration: " + Globals.Acceleration, ConsoleColor.White);
            PrintStringOnPosition(Globals.Width + 6, 3, "Damage: " + Globals.Health, ConsoleColor.White);
            PrintStringOnPosition(Globals.Width + 6, 4, "Score: " + Globals.Score, ConsoleColor.White);
        }
    }
}

/*
{РАМКИ}
for (uint i = 0; i < Globals.Height + 2; i++)
{
    PrintOnPosition(Globals.Width + 3, i, '|', ConsoleColor.White);
}
for (uint i = 0; i < Globals.Width + 3; i++)
{
    PrintOnPosition(i, Globals.Height + 1, '_', ConsoleColor.White);
}
*/

/* 
{ВЫВОД ЧЕРЕЗ FOR}
for (int i = (int)Globals.Height; i >= 0; i--)
{
    for (int j = (int)Globals.Width; j >= 0; j--)
    {
        if (i == 0 && j == model.Key.X)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write('@');
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(' ');
            Console.BackgroundColor = ConsoleColor.Black;
        }
        for (int z = 0; z < model.Value.Count; z++)
        {
            if (model.Value[z].X == j && model.Value[z].Y == i)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write(model.Value[z].Symbol);
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
    Console.WriteLine();
}
*/