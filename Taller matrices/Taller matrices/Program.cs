using System;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Taller_matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
            pantalla la suma de los elementos de cada columna.

            int filas = 10;
            int columnas = 20;
            int suma = 0;
            int[,] matriz = new int[filas, columnas];
            Random rnd = new Random();


            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = rnd.Next(1, 10);
                }
            }

            
            Console.WriteLine("Matriz generada:\n");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSuma de cada columna:");
            
            for (int j = 0; j < columnas; j++)
            {
                for (int i = 0; i < filas; i++)
                {
                    suma += matriz[i, j];
                }
                Console.WriteLine($"Columna {j + 1}: {suma}");

            }*/

            /*2.Desarrollar un programa que crea una matriz de n filas* m columnas, el usuario ingresa
            caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la
            primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la
            matriz con el intercambio de filas.

            int n, m;
            int i, j;

            Console.WriteLine("Ingrese el número de filas: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas: ");
            m = int.Parse(Console.ReadLine());

            char[,] matriz = new char[n, m];

            
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.WriteLine("Ingrese el caracter para la posición [" + i + "," + j + "]: ");
                    matriz[i, j] = char.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz Original:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("| " + matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (j = 0; j < m; j++)
            {
                char temp = matriz[0, j];
                matriz[0, j] = matriz[n - 1, j];
                matriz[n - 1, j] = temp;
            }

            Console.WriteLine("Matriz con primera y última fila intercambiadas:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("| " + matriz[i, j] + " ");
                }
            }
            */


            /* 3. Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de
             5x5 llena de números aleatorios.
             El algoritmo debe permitir:
              Usa la función Random para generar los números aleatorios.
              Crea un arreglo adicional para almacenar la frecuencia de cada número.
              Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número

            int filas = 5;
            int columnas = 5;
            int[,] matriz = new int[filas, columnas];
            int[] frecuencia = new int[10]; 

            Random rnd = new Random();
            int i, j;

            
            for (i = 0; i < filas; i++)
            {
                for (j = 0; j < columnas; j++)
                {
                    int numero = rnd.Next(1, 11); 
                    matriz[i, j] = numero;
                    frecuencia[numero - 1]++; 
                }
            }

            
            Console.WriteLine("Matriz generada:");
            for (i = 0; i < filas; i++)
            {
                for (j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nFrecuencia de números del 1 al 10:");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Número " + (i + 1) + ": " + frecuencia[i]);
            }
            */

            /* 4. Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en
             posiciones aleatorias.Luego, el algoritmo le debe permitir al usuario intentar adivinar la
             posición de una "X".
             El algoritmo debe permitir:
              Usar la función Random para colocar las "X" en la matriz.
              Realizar 3 intentos para ingresar coordenadas y verificar si ha acertado.
              Al final sacar un mensaje de éxito o error.Si el mensaje es de éxito mostrar la
             posición de la X en la matriz.Si el mensaje es de error, mostrar la matriz. 

            int filas = 5;
            int columnas = 5;
            char[,] tablero = new char[filas, columnas];
            Random rnd = new Random();

            int colocadas = 0;
            while (colocadas < 3)
            {
                int f = rnd.Next(0, filas);
                int c = rnd.Next(0, columnas);

                if (tablero[f, c] != 'X') 
                {
                    tablero[f, c] = 'X';
                    colocadas++;
                }
            }

            bool acierto = false;

            
            for (int intento = 1; intento <= 3; intento++)
            {
                Console.WriteLine("\nIntento " + intento + ":");
                Console.Write("Ingrese fila (0-4): ");
                int fila = int.Parse(Console.ReadLine());

                Console.Write("Ingrese columna (0-4): ");
                int col = int.Parse(Console.ReadLine());

                if (tablero[fila, col] == 'X')
                {
                    acierto = true;
                    Console.WriteLine("\n¡Felicidades! Encontraste una 'X' en [" + fila + "," + col + "]");
                    break;
                }
                else
                {
                    Console.WriteLine("No hay 'X' en esa posición.");
                }
            }

            
            if (acierto)
            {
                Console.WriteLine("\nPosiciones de las 'X' en el tablero:");
            }
            else
            {
                Console.WriteLine("\nNo encontraste ninguna 'X'. Aquí está el tablero completo:");
            }

            
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (tablero[i, j] == 'X')
                        Console.Write("X ");
                    else
                        Console.Write("- "); 
                }
                Console.WriteLine();
            }*/


            /* Desarrollar un programa e C# que:
              Le pida al usuario ingresar por teclado el número de filas y columnas de una matriz
             de enteros
              Cargue los datos de la matriz ingresándolos por teclado
              Muestre la matriz ingresada
              Luego convierta cada fila de la matriz en una columna, es decir la fila 1 pasaría a ser
             ahora la columna 1.
              Mostrar la nueva matriz

            int filas, columnas;

            Console.Write("Ingrese el número de filas: ");
            filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];
            int[,] transpuesta = new int[columnas, filas];

            int i, j;

            
            for (i = 0; i < filas; i++)
            {
                for (j = 0; j < columnas; j++)
                {
                    Console.Write("Ingrese el valor para [" + i + "," + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            
            Console.WriteLine("\nMatriz Original:");
            for (i = 0; i < filas; i++)
            {
                for (j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            
            for (i = 0; i < filas; i++)
            {
                for (j = 0; j < columnas; j++)
                {
                    transpuesta[j, i] = matriz[i, j];
                }
            }

            
            Console.WriteLine("\nMatriz Transpuesta:");
            for (i = 0; i < columnas; i++)
            {
                for (j = 0; j < filas; j++)
                {
                    Console.Write(transpuesta[i, j] + " ");
                }
                Console.WriteLine();
            }*/

            /* Crear una aplicación en C# que permita realizar las siguientes acciones:
              Crear una matriz de n filas por m columnas
              Llenar la matriz con números aleatorios del 1 al 3(investigar la función random en C#)
              Mostrar la matriz generada
              Mostrar por pantalla cuantas veces fue ingresado el número 1, el número 2, y el
             número 3, y cuál de los tres números fue repetido más veces.*/

            int filas, columnas;

            Console.Write("Ingrese el número de filas: ");
            filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];
            Random rnd = new Random();

            int i, j;
            int contador1 = 0, contador2 = 0, contador3 = 0;

            
            for (i = 0; i < filas; i++)
            {
                for (j = 0; j < columnas; j++)
                {
                    matriz[i, j] = rnd.Next(1, 4); 

                    if (matriz[i, j] == 1)
                        contador1++;
                    else if (matriz[i, j] == 2)
                        contador2++;
                    else
                        contador3++;
                }
            }

            
            Console.WriteLine("\nMatriz generada:");
            for (i = 0; i < filas; i++)
            {
                for (j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            
            Console.WriteLine("\nCantidad de veces:");
            Console.WriteLine("Número 1: " + contador1);
            Console.WriteLine("Número 2: " + contador2);
            Console.WriteLine("Número 3: " + contador3);

            
            if (contador1 > contador2 && contador1 > contador3)
                Console.WriteLine("\nEl número más repetido fue el 1");
            else if (contador2 > contador1 && contador2 > contador3)
                Console.WriteLine("\nEl número más repetido fue el 2");
            else if (contador3 > contador1 && contador3 > contador2)
                Console.WriteLine("\nEl número más repetido fue el 3");
            else
                Console.WriteLine("\nHubo un empate en la cantidad de repeticiones");

        }
    }
}

