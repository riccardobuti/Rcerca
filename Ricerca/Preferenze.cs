using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricerca
{
    class Preferenze
    {
        public static string pathDb { get; set; }
        public static string pathSalvataggio { get; set; }
        public static int IdElemento { get; set; }


        public static void LoadPath()
        {
            pathSalvataggio = File.ReadAllText(Environment.CurrentDirectory + "\\settings\\pathSalvataggio.txt");
            pathDb = File.ReadAllText(Environment.CurrentDirectory + "\\settings\\pathDb.txt");

        }

    }

 
}
