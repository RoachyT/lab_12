using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    class Person
    {
        protected string _name;
        protected string _address;

        public Person(string name, string address)
        {
            _name = name;
            _address = address;
        }

        public Person() 
        {
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }

        }

        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        public override string ToString()
        {
            return $"Name: {_name}|\nAddress: {_address}";
        }
    }
}
