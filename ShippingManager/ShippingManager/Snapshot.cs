using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{

    public class Snapshot
    {
        private Route route;
        private DateTime date;
        private string message;

        public Snapshot(Route route)
        {
        }

        public Snapshot(string message)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
