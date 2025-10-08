using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Parcial_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Gestión de Ventas Semanales
            Desarrolla un programa que permita registrar y analizar las ventas de computadores en una red 
            de cinco almacenes durante los siete días de una semana.Para ello, 
            se utilizará una matriz bidimensional Ventas[5][7], 
            donde cada fila representa un almacén y cada columna un día de la semana(de lunes a domingo).
            
            Requisitos del programa:
            -Ingreso de datos con validación:
            -Permitir al usuario ingresar las ventas diarias de cada almacén(valores enteros no negativos).
            -Validar que los datos ingresados sean numéricos y mayores o iguales a cero.Si el usuario ingresa un
            valor inválido, solicitar el dato nuevamente.
            *Visualización de la matriz:
            Mostrar por pantalla la matriz de ventas en forma tabular.
            *Cálculos estadísticos:
            -Calcular y mostrar el promedio semanal de ventas por cada almacén(promedio por fila).
            -Calcular y mostrar el promedio de ventas por día, específicamente para:
            Lunes(columna 0)
            Viernes(columna 4)
            -Mostrar el valor mínimo y máximo de ventas registrados en toda la matriz, 
            e indicar en qué almacén y qué día ocurrieron.
            Calcular los siguientes datos:
            -Determinar cuál fue el almacén con mayor promedio de ventas durante la semana.
            -Determinar cuál fue el día de la semana con mayores ventas totales entre todos los almacenes.*/

            int almacenes = 5;
            int diasSemana = 7;
            int[,] ventas = new int[almacenes, diasSemana];
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            int i, j;
            int valor;

            // Ingresar datos
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine($"Almacén {i + 1}:");
                for (j = 0; j < 7; j++)
                {
                    do
                    {
                        Console.Write($"Ventas de {dias[j]}: ");
                        valor = int.Parse(Console.ReadLine());
                        if (valor < 0) Console.WriteLine("  Error: las ventas no pueden ser negativas.");

                    } while (valor < 0);

                    ventas[i, j] = valor;
                }
            }

            // Mostrar matriz
            Console.WriteLine("\nMATRIZ DE VENTAS");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    Console.Write(ventas[i, j] + " | ");
                }
                Console.WriteLine();
            }

            // Promedio
            Console.WriteLine("\nPROMEDIO SEMANAL POR ALMACÉN");

            double mayorProm = 0;
            int mejorAlmacen = 0; 

            for (i = 0; i < 5; i++)
            {
                double suma = 0;
                for (j = 0; j < 7; j++)
                {
                    suma += ventas[i, j];
                }
                double prom = suma / 7;
                Console.WriteLine($"Almacén {i + 1} = {prom}");
                if (prom > mayorProm)
                {
                    mayorProm = prom; mejorAlmacen = i; 
                }
            }

            // Promedio de lunes y viernes
            double sumaLunes = 0;
            double sumaViernes = 0;

            for (i = 0; i < 5; i++)
            {
                sumaLunes += ventas[i, 0];
                sumaViernes += ventas[i, 4];
            }

            Console.WriteLine($"\nPromedio Lunes: {sumaLunes / 5}");
            Console.WriteLine($"Promedio Viernes: {sumaViernes / 5}");

            // Mínimo y Máximo 
            int min = ventas[0, 0];
            int max = ventas[0, 0];
            int almMin = 0;
            int diaMin = 0;
            int almMax = 0;
            int diaMax = 0;

            for (i = 0; i < 5; i++)
                for (j = 0; j < 7; j++)
                {
                    if (ventas[i, j] < min) { min = ventas[i, j]; almMin = i; diaMin = j; }
                    if (ventas[i, j] > max) { max = ventas[i, j]; almMax = i; diaMax = j; }
                }

            Console.WriteLine($"\nMínimo: {min} (Almacén {almMin + 1}, {dias[diaMin]})");
            Console.WriteLine($"Máximo: {max} (Almacén {almMax + 1}, {dias[diaMax]})");

            // Día con la mayor venta
            int diaMayor = 0;
            int totalMayor = 0;

            for (j = 0; j < 7; j++)
            {
                int sumaDia = 0;
                for (i = 0; i < 5; i++)
                {
                    sumaDia += ventas[i, j];
                } 

                if (sumaDia > totalMayor)
                {
                    totalMayor = sumaDia;
                    diaMayor = j; 
                }
            }

            Console.WriteLine($"\nAlmacén con mayor promedio: {mejorAlmacen + 1} ({mayorProm})");
            Console.WriteLine($"Día con mayores ventas totales: {dias[diaMayor]} ({totalMayor})");
        }
    }
}
