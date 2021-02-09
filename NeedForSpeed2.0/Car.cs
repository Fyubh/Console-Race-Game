using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed2._0
{
    abstract class Car
    {
        private uint X;
        private uint Y;
        //public abstract Car();
        //{
        //    X = (uint)Console.WindowWidth / 2;
        //    Y = 1;
        //}
        public abstract void MoveLeft();    /* { X--; }*/
        public abstract void MoveRight();   /* { X++; }*/
        public abstract KeyValuePair<uint, uint> GetCor();
        //{
        //    if (tmp.GetHashCode().Equals(this.GetHashCode()))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
