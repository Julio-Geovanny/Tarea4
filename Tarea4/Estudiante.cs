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

        internal class Asistencia
        {
            private const double PorcentajeMinimo = 75.0;

            public static double CalcularPorcentaje(int sesionesTotales, int sesionesAsistidas)
            {
                if (sesionesTotales == 0) return 0.0;
                return (double)sesionesAsistidas / sesionesTotales * 100;
            }

            public static bool CumpleConMinimo(int sesionesTotales, int sesionesAsistidas)
            {
                double porcentaje = CalcularPorcentaje(sesionesTotales, sesionesAsistidas);
                return porcentaje >= PorcentajeMinimo;
            }
        }

        public void MostrarInformacion()
        {
            double porcentaje = Asistencia.CalcularPorcentaje(SesionesTotales, SesionesAsistidas);
            bool cumpleConMinimo = Asistencia.CumpleConMinimo(SesionesTotales, SesionesAsistidas);

            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Sesiones Totales: {SesionesTotales}");
            Console.WriteLine($"Sesiones Asistidas: {SesionesAsistidas}");
            Console.WriteLine($"Porcentaje de Asistencia: {porcentaje:F2}%");
            Console.WriteLine($"Cumple con el mínimo de asistencia: {(cumpleConMinimo ? "Sí" : "No")}");
            Console.WriteLine();
        }
    }
}

