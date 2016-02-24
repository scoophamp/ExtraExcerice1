using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercise_nr2
{
    class Program
    {
        static void TaBortFilter()
        {
            string text = "    Hello H e l s i n g b o r g    !";
            string[] nytext = text.Split(new char[] { ' ' });

            var result = string.Empty;
            foreach (var c in nytext)
            {
                if (c != " ")
                    result += c;
            }

        }
        static void Main(string[] args)
        {
            
        }
    }
}
