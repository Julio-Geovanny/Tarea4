using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    public class Universidad
    {
        private Estudiante[] estudiantes;
        private int contadorEstudiantes;

        // Constructor :)
        public Universidad(int capacidad)
        {
            estudiantes = new Estudiante[capacidad];
            contadorEstudiantes = 0;
        }

        public void RegistrarEstudiante(string nombre, int sesionesTotales, int sesionesAsistidas)
        {
            if (contadorEstudiantes < estudiantes.Length)
            {
                estudiantes[contadorEstudiantes] = new Estudiante(nombre, sesionesTotales, sesionesAsistidas);
                contadorEstudiantes++;
            }
            else
            {
                Console.WriteLine("No se pueden registrar más estudiantes.");
            }
        }

        public void MostrarEstudiantes()
        {
            for (int i = 0; i < contadorEstudiantes; i++)
            {
                estudiantes[i].MostrarInformacion();
            }
        }
    }
}