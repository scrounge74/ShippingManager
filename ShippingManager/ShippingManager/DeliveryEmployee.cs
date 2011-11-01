using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{
    public class DeliveryEmployee : Employee
    {
        private DeliveryVehicle deliveryvehicle;

        public DeliveryVehicle CurrentDeliveryVehicle
        {
        }

         public DeliveryEmployee(string firstName, string lastName, string middleName, string id, string plainTextPassword)
        {
        }
    }
}
