using System;

namespace ShippingManager
{
    [Serializable()]
    public abstract class Location
    {
        private Address locationAddress;

        public Address LocationAddress
        {
            get { return locationAddress; }
            set { locationAddress= value; }
        }
    }
}
