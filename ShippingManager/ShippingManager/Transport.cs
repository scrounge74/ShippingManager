using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{
    public class Transport : Moveable
    {
        public enum TRANPORT_TYPES
        {
            air,
            truck,
            train
        }

        public Transport(int transportType, int weightCapacity, int volumeCapacity, bool tempControlled, Route route)
            : base(volumeCapacity,weightCapacity,route)
        {
            TransportType = transportType;
            TempControlled = tempControlled;
        }


        public int TransportType { get; set; }

        public bool TempControlled { get; set; }
    }
}

