using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{
    [Serializable()]
    public class Address
    {
        public enum STATE_OPTIONS
        {
            Alabama, Alaska, Arizona, Arkansas, California, Colorado, Connecticut, Delaware, District_Of_Columbia, Florida, Georgia, Hawaii, Idaho, Illinois, Indiana, Iowa, Kansas, Kentucky, Louisiana, Maine, Maryland, Massachusetts, Michigan, Minnesota, Mississippi, Missouri, Montana, Nebraska, Nevada, New_Hampshire, New_Jersey, New_Mexico, New_York, North_Carolina, North_Dakota, Ohio,Oklahoma, Oregon, PALAU, Pennsylvania, PUERTO_RICO, Rhode_Island, South_Carolina, South_Dakota, Tennessee, Texas, Utah, Vermont, Virginia, Washington, West_Virginia, Wisconsin, Wyoming
        }

        public Address(string addressee, string streetAddress, int zip)
        {
            Addressee = addressee;
            StreetAddress = streetAddress;
            Zip = zip;
        }

        public string Addressee { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public int State { get; set; }

        public int Zip { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
