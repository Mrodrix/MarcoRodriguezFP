namespace _28._Programacion_modular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensajes("Soy Marco");
            MostrarMensajes("Tengo 17 años");
            MostrarMensajes($"Tengo {CalcularEdad()} años");
            MostrarMensajes($"Tengo {CalcularEdad(2025, 2007)}");
        }
        //Modulo 1 - procedimiento sin parámetros
        static void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido a la programación modular");
            MostrarMensajes("Estoy siendo llamado desde MostrarMensajes()");
        }

        //Modulo 2 - procedimiento con parámetros
        static void MostrarMensajes(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //Modulo 3 - Función sin parametros

        static int CalcularEdad()
        {
            int edad = 2025 - 2007;
            return edad;
        }

        //Modulo 4 - Función con parámetros
        static int CalcularEdad(int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }

    }
}
