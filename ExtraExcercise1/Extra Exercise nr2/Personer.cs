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
        private string lastName;
        private string fullname;

        public string firstname
        {
            get { return firstName; }
            set { firstName = value; }
        }
        

        public string lastname
        {
            get { return lastName; }
            set { lastName = value; }
        }
        

        public string Fullname
        {
            get { return firstname + lastName; }
            set { fullname = value; }
        }
        
        
    }
}
