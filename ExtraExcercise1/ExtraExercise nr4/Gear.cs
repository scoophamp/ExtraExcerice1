using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercise_nr4
{
    class Gear
    {
        private int _gearUp;
        private int _gearDown;

        public int Växlaupp
        {
            get { return _gearUp; }
            set { _gearUp = value; }
        }
        

        public int Växlaner
        {
            get { return _gearDown; }
            set { _gearDown = value; }
        }
        public Gear()//konstruktor tom
        {
            
        }
        public Gear(int gearup)// konstruktor med int inparameter
        {
            this._gearUp = gearup;
        }
        public void VäxlaUpp()
        {
            
        }
        public void VäxlaNer()
        {
            
        }

    }
}
