namespace _22._Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos unidimensinales
            //vectores
            int[] numeros = new int[5];  //tipo de dato. nombre, new [rango]
            string[] nombres = new string[4];

            //almacenar datos 
            numeros[0] = 12;
            numeros[1] = 32;
            numeros[2] = 41;
            numeros[3] = 100;
            numeros[4] = 56;
            //numeros[5] = 0;  fuera del rango, no existe la posicion con indice 5

            //recuperar datos
            Console.WriteLine($"El valor almacenado en la posicion 4 con idice 3 es {numeros[3]}");

            //recorrer para almacenar
            /*for (int i = 0; i < 5; i++)   //i empieza en el primer indice, tiene que ser menor al rango
            {
                Console.WriteLine($"Ingrese el dato para la posicion {i + 1} con el indice {i}");
                numeros[i] = int.Parse(Console.ReadLine());

            }*/

            //otras formas de declarar e inicializar vectores

            char[] characters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g'};
            float[] numeros2 = { 0f, 3f, 5f, 5f, 2f, 5f, 4.5f };

            // recorrer para recuperar datos almacenados

            for (int i = 0;i < characters.Length; i++)
            {
                Console.WriteLine($"P:{i+1} - I:{i}: {characters[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < numeros2.Length; i++)
            {
                Console.Write($"{numeros2[i]} |");
            }

        }
    }
}
