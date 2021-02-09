using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed2._0
{
    class AnotherCar : Barrier
    {
        private uint X;
        private uint Y;
        public AnotherCar()
        {
            Random rnd = new Random();
            X = (uint)rnd.Next(0, (int)Globals.Width - 1);
            Y = 0;
        }
        public override void Move() { Y++; }
        public override KeyValuePair<uint, uint> GetCor()
        {
            return new KeyValuePair<uint, uint>(X, Y);
        }
    }
}
