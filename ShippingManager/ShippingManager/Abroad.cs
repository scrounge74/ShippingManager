using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{
    [Serializable()]
    public class Abroad : Location
    {
        private int[] zipCodes;

        public Abroad(int[] zipCodes)
        {
        }

        public int[] ZipCodes
        {
            get
            {
                return zipCodes;
            }
            set
            {
                zipCodes = value;
            }

        }

        public bool ContainsZipCode(int zipCode)
        {
            foreach (int i in zipCodes)
                if (i == zipCode)
                    return true;

            return false;
        }
    }
}
