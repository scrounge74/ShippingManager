using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{

    public class AcceptanceEmployee : Employee
    {
        public StoreFront CurrentStoreFront
        {
            get;
            set;
        }

        public AcceptanceEmployee(string firstName, string middleName, string lastName, string id, string plainTextPassword)
            : base(firstName, middleName, lastName, id, plainTextPassword)
        {
        }

    }
}
