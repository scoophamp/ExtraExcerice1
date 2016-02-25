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
            string _val = "";
            

            Engine motor = new Engine();
            Console.WriteLine("Välkommen till bilen");
            Console.WriteLine("Välj alternativ nedan: ");
            Console.WriteLine("(y) Starta bilen");
            Console.WriteLine("(n) Avsluta");
            _val = Console.ReadLine();

            while (_val != "Q")
                
            {
                switch (_val)
                {
                    case "y":
                        motor.StartaMotor();
                        while (_val != "Q")
                        {

                       
                        Console.WriteLine("Stanna bilen? Tryck n");
                        Console.WriteLine("Växla upp? Tryck u");
                        Console.WriteLine("Växla ner? Tryck d");
                        Gear gear = new Gear();
                        _val = Console.ReadLine();
                        switch (_val)
                        {
                            case "n":
                                motor.StoppaMotorn();
                                Console.ReadLine();
                                break;
                            case "u":
                                    gear.VäxlaUpp();
                                    Console.ReadKey();
                                break;
                            case "d":
                                    gear.VäxlaNer();
                                break;
                            default:
                                break;
                        }
                        }
                        break;
                        
                        
                
                    case "n":
                        Console.WriteLine("Välkommen åter, tryck valfri knapp för att avsluta");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
