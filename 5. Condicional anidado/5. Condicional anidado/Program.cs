namespace _5._Condicional_anidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONDICIONAL ANIDADO
            /*Diseñar un algoritmo que lea tres numeros A, B, C y visualice en pantalla el valor más grande.
            El usuario debe ingresar tres valores diferentes
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese el número 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 3");
            num3 = Int32.Parse(Console.ReadLine());

            if (num1>num2)
            {
                if (num1>num3)
                {
                    Console.WriteLine($"Numero 1: {num1} es el mayor");
                }
                else
                {
                    Console.WriteLine($"Numero 3: {num3} es el mayor");
                }
            }
            else
            {
                if (num2>num3)
                {
                    Console.WriteLine($"Numero 2: {num2} es el mayor");
                }
                else
                {
                    Console.WriteLine($"Numero 3: {num3} es el mayor");
                }
            }

        /*Si el promedio se ubica en los siguientes rangos,
        escribir los correspondientes mensajes.
        Considerar la situación en donde el promedio generado no esté contemplado
        en los rangos establecidos, mostrar mensaje de error. 
        9.5-10.0 Excelente
        8.5-9.4 Muy bien 
        7.5-8.4 Bien*/

            double promedio;

            Console.Write("Ingrese el promedio: ");
            promedio = Convert.ToDouble(Console.ReadLine());

            if (promedio >= 7.5)
            {
                if (promedio <= 8.4)
                {
                    Console.WriteLine("Bien");
                }
                else
                {
                    if (promedio <= 9.4)
                    {
                        Console.WriteLine("Muy bien");
                    }
                    else
                    {
                        if (promedio <= 10.0)
                        {
                            Console.WriteLine("Excelente");
                        }
                        else
                        {
                            Console.WriteLine("Error: promedio fuera de rango.");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Error: promedio fuera de rango.");
            }
        }
    }


}
    

