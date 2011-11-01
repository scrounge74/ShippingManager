using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{

    public class AcceptanceEmployee : Employee
    {
        private StoreFront storefront;

        //not sure about this
        public StoreFront CurrentStoreFront
        {
            get
            {
                return;

            }

                set
                {
                }
        }

        public AcceptanceEmployee(string firstName, string lastName, string middleName, string id, string plainTextPassword)
        {
        }

    }
}
