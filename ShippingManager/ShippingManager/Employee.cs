using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace ShippingManager
{
    public abstract class Employee
    {
        protected string firstName;
        protected string lastName;
        protected string middleName;
        protected string id;
        protected string passwordHash;
        protected readonly MD5CryptoServiceProvider hashFunction;

        protected Employee(string firstName, string middleName, string lastName, string id, string plainTextPassword)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Id = id;

            hashFunction = new System.Security.Cryptography.MD5CryptoServiceProvider();
            passwordHash = hashPassword(plainTextPassword);
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string MiddleName
        {
            get;
            set;
        }

        public string Name
        {
            get
            {
                return FirstName + " " + MiddleName + " " + LastName;
            }
        }

        public char MiddleInitial
        {
            get
            {
                return MiddleName.Substring(0, 1).ToCharArray()[0];
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public bool IdMatch (string id)
        {
            return id.Equals(this.id);
        }

        public string PasswordHash
        {
            get
            {
                return passwordHash;
            }

        }

        public bool PasswordMatch(string plainTextPassword)
        {
            return hashPassword(plainTextPassword).Equals(passwordHash);
        }

        protected string hashPassword(string plainTextPassword)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(plainTextPassword);
            data = hashFunction.ComputeHash(data);
            return System.Text.Encoding.ASCII.GetString(data);
        }

    }
}
