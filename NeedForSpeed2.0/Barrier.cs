using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed2._0
{
    abstract class Barrier
    {
        private uint X;
        private uint Y;
        public abstract void Move();
        //{
        //    Y--;
        //}
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
