using System;


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

                Universidad universidad = new Universidad(capacidad);

                for (int i = 0; i < capacidad; i++)
                {
                    Console.WriteLine($"\nRegistro del estudiante {i + 1}:");

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    int sesionesTotales;
                    // Validar sesiones totales
                    while (true)
                    {
                        Console.Write("Sesiones Totales: ");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out sesionesTotales) && sesionesTotales > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Las sesiones totales no pueden ser negativas o cero. Intente nuevamente.");
                        }
                    }

                    int sesionesAsistidas;
                    // Validar sesiones asistidas
                    while (true)
                    {
                        Console.Write("Sesiones Asistidas: ");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out sesionesAsistidas))
                        {
                            if (sesionesAsistidas < 0)
                            {
                                Console.WriteLine("Las sesiones asistidas no pueden ser negativas. Intente nuevamente.");
                            }
                            else if (sesionesAsistidas > sesionesTotales)
                            {
                                Console.WriteLine("Las sesiones asistidas no pueden ser mayores que las sesiones totales. Intente nuevamente.");
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Por favor, ingrese un número válido para las sesiones asistidas.");
                        }
                    }

                    universidad.RegistrarEstudiante(nombre, sesionesTotales, sesionesAsistidas);
                }

                // Mostrar información de cada estudiante
                Console.WriteLine("\nResumen de Asistencia:");
                Console.WriteLine("\n:El porcentaje mínimo de aprobado es del 75%");
                universidad.MostrarEstudiantes();
            }
        }
    }

// URL del repositorio github: https://github.com/Julio-Geovanny/Tarea4.git
// Dirección de carpeta: C:\Users\Geovanny\sourse\repos\Tarea4
