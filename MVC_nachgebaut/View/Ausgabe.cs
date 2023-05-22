using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Nachgebaut.View
{
    internal class Ausgabe
    {
        public void Ausgeben() 
        {
            Console.WriteLine(Model.Persistenz.Lesen());
        }
    }
}
