using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{
    [Serializable()]
    public class Route
    {
        private Location[] locations;

        public Route (Location[] locations, float durationInDays)
        {
            this.locations = locations;
            DurationInDays = durationInDays;
        }

        public float DurationInDays { get; set; }
    }
}
