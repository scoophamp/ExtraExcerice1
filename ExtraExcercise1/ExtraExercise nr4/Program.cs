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
            

            Engine motor = new Engine();
            Console.WriteLine("Välkommen till bilen");
            Console.WriteLine("Välj alternativ nedan: ");
            Console.WriteLine("(y) Starta bilen");
            Console.WriteLine("(n) Avsluta");
            val = Console.ReadLine();

            while (val != "Q")
                
            {
                switch (val)
                {
                    case "y":
                        motor.StartaMotor();
                        while (val != "Q")
                        {

                       
                        Console.WriteLine("Stanna bilen? Tryck n");
                        Console.WriteLine("Växla upp? Tryck u");
                        Console.WriteLine("Växla ner? Tryck d");
                        val = Console.ReadLine();
                        switch (val)
                        {
                            case "n":
                                motor.StoppaMotorn();
                                Console.ReadLine();
                                break;
                            case "u":
                                break;
                            case "d":
                                break;
                            default:
                                break;
                        }
                        }
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
