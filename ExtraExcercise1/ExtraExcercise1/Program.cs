using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraExcercise1


{
    static class Program
    {


        public static int ArrayCounter(string[] namn)//
        {
            int antal = 0;
            for (int i = 0; i < namn.Length; i++)
            {
                if (namn[i] == "Hello")
                {
                    antal++;
                }
            }
            return antal;

        }
        static void Main(string[] args)
        {
            string[] namn = new string[4] { "Hello", "Hello", "Hi", "Hello" };
            //string[]namn; Dessa två gröna rader är samma som raden ovan
            //namn = new string[4] { "Hello", "Hello", "Hi", "Hello" };

            //This is Johans Comment Line
            Console.WriteLine("Hello from Johan");
            Console.WriteLine(ArrayCounter(namn));
        }
    }


    }

