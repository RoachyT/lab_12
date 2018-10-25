using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    class Staff : Person
    {
        protected string _school;
        protected double _pay;
        public Staff(string school, double pay, string name, string address) : base(name, address)
        {
            _pay = pay;
            _school = school;
        }
        public Staff()
        {
        }

        public string School
        {
            get { return this._school; }
            set { this._school = value; }
        }   

        public double Pay
        {
            get { return this._pay; }
            set { this._pay = value; }
        }
            
         public override string ToString()
        {
            return $"Name: {_name}\nAddress: {_address}\nSchool: ${_school}\nPay: ${_pay}";
        }
    }
}
