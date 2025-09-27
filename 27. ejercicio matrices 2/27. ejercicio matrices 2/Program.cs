using System.Runtime.ConstrainedExecution;

namespace _27._ejercicio_matrices_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7.Desarrolla una aplicación que realice las siguientes tareas:
            Solicita al usuario que ingrese las dimensiones de una matriz(número de filas y columnas). 
            Recorre la matriz y permite al usuario ingresar un número entero en cada posición. 
            Una vez cargada la matriz, el programa debe contar cuántos de los números ingresados son positivos, cuántos son
            negativos y cuántos son ceros.
            Finalmente, muestra por pantalla los totales obtenidos para cada categoría(positivos, negativos y ceros).*/
            int filas, columnas;
            int positivos = 0, negativos = 0, ceros = 0;
            int i, j;

            Console.Write("Ingrese el número de filas de la matriz: ");
            filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas de la matriz: ");
            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            Console.WriteLine("\nIngrese los elementos de la matriz:");
            for (i = 0; i < filas; i++)
            {
                for (j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Elemento [{0},{1}]: ", i, j);
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (matriz[i, j] > 0)
                    {
                        positivos++;
                    }
                    else if (matriz[i, j] < 0)
                    {
                        negativos++;
                    }
                    else
                    {
                        ceros++;
                    }
                }
            }

            Console.WriteLine("Resultados:");
            Console.WriteLine("Cantidad de números positivos: " + positivos);
            Console.WriteLine("Cantidad de números negativos: " + negativos);
            Console.WriteLine("Cantidad de ceros: " + ceros);
        }
    }
}
