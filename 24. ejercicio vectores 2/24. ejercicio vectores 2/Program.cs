namespace _24._ejercicio_vectores_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Algoritmo que permita solicitar 10 números, los cuales serán almacenados en un arreglo,
            al final, debe visualizar el promedio de esos números.*/

            int[] numeros = new int[10];
            double suma = 0;
            double promedio = 0;

            
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
                suma += numeros[i]; 
            }

            
            promedio = suma / numeros.Length;

            
            Console.WriteLine("El promedio de los números ingresados es: " + promedio);
        }
    }
}
