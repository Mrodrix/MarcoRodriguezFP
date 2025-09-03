namespace _13._ejercicio_while__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un algoritmo que cuente cuántos numeros pares hay en un rago de números del 1 al número n*/
           

            int contador = 1;
            int cantidadPares = 0;
            int rango = 0;

            Console.WriteLine("Ingrese el rango de numeros a evaluar");
            rango = int.Parse(Console.ReadLine());

            while (contador <= rango)
            {
                if (contador % 2 == 0)
                {
                    cantidadPares++;
                }
                contador++;
            }
            Console.WriteLine($"La cantidad de números pares entre 1 y {rango} es {cantidadPares}");
        }
    }
}
