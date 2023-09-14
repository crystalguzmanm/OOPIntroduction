using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaciónDeEstructuraDeClases.Class
{
    public class Empleado : MiembroDeLaComunidad
    {
        public string Puesto { get; set; }

        public static void DecirPuesto(string Puesto)
        {
            Console.WriteLine($"Mi puesto es {Puesto}.");
        }
    }
}
