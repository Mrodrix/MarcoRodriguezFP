using System.Linq.Expressions;

namespace _25._arreglos_bidimensionales__matrices_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos bidimensionales - Matrices
            int[,] numeros = new int[2,2];  //primero filas, segundo columnas 2x2 [2,2]
            // rango = FxC = 2x2 = 4
            bool[,] banderas = new bool[2, 5];
            object[,] objetos = new object[2, 5];

            //Asignacion de valores
            numeros[0, 0] = 15;
            numeros[0, 1] = 25;
            numeros[1, 0] = 32;
            numeros[1, 1] = 4;
            //numeros[1, 2] = 7;  indice fuera del rango

            //Recuperar datos almacenados en una posición
            Console.WriteLine($"Valor almacenado en la posición con índices 1,0: {numeros[1, 0]}");

            //declaración e inicialización de matrices con valores por defecto
            string[,] apellidos =
                {
                    {"Chica", "López", "Alvarez"},
                    {"Patiño", "Ciro", "Botero" },
                    {"Duque", "Carmona", "Castaño"},
                };

            //Recorrer matrices
            string[,] nombres = new string[3, 2];

            for(int i =0; i<3, i++) //recorrer las filas
            {
                for (int j = 0; j < 2; j++) //recorrer las columnas
                {
                    Console.WriteLine($"Digite el nombre para almacenarlo en la posicion con indices {i}, {j}");
                    nombres[i, j] = Console.ReadLine();
                }
            }


            //recorrer para recuperar los datos
            for(int i = 0; i < nombres.GetLength(0); i++)
            {
                for (int j = 0; j < nombres.GetLength(1); j++)
                {
                    Console.WriteLine($"Nombre almacenado en la posicion {i}, {j}: {nombres[i, j]}");
                }
            }
            Console.WriteLine();


            char[,] caracteres = new char [2, 4];
        }
    }
}
