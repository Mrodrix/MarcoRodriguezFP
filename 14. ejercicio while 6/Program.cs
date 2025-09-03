namespace _14._ejercicio_while_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde 
             ingresar la cantidad de números que va a introducir. EL algoritmo debe escribir en pantalla 
            1. la cantidad de numeros introducidos que son mayores que 0.
            2. La cantidad de numeros introducidos menores que 0. 
            3. La cantidad de numeros iguales a 0*/

            int contador;
            int numero;
            int MayorCero = 0;
            int MenorCero = 0;
            int IgualCero = 0;

            Console.WriteLine("¿Cuántos números va a ingresar?");
            contador = int.Parse(Console.ReadLine());

            while (contador > 0)
            {
                Console.WriteLine("Ingrese un número entero");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    MenorCero++;
                }
                if (numero > 0)
                {
                    MayorCero++;
                }
                if(numero == 0)
                {
                    IgualCero++;
                }
                contador--;
            }
            Console.WriteLine($"La cantidad de números menores a 0 es {MenorCero}, mayores a 0 es {MayorCero} e iguales a 0 es {IgualCero}");
        }
    }
}
