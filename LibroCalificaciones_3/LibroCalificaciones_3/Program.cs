using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroCalificaciones_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibroCalificaciones myLibro = new LibroCalificaciones("CS101 Programacion en C#");
            LibroCalificaciones myLibro2 = new LibroCalificaciones("CS102 Estructura de Datos");

            Console.WriteLine("El nombre del curso 1 es: {0}", myLibro.NombreCurso);
            Console.WriteLine("El nombre del curso 2 es: {0}", myLibro2.NombreCurso);
            Console.WriteLine();

            Console.WriteLine("Por favor ingrese el nuevo nombre del primer curso: ");
            string nuevoNombreDelCurso = Console.ReadLine();

            long numero;

            while (nuevoNombreDelCurso == "" || long.TryParse(nuevoNombreDelCurso, out numero))
            {
                if (nuevoNombreDelCurso == "")
                {
                    Console.WriteLine("Error: El nombre del curso no puede estar vacío.");
                }
                else if (long.TryParse(nuevoNombreDelCurso, out numero))
                {
                    Console.WriteLine("Error: El nombre del curso no puede ser solo números.");
                }

                Console.WriteLine("Por favor intente nuevamente:\n");
                nuevoNombreDelCurso = Console.ReadLine();
            }

            myLibro.NombreCurso = nuevoNombreDelCurso;
            Console.WriteLine("El nombre del curso es: {0},\n", myLibro.NombreCurso);
            myLibro.MostrarMensaje();
        }
    }
}



