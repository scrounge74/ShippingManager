using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{
    [Serializable()]
    public class DeliveryVehicle : Moveable
    {
        private bool assignedToDriver;

        public DeliveryVehicle(int volumeCapacity, int weightCapacity, Route route)
            : base(volumeCapacity,weightCapacity,route)
        {
        }

        public bool AssignedToDriver { get { return assignedToDriver; } }
    }
}
