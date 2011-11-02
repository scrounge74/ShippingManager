using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{
    [Serializable()]
    public class Package
    {
        private DateTime acceptedDate;
        private DateTime deliveryEstimate;
        private  float[] size;

        public enum SERVICE_TYPE
        {
            Economy,
            Priority,
            Express,
            NextDay
        }

        public enum WEIGHT_CLASS
        {
            _1oz_8oz,
            _9oz_1lb,
            _1lb_2lb,
            _2lb_3lb,
            _3lb_5lb,
            _5lb_8lb,
            _8lb_15lb,
            _15lb_25lb,
            _25lb_50lb,
            _50lb_greater
        }

        public Package(int weight, float[] size, int mailService, bool fragile, bool irregular, bool perishable, Address destination, Address source)
        {
            Weight = weight;
            Size = size;
            MaileService = mailService;
            Fragile = fragile;
            Irregular = irregular;
            Perishable = perishable;
            Destination = destination;
            Source = source;
        }

        public void takeSnapshot()
        {
            //TODO
        }

        private void addSnapshot(Snapshot snapshot, Route currentRoute)
        {
            //TODO
        }

        private DateTime generateETA(DateTime acceptedDate, int mailService)
        {
            //TODO
            return DateTime.Now;
        }

        private int generateTrackingNumber(Address sourceAddress, Address destination, DateTime acceptedDate)
        {
            //TODO:
            return 1;
        }

        public float Volume { get { return size[0] * size[1] * size[3]; } }

        public DateTime AcceptedDate { get { return acceptedDate; } }

        public DateTime DeliveryEstimate { get { return deliveryEstimate; } }

        public int TrackingNumber { get; set; }

        public int Weight { get; set; }

        public float[] Size { get{return size;} set{size=value;} }

        public int MaileService { get; set; }

        public bool Fragile { get; set; }

        public bool Irregular { get; set; }

        public bool Perishable { get; set; }

        public Address Destination { get; set; }

        public Address Source { get; set; }
    }
}
