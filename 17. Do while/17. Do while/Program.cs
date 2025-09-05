namespace _17._Do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que genera y suma los primeros 5 numeros enteros

            /*int contador = 0;
            int acumulador = 0;

            do
            {
                contador++
                    acumulador = acumulador + contador
            } while (contador < 5);
            Console.WriteLine("La suma de los primeros cinco enteros es" + acumulador);*/

            /*algoritmo que solicite un numero y genere su tabla de multiplicar correspondiente del 1 al 10.
            Asi sucesivamente hasta que el usuario ya no desee continuar generando tablas*/

            int contador = 1;
            int numero = 0;
            string respuesta;

            do
            {
                Console.WriteLine("Ingrese un número para calcular su tabla de multiplicar");
                numero = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                    contador++;
                } while (contador <= 10);

                contador = 1;
                Console.WriteLine("Desea seguir generando tablas? s:sí  n:no");
                respuesta = Console.ReadLine().ToLower();
            } while (respuesta == "s");
        }
    }
}
