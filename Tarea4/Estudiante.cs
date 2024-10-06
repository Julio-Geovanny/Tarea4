using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    public class Estudiante
    {
        public string Nombre { get; private set; }
        public int SesionesTotales { get; private set; }
        public int SesionesAsistidas { get; private set; }

        // Constructor :)
        public Estudiante(string nombre, int sesionesTotales, int sesionesAsistidas)
        {
            Nombre = nombre;
            SesionesTotales = sesionesTotales;
            SesionesAsistidas = sesionesAsistidas;
        }

    }
}
