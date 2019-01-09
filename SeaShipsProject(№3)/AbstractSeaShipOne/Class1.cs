using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISeaShipable; 

namespace AbstractSeaShipOne
{
    public abstract class AbstractBattleShip: IShipable
    {
        public abstract void Move();
        public abstract void Stop();
        public abstract void Shoot();
        public abstract void Miss();
        public abstract void AddCannons();
        public abstract void IsMoving();
        protected abstract string ModelName { get; set; }
        protected abstract int NumberOfCannons { get; set; }
        protected abstract float CargoCapacity { get; set; }
        protected abstract int CrewMembers { get; set; }
    }
}
