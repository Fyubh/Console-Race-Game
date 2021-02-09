using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NeedForSpeed2._0
{
    class Controller
    {
        Model ForRun = new Model();
        View Interface = new View();

        private int Menu()
        {
            Console.SetWindowSize(25, 10);
            Console.WriteLine("[МЕНЮ]");
            Console.WriteLine("\n[1]. Играть");
            Console.WriteLine("\n[2]. Таблица рекордов");
            Console.WriteLine("\n[3]. Выйти");
            int Choose = Convert.ToInt32(Console.ReadLine());

            return Choose;
        }

        public void Run()
        {
            Record.Read("Records.xml");
            Console.SetWindowSize(210, 61);
            Art.Car();
            Console.ResetColor();

            while (true)
            {
                switch (ConsoleHelper.MultipleChoice(true, "Начать игру", "Рекорды", "Выйти"))
                {
                    case 0:
                        Console.SetWindowSize((int)Globals.Width + 25, (int)Globals.Height + 2);
                        while (true)
                        {
                            Interface.Show(ForRun.GetData());
                            Thread.Sleep((int)(Globals.Speed));
                            Globals.Speed += Globals.Acceleration;
                            Globals.Score++;
                        }
                    case 1:
                        Console.SetWindowSize((int)Globals.Width + 25, (int)Globals.Height + 2);
                        Record.Show();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
