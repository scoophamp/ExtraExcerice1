using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercise_nr4
{
    class Engine
    {
        private string startaengine;
        private string stopengine;

        public string StartaEngine
        {
            get { return startaengine; }
            set { startaengine = value; }
        }
       




        public string StoppEngine
        {
            get { return stopengine; }
            set { stopengine = value; }
        }

        public void StartaMotor(string startmotor)
        {
                startaengine = "Motorn är startad";
                Console.ReadKey();
                
            }
        }

        
    }
}
