namespace _21._Ciclo_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;

            for (int i = 1; i <= 5; i++)
            {
                acumulador += i;
            }
            Console.WriteLine($"la suma de los cinco primeros números enteros es {acumulador}");
        }
    }
}
