using Microsoft.VisualBasic;

namespace _19._ejercicio_do_while_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*19. En un grupo de 100 alumnos, se desea saber cuántos de los estudiantes son hombres y cuántos son mujeres,
            además se desea saber cuántos son mayores de edad y cuántos no.  */

            int cantidadEstudiantes = 0;
            int edad = 0;
            int genero = 0;
            int cantidadHombres = 0;
            int CantidadMujeres = 0;
            int cantidadmayores = 0;
            int cantidadmenores = 0;
            

            do
            {
                Console.WriteLine($"Estudiante {cantidadEstudiantes}:");
                Console.WriteLine("Ingrese su edad");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su genero: 1.Hombre 2.Mujer");
                genero = int.Parse(Console.ReadLine());

                if (genero == 1)
                {
                    cantidadHombres++;
                }
                else
                {
                    CantidadMujeres++;
                }
                if (edad >= 18)
                {
                    cantidadmayores++;
                }
                else
                {
                    cantidadmenores++;
                }
                cantidadEstudiantes++;
            } while (cantidadEstudiantes <= 100);

            Console.WriteLine($"De los 100 estudiantes, {cantidadHombres} son hombres, {CantidadMujeres} son mujeres, {cantidadmenores} son menores y {cantidadmayores} son mayores");
        }
    }
}
