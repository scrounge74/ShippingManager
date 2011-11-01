using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{
    public class Route
    {
        private Location[] locations;
        private float durationInDays;

        public Route (Location[] locations, float durationInDays)
        {
            
            durationInDays = DurationInDays;
         }
    


        public float DurationInDays 
        { 
            get
            {
                return 1;
            }
            
            set
            {
            }
        }
    }
}
