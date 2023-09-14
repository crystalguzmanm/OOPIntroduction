using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaciónDeEstructuraDeClases.Class
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public string Cuatrimestre {  get; set; }

        public void DecirCuatrimestre(string Cuatrimestre)
        {
            Console.WriteLine($"Estoy cursando mi {Cuatrimestre} ahora.");
        }
    }
}
