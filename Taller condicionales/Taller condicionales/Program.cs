using System.Diagnostics;

namespace Taller_condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
            numero2, numero3 respectivamente.El algoritmo debe comprobar si los números son
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            pantalla los números de menor a mayor.
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            ingresar números diferentes*/

            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;
            int mayor = 0;
            int medio = 0;
            int menor = 0;

            Console.WriteLine("Escriba el número 1");
            numero1=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el número 2");
            numero2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el número 3");
            numero3 = Int32.Parse(Console.ReadLine());

            if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3)
            {
                mayor = numero1 > numero2
                ? (numero1 > numero3 ? numero1 : numero3)
                : (numero2 > numero3 ? numero2 : numero3);

                medio = numero1 > numero2
                ? (numero1 < numero3 ? numero1 : numero2 > numero3 ? numero2 : numero3)
                : (numero1 > numero3 ? numero1 : numero3 > numero2 ? numero2 : numero3);

                menor = numero1 < numero2
                ? (numero1 < numero3 ? numero1 : numero3 < numero2 ? numero3 : numero2)
                : (numero2 < numero3 ? numero2 : numero1 > numero3 ? numero3 : numero2);

                Console.WriteLine($"El numero mayor es {mayor}, el orden de menor a mayor es {menor}, {medio}, {mayor}");
                    
            }
            else
            {
                Console.WriteLine("Ingrese números diferentes entre sí");
            }
        }
    }
}
