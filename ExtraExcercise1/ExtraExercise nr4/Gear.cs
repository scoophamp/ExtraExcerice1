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
            
            if (_gearUp<5)
            {
                _gearUp += 1;
                Console.WriteLine("Gear is on: "+_gearUp);
            } 
            else
            {
                Console.WriteLine("Gear is already 5!");
            } 
        }
        public void VäxlaNer()
        {
            if (_gearDown > 5)
            {
                _gearDown -= 1;
                Console.WriteLine("Gear is on: " + _gearDown);
            }
            else
            {
                Console.WriteLine("Gear is already 0!");
            }

        }

    }
}
