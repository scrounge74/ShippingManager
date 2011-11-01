using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShippingManager
{
    public abstract class Employee
    {
        protected string firstName;
        protected string lastName;
        protected string middleName;
        protected string id;
        protected string passwordHash;

        public string FirstName
        {
            get
            {
                return "";
            }
            set
            {
            }
        }

        public string LastName
        {
            get
            {
                return "";
            }
            set
            {
            }
        }

        public string MiddleName
        {
            get
            {
                return "";
            }
            set
            {
            }
        }

        public string Name
        {
            get
            {
                return "";
            }
            set
            {
            }
        }

        public char MiddleInitial
        {
            get
            {
                return;
            }
            set
            {
            }
        }

        public string Id
        {
            get
            {
                return "";
            }
            set
            {
            }
        }

        public bool IdMatch (string id)
        {
            get
            {
                return;
            }
            set
            {
            }
        }

        public string PasswordHash
        {
            get
            {
                return "";
            }
            set
            {
            }
        }

        public bool PasswordMatch(string plainTextPassword)
        {
            get
            {
                return "";
            }
            set
            {
            }
        }

        protected string hashPassword(string plainTextPassword)
        {
            get
            {
                return "";
            }
            set
            {
            }
        }

    }
}
