namespace _12._ejercicio_impares_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*12. Realizar algoritmo que permita obtener la suma de todos los números impares hasta el 99. */
            
            int numero = 1;
            int contador = 0;

            while (numero <= 99)
            {
                contador = contador + numero;
                numero = numero + 2; 
            }

            Console.WriteLine("La suma de los números impares hasta 99 es: " + contador);
        }
    }
}
