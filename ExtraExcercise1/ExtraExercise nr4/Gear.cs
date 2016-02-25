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
        public Gear()//konstruktor tom
        {
            
        }
        public Gear(int gearup)// konstruktor med int inparameter
        {
            this.gearUp = gearup;
        }
        public int VäxlaUpp()
        {
            
            if (gearUp<=5)
            {
                gearUp += 1;
                return gearUp;
            }
            return 0;
            
        }
        public int VäxlaNer()
        {
            if (gearDown >= 4)
            {
                gearDown -= 1;
                return gearDown;
            }
            return 0;
           

        }

    }
}
