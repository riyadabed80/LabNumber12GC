using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber12GC
{
    class Student:Person
    {
        #region DataMembers
        private string program;
        private int year;
        private double fee;
        #endregion

        #region Properties
        public string Program
        {
            set { program = value; }
            get { return program; }
        }
        public int Year
        {
            set { year = value; }
            get { return year; }
        }
        public double Fee
        {
            set { fee = value; }
            get { return fee; }
        }



        #endregion

        #region Constructors
        public Student()
        {

        }
        public Student(string n, string a, string p, int y, double f):base(n,a)
        {
            Program = p;
            Year = y;
            Fee = f;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"\nName:  {Name}\nAddress:  {Address}\nProgram:  {Program}\nYear:  {Year}\nFee:  {Fee}";
        }
        #endregion
    }
}
