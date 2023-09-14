using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaciónDeEstructuraDeClases.Class
{
    public class Docente : Empleado
    {
        public string Asignatura {  get; set; }

        public void EscribirAsignatura(string Asignatura)
        {
            Console.WriteLine(Asignatura);
        }
    }
}
