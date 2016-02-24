using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercise_nr2
{
    class Personer
    {
        private string firstName;

        public string firstname
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string lastname
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string fullname;

        public string MyProperty
        {
            get { return firstname + lastName; }
            set { fullname = value; }
        }

    }
}
