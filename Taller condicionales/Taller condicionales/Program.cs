using System;
using System.Diagnostics;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Taller_condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
            numero2, numero3 respectivamente.El algoritmo debe comprobar si los números son
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            pantalla los números de menor a mayor.
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            ingresar números diferentes

            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;
            int mayor = 0;
            int medio = 0;
            int menor = 0;

            Console.WriteLine("Escriba el número 1");
            numero1=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el número 2");
            numero2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el número 3");
            numero3 = Int32.Parse(Console.ReadLine());

            if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3)
            {
                mayor = numero1 > numero2
                ? (numero1 > numero3 ? numero1 : numero3)
                : (numero2 > numero3 ? numero2 : numero3);

                medio = numero1 > numero2
                ? (numero1 < numero3 ? numero1 : numero2 > numero3 ? numero2 : numero3)
                : (numero1 > numero3 ? numero1 : numero3 > numero2 ? numero2 : numero3);

                menor = numero1 < numero2
                ? (numero1 < numero3 ? numero1 : numero3 < numero2 ? numero3 : numero2)
                : (numero2 < numero3 ? numero2 : numero1 > numero3 ? numero3 : numero2);

                Console.WriteLine($"El numero mayor es {mayor}, el orden de menor a mayor es {menor}, {medio}, {mayor}");
                    
            }
            else
            {
                Console.WriteLine("Ingrese números diferentes entre sí");
            }*/

            /* El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si
             cuenta con munición y si se encuentra en estado invencible, crear un programa que:
             a.Permita ingresar por teclado si el personaje está en estado invencible(True).
             b.La cantidad de munición que tiene el personaje en el momento será calculada por el
             sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#.
             Ejemplo:
             int numero;
             Random rnd = new Random();
             numero = rnd.Next(1, 6);//Devuelve un número entre 0 y 5
             Console.WriteLine(numero);
             c.Si el estado del personaje es invencible(true) y su cantidad de munición está entre 1 y
             10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario
             no hacer nada.

            int munición = 0;
            bool invencible;

            Console.WriteLine("¿El personaje está en modo Invencible? True / False");
            invencible= Convert.ToBoolean(Console.ReadLine());

            Random rnd = new Random();
            munición = rnd.Next(1, 11);
            Console.WriteLine("Cantidad de munición:" + munición);

            if(invencible==true && munición >=1 && munición <= 10)
            {
                Console.WriteLine("El personaje está disparando");
            }*/

            /*El personaje de un juego, solo se puede mover en forma horizontal(Izquierda o Derecha),
            crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve
            hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado.
             Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la
            derecha
             Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la derecha
             En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra
            dirección” */

            /* char Dirección = ' ';

             Console.WriteLine("Ingrese la dirección de movimiento  i:izquierda   d:derecha");
             Dirección = Convert.ToChar(Console.ReadLine());

             switch (Dirección)
             {
                 case 'i':
                     Console.WriteLine("El personaje se mueve hacia la izquierda");
                     break;
                 case 'd':
                     Console.WriteLine("El personaje se mueve hacia la derecha");
                     break;
                 default:
                     Console.WriteLine("No me puedo mover en otra dirección");
                     break;
             }*/

            /*El personaje de un juego, puede realizar diferentes acciones dependiendo del carácter que
            el usuario ingrese, y de la cantidad de vidas que posee. Crear un programa que permita:
             Generar un número aleatorio entre 0 y 5 para simular el número de vidas del personaje.
            (Función Random)
             Si el número de vidas es mayor a 0, el personaje puede realizar acciones en el juego. En
            caso contrario escribir el mensaje “el personaje no posee vidas, y no puede realizar
            ninguna acción”.
             Si el personaje puede realizar acciones, escribir los siguientes mensajes de acuerdo al
            carácter que se ingrese:
            o Si se ingresa ‘c’, mostrar en consola “el personaje está disparando”
            o Si se ingresa ‘x’, mostrar en consola “el personaje está hablando con la Rana”
            o Si se ingresa ‘t’, mostrar en consola “el personaje está en modo Turbo”
            o Si se presiona ‘i’, mostrar en consola “el personaje es Invencible” */

            Random rnd = new Random();
            int vidas = rnd.Next(0, 6);
            char estado = ' ';

            if (vidas > 0)
            {
                Console.WriteLine("El personaje puede realizar acciones.");
                Console.WriteLine("Ingrese un carácter (c, x, t, i):");
                estado = Convert.ToChar(Console.ReadLine());

                switch (estado)
                {
                    case 'c':
                        Console.WriteLine("El personaje está disparando");
                        break;
                    case 'x':
                        Console.WriteLine("El personaje está hablando con la Rana");
                        break;
                    case 't':
                        Console.WriteLine("El personaje está en modo Turbo");
                        break;
                    case 'i':
                        Console.WriteLine("El personaje es Invencible");
                        break;
                }
                    
            }
            else
            {
                Console.WriteLine("El personaje no posee vidas y no puede realizar acciones");
            }
        }
    }
}
