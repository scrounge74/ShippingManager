using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{
    [Serializable()]
    public class ShippingSystem
    {

        private List<Package> packages;
        private List<Warehouse> warehouses;
        private List<StoreFront> storeFronts;
        private List<Employee> employees;
        private List<Moveable> moveables;
        public string hey;

    }
}
