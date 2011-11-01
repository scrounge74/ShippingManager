using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{
    public class Transport
    {
        public enum TRANPORT_TYPES
        {
            air,
            truck,
            train
        }

        private int transportType;
        private int weightCapacity;
        private int volumeCapacity;
        private bool tempControlled;
        private Route[] routes;
        private Location[] currentLocation;

        public Transport(int transportType, int weightCapacity, int volumeCapacity, bool tempControlled, Route[] routes)
        {

            transportType = TransportType;
            weightCapacity = WeightCapacity;
            volumeCapacity = VolumeCapacity;
            tempControlled = TempControlled;
            //not sure if routes one is correct 
            routes = CurrentRoute;
            Location[] location = CurrentLocation;

        }


        public int TransportType
        {
            get
            {
                return 1;
            }
            set
            {
            }
        }



        public int WeightCapacity
        {
            get
            {
                return 1;
            } 
            set
            {
            }
        }


        public int VolumeCapacity 
        {
            get
            {
                return 1;
            }
            set
            {
            }
        }

        public bool TempControlled 
        {
            get
            {
                
            }
            set
            {
            }
        }

        public Route[] CurrentRoute 
        {
            get
            {
                return;
            }
            set
            {
            }
        }

        public Location[] CurrentLocation
        {
            get
            {
                return;
            }
            set
            {
            }
        }
    }
}

