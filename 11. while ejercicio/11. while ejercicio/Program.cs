namespace _11._while_ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*11. Realizar un algoritmo que pida números enteros positivos y los sume,
             hasta que se ingrese un número entero negativo.
             Se debe mostrar por pantalla el total de la suma de los números ingresados. */

            int numero;
            int contador = 0;

            Console.WriteLine("Ingrese números enteros positivos. Para salir, ingrese un número negativo.");

            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero >= 0)
            {
                contador= contador+numero;

                Console.WriteLine($"el numero es {contador}");
                Console.Write("Ingrese otro número: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("La suma total de los números positivos ingresados es: " + contador);
        }
    }
}
