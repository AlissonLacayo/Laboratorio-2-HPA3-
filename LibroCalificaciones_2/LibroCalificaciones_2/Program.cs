using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroCalificaciones_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiLibroCalificaciones MyLibro = new MiLibroCalificaciones();

            Console.WriteLine("Por favor ingrese el nombre del curso: ");
            string nombreDelCurso = Console.ReadLine();

            int numero;

            while(nombreDelCurso == "" || int.TryParse(nombreDelCurso, out numero))
            {
                if (nombreDelCurso == "")
                {
                    Console.WriteLine("Error: El nombre del curso no puede estar vacio.");
                }
                else if (int.TryParse(nombreDelCurso, out numero))
                {
                    Console.WriteLine("Error: El nombre del curso no puede ser solo numero.");
                }
                Console.WriteLine("Por favor intente nuevamente.\n");
                nombreDelCurso = Console.ReadLine() ;
            }

            Console.WriteLine();
            MyLibro.MostrarMensaje(nombreDelCurso);
        }
    }
}