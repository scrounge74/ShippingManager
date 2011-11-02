using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{
    [Serializable()]
    public abstract class Moveable
    {
        private List<Package> packages;
        private int currentWeight, currentVolume;
        private Location currentLocation;

        public Moveable(int volumeCapacity, int weightCapacity, Route route)
        {
            packages = new List<Package>();

            VolumeCapacity = volumeCapacity;
            WeightCapacity = weightCapacity;
            CurrentRoute = route;
        }

        public bool addPackage(Package package)
        {
            if (packages.Contains(package))
                return false;
            if (VolumeAvailable < package.Volume || WeightAvailable < package.Weight)
                return false;
            packages.Add(package);
            currentWeight += package.Weight;
            currentVolume += (int)package.Volume;
            return true;
        }

        public void removePackage(Package package)
        {
            if (packages.Contains(package))
            {
                packages.Remove(package);
                currentWeight -= package.Weight;
                currentVolume -= (int)package.Volume;
            }
        }

        public int VolumeAvailable { get { return VolumeCapacity - currentVolume; } }
        public int WeightAvailable { get { return WeightCapacity - currentWeight; } }

        public int VolumeCapacity { get; set; }

        public int WeightCapacity { get; set; }

        public Route CurrentRoute { get; set; }

        public Location CurrentLocation { get { return currentLocation; } }

        public bool Full { get { return (currentWeight > WeightCapacity || currentVolume > VolumeCapacity); } }
    }
}
