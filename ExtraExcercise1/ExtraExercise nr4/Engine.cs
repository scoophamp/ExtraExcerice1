using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercise_nr4
{
    class Engine
    {
        private string StartEngine;
        private int StopEngine;

        public string StartaEngine
        {
            get { return StartaEngine; }
            set { StartaEngine = value; }
        }

        

        public int StoppEngine
        {
            get { return StoppEngine; }
            set { StoppEngine = value; }
        }
        public void StartaMotor(string svar)
        {
            if (StartaEngine == "y")
            {
                Car starta = new Car();
                starta.StartEngine();
            }
        }

        
    }
}
