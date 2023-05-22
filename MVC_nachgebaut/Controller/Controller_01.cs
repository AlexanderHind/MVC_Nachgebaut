using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Nachgebaut.Controller
{
    internal class Controller_01
    {
        public void Stringverarbeitung(string a)
        {
            Model.Persistenz.Speichern("***"+a+"!!!");
        }
    }
}
