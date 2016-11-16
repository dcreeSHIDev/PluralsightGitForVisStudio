using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ein Änder nummer eins nach Repo machen. 
            //Ein mal Änder vor schieben. 
            if (args != null)
            {
                Console.WriteLine("Die zuerst args ist: {0}", args[0].ToString());
            }
            else
            {
                Console.WriteLine("Du hast kein args.");
            }
        }

        //es ist nicht Regen...
        //es ist etwas anderes


    }
}
