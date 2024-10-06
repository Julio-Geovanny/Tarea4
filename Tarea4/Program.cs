﻿using System;

namespace Tarea4
    {
        class Program
        {
            public static void Main(string[] args)
            {
                int capacidad;

                // Validar la capacidad máxima de estudiantes
                while (true)
                {
                    Console.Write("Ingrese la capacidad máxima de estudiantes (1-50): ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out capacidad))
                    {
                        if (capacidad <= 0)
                        {
                            Console.WriteLine("La capacidad no puede ser negativa o cero. Intente nuevamente.");
                        }
                        else if (capacidad > 50)
                        {
                            Console.WriteLine("La cantidad máxima por salón no puede ser mayor a 50. Intente nuevamente.");
                        }
                        else
                        {
                            break; // Salir del bucle si la entrada es válida
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese un número válido.");
                    }
                }

            }
        }
    }

    // Dirección de carpeta: C:\Users\Geovanny\sourse\repos\Tarea4
}