using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaciónDeEstructuraDeClases.Class
{
    public class ExAlumno : MiembroDeLaComunidad
    {
        public DateTime FechaDeGraduacion { get; set; }

        public static void RegistrarGraduacion(DateTime FechaDeGraduacion)
        {
            Console.WriteLine(FechaDeGraduacion.ToString());
        }
    }
}
