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
        

        public int VäxlaNer
        {
            get { return gearDown; }
            set { gearDown = value; }
        }


    }
}
