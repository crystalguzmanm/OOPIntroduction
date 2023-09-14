using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaciónDeEstructuraDeClases.Class
{
    public class Maestro : Docente
    {
        public int AñosTrabajando {  get; set; }

        public void InformarAñosTrabajando(int AñosTrabajando)
        {
            Console.WriteLine($"Tengo {AñosTrabajando} aAñosTrabajando trabajando como Maestro.");
        }
    }
}
