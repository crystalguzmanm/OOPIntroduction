using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaciónDeEstructuraDeClases.Class
{
    public class Administrador : Docente
    {
        public string Correo { get; set; }

        public static void EscribirCorreo(string Correo)
        {
            Console.WriteLine("Hola! Mi correo es " + Correo);
        }
    }
}
