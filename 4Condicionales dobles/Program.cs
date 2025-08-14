using System.Net;
using System.Numerics;

namespace _3._1Condicionales_dobles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona,
            si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona,
            indicando que debe abonar impuestos. De lo contrario mostrar el mensaje “Persona exenta de impuestos”. 



            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el sueldo");
            sueldo = Int32.Parse(Console.ReadLine());

            if (sueldo >= 3000)
            {
                //verdadera
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else
            {
                //Falsa
                Console.WriteLine($"La persona {nombre}, no abona impuestos");*/

            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18,
            se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”. De lo contrario,
            mostrar el mensaje “No es apto para el contenido de este sitio web”.  
                      
            int edad = 0;

            Console.WriteLine("Ingrese Su Edad");

            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {

                Console.WriteLine("Bienvenido a mi sitio web");

            }
            else
            {
                Console.WriteLine("No es apto para este sitio web");
            }*/


            /*Crear un algoritmo que permita ingresar dos números, si el primer número es mayor al segundo número informar su suma y diferencia,
            en caso contrario informar el producto y la división del primer número respecto al segundo número. 

            int num1 = 0;
            int num2 = 0;
           


            Console.WriteLine("Ingrese el primer número");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            num2 = Int32.Parse(Console.ReadLine());

            if (num1>num2)
            {
                Console.WriteLine($"La suma es {num1+num2} y la resta es {num1-num2}");
            }
            else
            {
                Console.WriteLine($"El producto es {num1*num2} y la división es {num1/num2}");
            }

            Un cliente se hospeda varias noches en una hostería, el precio por noche es de 200 dólares.
            Si el usuario se queda más de 3 noches se le aplica un porcentaje de descuento del 17 % 
            y si no se aplica un porcentaje de descuento del 2 %.
            Mostrar un mensaje con el monto total que debe pagar el cliente,
            sabiendo que el usuario indica cuántas noches se va a quedar en la hostería.*/

            int noches = 0;
            double precioNoche = 200;
            double descuento = 0;

            Console.WriteLine("Ingrese el número de noches");

            noches = Int32.Parse(Console.ReadLine());

            if (noches>3)
            {
                descuento = 0.17;
            }

            else
            {
                descuento = 0.02;
            }

            double total = (precioNoche * noches) * (1 - descuento);

            Console.WriteLine($"El total a pagar es {total}");

        }
    }
    
}
