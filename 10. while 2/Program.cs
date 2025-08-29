namespace _10._while_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita calcular la factorial de un numero dado por el usuario

            int numero = 0;
            int acumulador = 1;
            int contador = 1;

            Console.WriteLine("Ingrese un número");
            numero = Convert.ToInt32(Console.ReadLine());

            while (contador <= numero)
            {
                acumulador = acumulador * contador;
                Console.WriteLine($"Contador: {contador} - Factorial: {acumulador}");
                contador++;
            }


            Console.WriteLine($"El factorial de {numero} es {acumulador}");
        }
    }
}
