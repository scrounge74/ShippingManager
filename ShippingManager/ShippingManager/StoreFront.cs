using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{
    [Serializable()]
    public class StoreFront : Location
    {
        private List<Package> packages;
        private List<DeliveryVehicle> deliveryVehicles;

        public StoreFront(string id, Address locationAddress, DeliveryVehicle[] deliveryVehicles)
        {
            Id = id;
            LocationAddress = locationAddress;
            
            packages = new List<Package>();
            this.deliveryVehicles = new List<DeliveryVehicle>();
            this.deliveryVehicles.AddRange(deliveryVehicles);
        }

        public void addPackage(Package package)
        {
            packages.Add(package);
        }

        public void removePackage(Package package)
        {
            packages.Remove(package);
        }

        public bool addDeliveryVehicle(DeliveryVehicle deliveryVehicle)
        {
            if (deliveryVehicles.Contains(deliveryVehicle))
                return false;

            deliveryVehicles.Add(deliveryVehicle);
            return true;
        }

        public void removeDeliveryVehicle(DeliveryVehicle deliveryVehicle)
        {
            deliveryVehicles.Remove(deliveryVehicle);
        }

        public string Id { get; set; }

    }
}
