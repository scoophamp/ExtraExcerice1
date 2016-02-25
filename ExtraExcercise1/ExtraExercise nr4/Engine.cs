using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercise_nr4
{
    class Engine
    {
        private string _startaengine;
        private string _stopengine;

        public string StartaEngine
        {
            get { return _startaengine; }
            set { _startaengine = value; }
        }
      
        public string StoppEngine
        {
            get { return _stopengine; }
            set { _stopengine = value; }
        }

        public void StartaMotor()
        {
                _startaengine = "Motorn är startad";
            Console.WriteLine(_startaengine);
                
            }
        public void StoppaMotorn()
        {
            _stopengine = "Motorn är stoppad";
            Console.WriteLine(_stopengine);
        }
        

        
    }
}

