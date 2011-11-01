using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{
    public class Package
    {
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
    }
}
