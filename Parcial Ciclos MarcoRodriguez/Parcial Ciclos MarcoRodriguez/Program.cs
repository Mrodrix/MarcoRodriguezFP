namespace Parcial_Ciclos_MarcoRodriguez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se requiere diseñar un programa que permita a un profesor calcular la nota definitiva de cada uno
            de los 25 estudiantes del curso de Ética, con el fin de identificar si aprobaron o reprobaron
            la asignatura.
            Las condiciones del problema son las siguientes:
            Cada estudiante presenta dos exámenes y un trabajo de investigación en el primer período académico.
            Las calificaciones se encuentran en un rango de 0.0 a 5.0.
            Para aprobar la asignatura, el estudiante debe obtener un promedio mayor o igual a 3.5.
            El programa debe realizar los siguientes pasos para cada estudiante:
            * Solicitar por teclado las tres calificaciones (dos exámenes y un trabajo de investigación).
            * Calcular el promedio de las tres notas.
            * Mostrar en pantalla un mensaje indicando si el estudiante aprobó o reprobó la asignatura.*/

            double examen1 = 0;
            double examen2 = 0;
            double trabajoInv = 0;
            double promedio = 0;

            for (int i = 1; i<=25; i++)
            {
                
                Console.WriteLine("Ingrese la nota del primer examen (0,0 - 5,0)");
                examen1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la nota del segundo examen (0,0 - 5,0)");
                examen2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la nota del trabajo de investigación (0,0 - 5,0)");
                trabajoInv = double.Parse(Console.ReadLine());

                promedio = (examen1 + examen2 + trabajoInv) / 3;

                Console.WriteLine($"El promedio del estudiante es {promedio}");

                if (promedio >= 3.5)
                {
                    Console.WriteLine("El estudiante aprobó el curso de ética");
                }
                else
                {
                    Console.WriteLine("El estudiante NO aprobó del curso de ética");
                }
            }
        }
    }
}
