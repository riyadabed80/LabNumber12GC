using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber12GC
{
    class Person
    {
        #region DataMembers
        private string name;
        private string address;
        #endregion

        #region Properties
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Address
        {
            set { address = value; }
            get { return address; }
        }
        #endregion

        #region Constructors
        public Person()
        {

        }
        public Person(string n, string a)
        {
            Name = n;
            Address = a;

        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"\nName:  {Name} \nAddress:  {Address}";
        }
        #endregion

    }


}