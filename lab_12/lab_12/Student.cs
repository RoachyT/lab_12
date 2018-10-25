using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    class Student : Person
    {

        protected string _degreeProgram;
        protected int _year;
        protected double _fee;
        public Student(string degreeProgram, int year, double fee, string name, string address) : base(name, address)
        {
            _degreeProgram = degreeProgram;
            _year = year;
            _fee = fee;
        }

        public Student()
        {
        }

        public string DegreeProgram
        {
            get{ return this._degreeProgram; }
            set{ this._degreeProgram = value; }

        }

        public int Year
        {
            get { return this._year; }
            set { this._year = value; }
        }

        public double Fee
        {
            get { return this._fee; }
            set { this._fee = value; }

        }


        public override string ToString()
        {
            return $"Name: {_name}\nAddress: {_address}\nProgram: {_degreeProgram}" +
                $"\nYear: {_year}\nFee: ${_fee}";
        }
    }
        
}
