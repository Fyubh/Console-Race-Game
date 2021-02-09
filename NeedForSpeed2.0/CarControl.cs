using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed2._0
{
    class CarControl : Control
    {
        public override int Move()
        {
            if (Console.ReadKey().Key == ConsoleKey.RightArrow)
            {
                return 0;
            }
            else if (Console.ReadKey().Key == ConsoleKey.LeftArrow)
            {
                return 1;
            }
            return 2;
        }
    }
}
