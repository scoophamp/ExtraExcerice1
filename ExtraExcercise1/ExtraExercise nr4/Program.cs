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
            Engine motor = new Engine();
            Console.WriteLine("Vill du starta motorn? y/n");
            var svar = Console.ReadLine();
            motor.StartaMotor(svar);

        }
    }
}
