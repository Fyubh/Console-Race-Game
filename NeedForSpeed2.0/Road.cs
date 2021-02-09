using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed2._0
{
    abstract class Road
    {
        private Car car;
        private List<Barrier> barriers;

        public abstract Car GetCar();
        public abstract List<Barrier> GetBarriers();
        public abstract void AddBarrier();
        public abstract void DeleteBarrier();
        public abstract void MoveBarrier();
        public abstract void MoveCar();
        public abstract int IsCollision();
    }
}
