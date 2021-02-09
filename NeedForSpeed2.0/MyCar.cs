using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed2._0
{
    class MyCar : Car
    {
        private uint X = Globals.Width / 2;
        private uint Y = Globals.Height - 1;
        public override void MoveLeft() { X--; }
        public override void MoveRight() { X++; }
        public override KeyValuePair<uint, uint> GetCor()
        {
            return new KeyValuePair<uint, uint>(X, Y);
        }
    }
}
