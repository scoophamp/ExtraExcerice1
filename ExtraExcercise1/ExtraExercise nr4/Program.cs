using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercise_nr4
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "";
            string kalas = "";

            Engine motor = new Engine();
            Console.WriteLine("Välkommen till bilen");
            Console.WriteLine("Välj alternativ nedan: ");
            Console.WriteLine("(y) Starta bilen");
            Console.WriteLine("(n) Avsluta");
            

            while (val != "Q")
            {
                switch (val)
                {
                    case "y":
                        motor.StartaMotor(val);
                        break;

                    case "n":
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
