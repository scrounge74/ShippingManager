using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{
    public class AdminEmployee : Employee
    {
        public AdminEmployee(string firstName, string middleName, string lastName, string id, string plainTextPassword)
            : base(firstName, middleName, lastName, id, plainTextPassword)
        {
        }
    }
}
