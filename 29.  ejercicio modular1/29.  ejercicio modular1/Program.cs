﻿namespace _29.__ejercicio_modular1
{
    internal class Program
    {
           /* Crear una matriz de n filas por m columnas, que permita ingresar solamente 
           múltiplos de 5 hasta que se llene la matriz.*/
        static void Main(string[] args)
        {
            int[,] multiplosDe5 = new int[CapturarFilas(), CapturarColumnas()];
        }
        static int CapturarFilas()
        {
            Console.WriteLine("Ingrese el número de filas para la matriz:");
            int filas = int.Parse(Console.ReadLine());
            return filas;
        }

        static int CapturarColumnas()
        {
            Console.WriteLine("Ingrese el número de columnas para la matriz:");
            int columnas = int.Parse(Console.ReadLine());
            return columnas;
        }

        static int[,] LlenasMatriz(int[,] matriz)
        {
            return matriz;
        }

    }
}
