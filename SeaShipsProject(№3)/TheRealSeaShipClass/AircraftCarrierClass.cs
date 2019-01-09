using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISeaShipable;

namespace TheRealSeaShipClass
{
    public class AircraftCarrier: AbstractBattleShip
    {

        protected override bool IsMoving { get; set; }
        public override void Move()
        {
            if (!IsMoving)
            {
                Console.WriteLine("Your ship is moving now. Yay!");
                IsMoving = true;
            }
            else
            {
                Console.WriteLine("Your ship is already moving. Try something else!");
            }
        }
        public override void Miss()
        {
            Console.WriteLine("You fired from your cannons and \n missed. Welp, whatever you want.");
        }
        public override void Shoot()
        {
            if(NumberOfCannons!=0)
            Console.WriteLine("Ship " +ModelName.ToString()+" destroyed this poor raft. That'll teach'em!");
            else
                Console.WriteLine("Ship " + ModelName.ToString() + " has no cannons to fire from");
        }

        public override void Stop()
        {
            if (IsMoving)
            {
                Console.WriteLine("Ship " + ModelName.ToString() + " has stopped !");
                IsMoving = true;
            }
            else
            {
                Console.WriteLine("Ship " + ModelName.ToString() +"has already stopped. Try something else!");
            }
        }
        public void Fire()
        {
            Random rnd = new Random();
            if (rnd.Next(1, 2) == 2)
            {
                Shoot();
            }
            else
            {
                Miss();
            }
        }

        public override void Act(int actionId)
        {
            switch (actionId)
            {
                case 1: Fire(); break;
                case 2: AddCannon();break;
            }
        }
        public AircraftCarrier(string name, int capacity)
        {
            model = name;
            IsMoving = false;
            NumberOfCannons = 0;
            CannonsCapacity = capacity;
        }
        public AircraftCarrier()
        {
            model = "";
            IsMoving = false;
            NumberOfCannons = 0;
            CannonsCapacity = 0;
        }

        public override void AddCannon()
        {
            if(NumberOfCannons<CannonsCapacity)
                NumberOfCannons++;
            Console.WriteLine("Cannon added to the ship " + ModelName.ToString()+". Now there is " + NumberOfCannons.ToString()+" cannons on the ship.");
        }

        protected override int NumberOfCannons
        {
            get;set;
        }

        public override string ModelName
        {
            get
            {
                return model;
            }
            set
            {

            }
        }

        protected override float CannonsCapacity
        {
            get;set;
        }
    }
}
