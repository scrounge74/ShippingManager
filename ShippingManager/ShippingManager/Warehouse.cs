using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{
    public class Warehouse : Location
    {
        private List<int> zipCodesServed;
        private List<Transport> transports;
        private List<DeliveryVehicle> deliveryVehicles;

        public Warehouse(int volumeCapacity, int[] zipCodesServed, Transport[] transports, DeliveryVehicle[] deliveryVehicles)
        {
            VolumeCapacity = volumeCapacity;

            this.zipCodesServed = new List<int>();
            this.transports = new List<Transport>();
            this.deliveryVehicles = new List<DeliveryVehicle>();

            this.zipCodesServed.AddRange(zipCodesServed);
            this.transports.AddRange(transports);
            this.deliveryVehicles.AddRange(deliveryVehicles);
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

        public bool addTransport(Transport transport)
        {
            if (transports.Contains(transport))
                return false;
            transports.Add(transport);
            return true;
        }

        public void removeTransport(Transport transport)
        {
            transports.Remove(transport);
        }

        public int VolumeCapacity { get; set; }
    }
}
