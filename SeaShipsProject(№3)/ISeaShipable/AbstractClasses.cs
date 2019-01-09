using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISeaShipable
{
    public interface IShipable
    {
        void Move();
        void Stop();
        void Act(int actionId);
        string ModelName { get; set; }
    }
    public abstract class AbstractBattleShip : IShipable
    {
        protected string model;
        public abstract void Move();
        public abstract void Stop();
        public abstract void Act(int actionId);
        public abstract void Shoot();
        public abstract void Miss();
        public abstract void AddCannon();
        public abstract string ModelName { get; set; }
        protected abstract int NumberOfCannons { get; set; }
        protected abstract float CannonsCapacity { get; set; }
        protected abstract bool IsMoving { get; set; }
    }
}
