namespace _15._ejercicio_while_37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, si al final de cada mes deposita cantidades variables de dinero
             además, se quiere saber cuánto lleva ahorrado cada vez*/
            double depósito;
            double total=0;
            int mes = 1;

            while (mes <= 12)
            {
                Console.WriteLine($"Ingrese la cantidad que depositará el mes {mes}");
                depósito=double.Parse(Console.ReadLine());
                total = total + depósito;
                Console.WriteLine($"El ahorro total en el mes {mes} es {total}");
                mes++;
            }
            Console.WriteLine($"El ahorro total en todo el año es {total}");
        }
    }
}
