namespace _26._ejercicio_matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*26.Escribe un programa que realice la suma de dos matrices de dimensiones 2x3.
            Requisitos del programa:
            Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas.
            Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones(2x3).
            Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices.
            Muestra la matriz resultante de la suma en formato de matriz(2 filas, 3 columnas).*/

            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] suma = new int[2, 3];
            int i, j;

            Console.WriteLine("Ingrese los elementos de la primera matriz (2x3):");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Elemento [{0},{1}]: ", i, j);
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nIngrese los elementos de la segunda matriz (2x3):");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Elemento [{0},{1}]: ", i, j);
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    suma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            
            Console.WriteLine("La matriz suma es:");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine(suma[i, j]);
                }
            }
        }
    }
}
