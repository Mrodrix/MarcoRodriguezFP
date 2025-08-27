using System;
using System.Text.RegularExpressions;

namespace Parcial_Condicionales_MarcoRodriguez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sexo = ' ';
            int edad = 0;
            int UltimoDigito = 0;
            char inglés = ' ';
            

            Console.WriteLine("Ingrese su sexo. m:masculino  f:femenino");
            sexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el último dígito de su tarjeta de identidad (0-9)");
            UltimoDigito = Convert.ToInt32((Console.ReadLine()));          
           
            if (edad == 15)
            {
                Console.WriteLine("¿Domina el inglés? s: sí  n: no");
                inglés = Convert.ToChar(Console.ReadLine());
            }

            string grupo =
                (edad == 15 && inglés == 's') ? "C" :
                (sexo == 'f' && edad >= 16 && edad <= 20 && (UltimoDigito == 0 || UltimoDigito == 4 || UltimoDigito == 8)) ? "A" :
                (sexo == 'f' && edad >= 21 && edad <= 25 && (UltimoDigito == 3 || UltimoDigito == 7)) ? "B" :
                (sexo == 'm' && edad >= 18 && edad <= 22 && (UltimoDigito == 1 || UltimoDigito == 5 || UltimoDigito == 9)) ? "A" :
                (sexo == 'm' && edad >= 23 && edad <= 26 && (UltimoDigito == 2 || UltimoDigito == 6)) ? "B" :
                "D";

            Console.WriteLine($"La persona pertenece al grupo: {grupo}");
        }
    }
}
    

