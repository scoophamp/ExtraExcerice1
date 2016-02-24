using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercise_nr4
{
    class Gear
    {
        private int gearUp;
        private int gearDown;

        public int Växlaupp
        {
            get { return gearUp; }
            set { gearUp = value; }
        }
        

        public int Växlaner
        {
            get { return gearDown; }
            set { gearDown = value; }
        }
        public void VäxlaUpp()
        {
            int upp = 1;
            
            upp++;
            
            Console.WriteLine("Växlen är nu: "+upp);
        }
        public void VäxlaNer()
        {
            int ner = 0;
            for (int i = 5; i >=2; i--)
            {
                i--;
            }
            Console.WriteLine("Växlen är nu: "+ner);
        }

    }
}
