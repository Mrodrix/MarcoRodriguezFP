namespace _30.__ejercicio_modular_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                BorrarPantalla();
                MostrarMenu();
                opcion = CapturarOpcion();
                RealizarOperaciones(opcion);
            }
            while (opcion != 5);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("=== MENÚ DE OPERACIONES ===");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.WriteLine("===========================");
        }

        static int CapturarOpcion()
        {
            int opcion;
            Console.Write("Ingrese una opción: ");
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
            {
                Console.Write("Opción inválida. Intente nuevamente: ");
            }
            return opcion;
        }

        static void BorrarPantalla()
        {
            Console.Clear();
        }

        static void RealizarOperaciones(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    Resta();
                    break;
                case 3:
                    Multiplicacion();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    break;
            }

            if (opcion != 5)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        }

        static void Suma()
        {
            Console.Write("¿Cuántos números desea sumar? ");
            int cantidad = int.Parse(Console.ReadLine());
            double suma = 0;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                suma += double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"El resultado de la suma es: {suma}");
        }

        static void Resta()
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado de la resta es: {num1 - num2}");
        }

        static void Multiplicacion()
        {
            Console.Write("¿Cuántos números desea multiplicar? ");
            int cantidad = int.Parse(Console.ReadLine());
            double producto = 1;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                producto *= double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"El resultado de la multiplicación es: {producto}");
        }

        static void Division()
        {
            Console.Write("Ingrese el dividendo: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el divisor: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num2 != 0)
                Console.WriteLine($"El resultado de la división es: {num1 / num2}");
            else
                Console.WriteLine("Error: no se puede dividir entre cero.");
        }
    }
}