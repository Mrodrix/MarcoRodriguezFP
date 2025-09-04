namespace _16._ejercicio_while_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un algoritmo en el que el ordenador elija un número aleatorio entre 1 y 100. El usuario
             debe adivinar el número y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. Usa un ciclo while
            para seguir pidiendole intentos hasta que el usuario adivine el número*/

            Random random = new Random();
            int numeroSecreto = random.Next(1, 101); 
            int intento = 0;

            Console.WriteLine("Adivina el número (entre 1 y 100):");

            while (intento != numeroSecreto)
            {
                Console.Write("Ingresa un número: ");
                intento = int.Parse(Console.ReadLine());

                if (intento > numeroSecreto)
                {
                    Console.WriteLine("Demasiado alto. Intenta de nuevo.");
                }
                if (intento < numeroSecreto)
                {
                    Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
                }
                if(intento == numeroSecreto)
                {
                    Console.WriteLine("¡Correcto! El número era " + numeroSecreto);
                }

            }
        }
    }
}

