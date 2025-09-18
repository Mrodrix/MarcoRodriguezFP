namespace _23._ejercicio_vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*23.Crear arreglo llamado "numeros" de 100 elementos asignar el número 10 en 
            cada una de las posiciones del arreglo. Leer el contenido de cada elemento y escribirlo en pantalla.*/

            int[] numeros = new int[100];

            
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 10;
            }

            
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Numero " + numeros[i]);
            }
        }
    }
}
