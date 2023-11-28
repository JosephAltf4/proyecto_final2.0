using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final2._0
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido a la Calculadora de Calificaciones :D");
            Console.Write("Ingrese la calificación: ");
            double calificacion = Convert.ToDouble(Console.ReadLine());
            OfrecerConsejosYRecursos(calificacion);
            Console.ReadLine();
        }
        static void OfrecerConsejosYRecursos(double calificacion)
        {
            Console.WriteLine("Consejos y Recursos Educativos:");
            if (calificacion >= 7.0)
            {
                Console.WriteLine("¡Felicidades! Su rendimiento académico es excelente.");
                Console.WriteLine("Recursos adicionales sugeridos: Talleres de ampliación de conocimientos, participación en proyectos de investigación.");
            }
            else if (calificacion >= 5.0 && calificacion < 7.0)
            {
                Console.WriteLine("Puede mejorar. Considere dedicar más tiempo al estudio, no se desanime :D.");
                Console.WriteLine("Recursos adicionales sugeridos: Tutorías, grupos de estudio con compañeros y podría guiarse con videos de enseñanza en YouTube, algunos canales de matemáticas que son muy útiles son ProfeAlex y JulioProfe.");
            }
            else
            {
                Console.WriteLine("Necesita esforzarse más. Busque ayuda adicional si es necesario, ¡usted puede con eso y más!.");
                Console.WriteLine("Recursos adicionales sugeridos: Clases de apoyo, revisión de conceptos básicos, apoyo con maestros especializados en las materias que flaquea.");
            }

            switch ((int)calificacion)
            {
                case 10:
                    Console.WriteLine("Felicidades por la calificación perfecta.¡Sigue así!");
                    break;
                case 6:
                    Console.WriteLine("Puedes mejorar un poco más para alcanzar un rendimiento más sólido, tú puedes.");
                    break;
                case 4:
                    Console.WriteLine("Es importante dedicar tiempo a reforzar los conceptos básicos en los que fallas, tu puedes, apoyate con asesorías.");
                    break;
                default:
                    Console.WriteLine("¡Sigue esforzándote, cada esfuerzo cuenta para tu mejora, no te rindas jamás!");
                    break;
            }
        }
    }
}