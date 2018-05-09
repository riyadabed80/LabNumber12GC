using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber12GC
{
    class Staff:Person
    {
        #region DataMembers
        private string school;
        private double pay;
        #endregion

        #region Properties
        public string School
        {
            set { school = value; }
            get { return school; }
        }
        public double Pay
        {
            set { pay = value; }
            get { return pay; }
        }
        #endregion

        #region Constructors
        public Staff()
        {

        }
        public Staff(string n, string a, string s, double p):base(n,a)
        {
            School = s;
            Pay = p;
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"\nName:  {Name}  \nAddress:  {Address}  \nSchool:  {School}  \nPay:  {Pay}";
        }


        #endregion

    }
}
