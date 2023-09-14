using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaciónDeEstructuraDeClases.Class
{
    public class Administrativo : Empleado
    {
        public string EstadoDeEmpleo {  get; set; }

        public static void ContarEstadoActual(string EstadoDeEmpleo)
        {
            Console.WriteLine(EstadoDeEmpleo);
        }
    }
}
