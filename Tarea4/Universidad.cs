﻿using System;
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

    }
}
