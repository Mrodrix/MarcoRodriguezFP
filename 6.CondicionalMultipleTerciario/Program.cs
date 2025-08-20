using System.Security.Cryptography;
using System.Text;

namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el 
            día de la semana, para saber:
            Si el día es martes o jueves, se realizará un descuento del 15 % por la compra. 
            Si el día es lunes o miércoles, se realizará un descuento del 10 % por la compra.
            Si el día es viernes o sábado, se realizará un descuento del 20 % por la compra.
            Si es domingo no se realiza descuento.
            Visualizar el día, el descuento y el total a pagar por la compra. 

            float valorCompra = 0;
            float descuento = 0;
            char dia= ' ';

            Console.WriteLine("Ingrese el valor de la compra:");
            valorCompra=Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dia de la semana: l:lunes, m:martes, x:miércoles, j:jueves, v:viernes, s:sábado, d:domingo");
            dia = Convert.ToChar(Console.ReadLine());

            switch (dia)
            {
                case 'l':
                    descuento = valorCompra*0.1f;
                    Console.WriteLine($"Hoy es lunes, descuento: {descuento}, valor a pagar: {valorCompra-descuento}");
                    break;
                case 'm':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es martes, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 'X':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es miércoles, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 'j':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es jueves, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 'v':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es viernes, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 's':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es sábado, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                case 'd':
                    descuento = valorCompra * 0;
                    Console.WriteLine($"Hoy es domingo, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;
                default:
                    Console.WriteLine($"Debe ingresar un valor válido. te crees muy gracioso? hijo de tu puta madre");
                    break;

            Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas
            entre dos números ingresados por el usuario.Las operaciones disponibles serán: suma, resta, 
            multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario.*/

            float num1 = 0f;
            float num2 = 0f;
            char operación = ' ';
            float resultado = 0f;

            Console.WriteLine("Ingresa el primer número para ser operado");
            num1 = Single.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número para ser operado");
            num2 = Single.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la operación que desea hacer, s: suma, r: resta, m: multiplicación, d: división");
            operación = Convert.ToChar(Console.ReadLine());

            switch (operación)
            {
                case 's':
                    resultado = num1 + num2;
                    Console.WriteLine($"{num1} sumado {num2} es igual a {resultado}");
                    break;
                case 'r':
                    resultado = num1 - num2;
                    Console.WriteLine($"{num1} restado {num2} es igual a {resultado}");
                    break;
                case 'm':
                    resultado = num1 * num2;
                    Console.WriteLine($"{num1} mmultiplicado {num2} es igual a {resultado}");
                    break;
                case 'd':
                    resultado = num1 / num2;
                    Console.WriteLine($"{num1} dividido {num2} es igual a {resultado}");
                    break;
                default:
                    Console.WriteLine($"Error");
                    break;

            }
        }

    }
}
